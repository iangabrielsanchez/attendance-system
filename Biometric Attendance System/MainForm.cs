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
        Employees employees = new Employees() { Dock = DockStyle.Fill, Visible = true };
        Schedules schedules = new Schedules() { Dock = DockStyle.Fill, Visible = true };
        Payroll payroll = new Payroll() { Dock = DockStyle.Fill, Visible = true };

        string activeButton = "";
        Color blue = Color.FromArgb(58, 154, 217);
        Color white = Color.FromArgb(255, 255, 255);
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            container.Controls.Add(employees);
            container.Controls.Add(schedules);
            container.Controls.Add(payroll);
            ActivateButton(buttonEmployees, null);
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                IsButtonActive(b, true);
            }
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (b.Text != activeButton)
                {
                    IsButtonActive(b, false);
                }
            }
        }

        private void ActivateButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            IsButtonActive(button, true);
            activeButton = button.Text;

            ShowControl();
            foreach (var control in nav.Controls)
            {
                if (control is Button b)
                {
                    if (b != button)
                    {
                        IsButtonActive(b, false);
                    }
                }
            }
            
        }

        private void ShowControl()
        {
            //container.Controls.Clear();
            switch (activeButton)
            {
                case "Employees":
                    //container.Controls.Add(employees);
                    employees.BringToFront();
                    break;
                case "Schedules":
                    //container.Controls.Add(schedules);
                    schedules.BringToFront();
                    break;
                case "Payroll":
                    payroll.BringToFront();
                    break;
                default: break;
            }
        }

        private void IsButtonActive(Button b, bool active)
        {
            if (!active)
            {
                b.BackColor = blue;
                b.ForeColor = white;
                b.FlatAppearance.BorderColor = blue;
            }
            else
            {
                b.BackColor = white;
                b.ForeColor = blue;
                b.FlatAppearance.BorderColor = white;
            }
            
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Program.AttendanceMonitor.Show();            
        }
    }
}
