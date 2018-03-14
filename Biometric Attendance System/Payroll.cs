using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biometric_Attendance_System.Model;

namespace Biometric_Attendance_System
{
    public partial class Payroll : UserControl
    {
        private DataGridViewCellStyle inStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle outStyle = new DataGridViewCellStyle();
        private int emp = 7;
        public Payroll()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            inStyle.ForeColor = Color.Green;
            outStyle.ForeColor = Color.Red;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;

        }

        private void LoadEmployees()
        {
            var employees = Employee.GetEmployees();
            dgvEmployees.Rows.Clear();

            for (int i = 0; i < employees.Length; i++)
            {
                var employee = employees[i];
                dgvEmployees.Rows.Add(
                    i, employee.Id, employee.FirstName, employee.MiddleName, employee.LastName, employee.DepartmentId
                );
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                emp = (int)dgvEmployees.SelectedRows[0].Cells["ID"].Value;
                Employee employee = Employee.GetEmployee(emp);
                labelRate.Text = employee.Rate.ToString("#,###.##");
                dgvAttendance.Rows.Clear();
                dgvAttendance.Columns.Clear();
                timesheet.Rows.Clear();
                Attendance[] attendances = Attendance.GetAttendances(emp);
                var currentRowIndex = 0;
                var insertedRows = 0;
                for (int i = 0; i < attendances.Length; i++)
                {

                    if (attendances[i].Timestamp >= dateTimePicker1.Value && attendances[i].Timestamp <= dateTimePicker2.Value.AddDays(1))
                    {
                        var curDate = attendances[i].Timestamp;
                        if (!dgvAttendance.Columns.Contains(curDate.ToShortDateString()))
                        {
                            dgvAttendance.Columns.Add(curDate.ToShortDateString(), curDate.ToShortDateString());
                            currentRowIndex = 0;
                            //timesheet.Rows.Add(
                            //    curDate.ToShortDateString(),
                            //    );
                        }
                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = attendances[i].Timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                        if (attendances[i].Status == "in")
                        {
                            cell.Style = inStyle;
                        }
                        else
                        {
                            cell.Style = outStyle;
                        }
                        try
                        {
                            if (currentRowIndex == insertedRows)
                            {
                                dgvAttendance.Rows.Add();
                                insertedRows++;
                            }
                            dgvAttendance.Rows[currentRowIndex].Cells[curDate.ToShortDateString()] = (cell);
                        }
                        catch
                        {
                            // dgvAttendance.Rows[currentRowIndex].Cells.Add(cell);
                        }
                        finally
                        {
                            currentRowIndex++;
                        }
                    }
                }
                decimal overHours = 0;
                decimal totalHours = 0;
                for (int x = 0; x < dgvAttendance.ColumnCount; x++)
                {
                    decimal hours = 0;
                    DateTime? startTime = null;
                    DateTime? endTime = null;
                    for (int z = 0; z < dgvAttendance.RowCount; z++)
                    {
                        if (dgvAttendance.Rows[z].Cells[x].Value != null)
                        {
                            if (endTime != null && startTime != null)
                            {
                                hours += Convert.ToDecimal((endTime - startTime).Value.TotalHours);
                                //MessageBox.Show(hours.ToString());
                                startTime = null;
                                endTime = null;
                            }

                            if (dgvAttendance.Rows[z].Cells[x].Style.ForeColor == Color.Green)
                            {
                                startTime = DateTime.Parse(dgvAttendance.Rows[z].Cells[x].Value.ToString());
                            }
                            else
                            {
                                endTime = DateTime.Parse(dgvAttendance.Rows[z].Cells[x].Value.ToString());
                            }

                        }
                    }
                    hours += Convert.ToDecimal((endTime - startTime).Value.TotalHours);
                    //MessageBox.Show(hours.ToString());
                    startTime = null;
                    endTime = null;

                    if (hours > 8)
                    {
                        overHours = hours - 8;
                        hours = 8;
                    }
                    timesheet.Rows.Add(
                        x,
                        dgvAttendance.Columns[x].HeaderText,
                        hours,
                        overHours
                    );
                    totalHours += hours;
                }
            
            labelHours.Text = totalHours.ToString("#,###.##");
            labelOvertime.Text = overHours.ToString("#,###.##");
            labelSalary.Text = (totalHours * employee.Rate + (employee.Rate* Convert.ToDecimal(1.25) * overHours )).ToString("#,###.##");
            }
            catch
            {

            }

        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
    }
}
