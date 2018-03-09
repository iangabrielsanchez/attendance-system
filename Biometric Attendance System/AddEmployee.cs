using Biometric_Attendance_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric_Attendance_System
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Department[] departments = Department.GetDepartments();
            foreach(Department department in departments)
            {
                comboBox1.Items.Add(department.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string middleName = textBox2.Text;
            string lastName = textBox3.Text;
            int department = comboBox1.SelectedIndex;
            Employee employee = new Employee(
                -1,
                firstName,
                middleName,
                lastName,
                department,
                0,
                new DateTime(),
                new DateTime()
            );
            Employee.AddEmployee(employee);
            MessageBox.Show("Employee Added");
            Close();

        }
    }
}
