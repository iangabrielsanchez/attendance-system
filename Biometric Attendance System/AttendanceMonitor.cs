using Biometric_Attendance_System.Model;
using System;
using System.Windows.Forms;

namespace Biometric_Attendance_System
{
    public partial class AttendanceMonitor : Form
    {
        int timeout = 10;
        int timeBeforeTimeout = 0;
        public AttendanceMonitor()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeBeforeTimeout++;
            lblDT.Text = DateTime.Now.ToLongDateString() + " " +DateTime.Now.ToLongTimeString();
            if( timeBeforeTimeout == timeout)
            {
                ResetLabelValues();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = Employee.GetEmployee(int.Parse(textBox1.Text));
                label3.Text = employee.FirstName + " " + employee.MiddleName + " " + employee.LastName;
                Department department = Department.GetDepartment(employee.DepartmentId);
                label4.Text = department.Name;
                //label5.Text = employee.Status == 1 ? "Time In" : "Time Out";
                //employee.Status = employee.Status == 1 ? (ulong)0 : (ulong)1;
                Employee.EditEmployee(employee.Id, employee);
                Attendance.AddAttendance(employee.Id);
                pictureBox1.Image = Properties.Resources.avatar;
            }
            catch(Exception)
            {
                label3.Text = "UNKNOWN";
            }
            finally
            {
                timeBeforeTimeout = 0;
            }

        }

        private void ResetLabelValues()
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            pictureBox1.Image = null;
            timeBeforeTimeout = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.MainForm.Show();
        }
    }
}
