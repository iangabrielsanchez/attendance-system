using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ZKFPEngXControl;

namespace Biometric_Attendance_System
{
    public partial class MainForm : Form
    {
        Employees employees = new Employees();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(employees);
            employees.Dock = DockStyle.Fill;
            employees.Visible = true;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                InvertColor((Button)sender);
            }
            
        }

        private void InvertColor(Button button)
        {
            Color fore = button.ForeColor;
            Color back = button.BackColor;
            button.ForeColor = back;
            button.BackColor = fore;
        }
        
    }
}
