using System;
using System.Windows.Forms;
using Biometric_Attendance_System.Model;

namespace Biometric_Attendance_System
{
    public partial class EmployeeRegistration : UserControl
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        //private void loadEmployees()
        //{
        //    Employee[] employees = Employee.GetEmployees();
        //    foreach(Employee employee in employees)
        //    {
        //        dgvEmployees.Rows.Add(
        //            employee.Id,
        //            employee.FirstName,
        //            employee.MiddleName,
        //            employee.LastName,
        //            employee.DepartmentId,
        //            employee.Status,
        //            employee.DateCreated,
        //            employee.DateUpdated
        //        );
        //    }
        //}

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            //loadEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddEmployee().ShowDialog();
        }
    }
}
