using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Biometric_Attendance_System.Model;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace Biometric_Attendance_System
{
    public partial class Employees : UserControl
    {
        Dictionary<string, string> templates = new Dictionary<string, string>();
        Employee[] employees;
        Department[] departments;
        string activeTemplate;
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmployees();
            panelPersonDetails.Enabled = false;
        }

        private void Employees_VisibleChanged(object sender, EventArgs e)
        {
            Program.biometrics.InitEngine();
            Program.biometrics.engine.OnCapture += Engine_OnCapture;
            Program.biometrics.engine.OnEnroll += Engine_OnEnroll;
            Program.biometrics.engine.OnCapture += Engine_OnCapture;
        }

        private void LoadDepartments()
        {
            departments = Department.GetDepartments();
            cbxDepartment.Items.Clear();
            foreach (var department in departments)
            {
                cbxDepartment.Items.Add(department.Name);
            }
        }

        private void LoadEmployees()
        {
            employees = Employee.GetEmployees();
            dgvEmployees.Rows.Clear();

            for (int i = 0; i < employees.Length; i++)
            {
                var employee = employees[i];
                dgvEmployees.Rows.Add(
                    i, employee.Id, employee.FirstName, employee.MiddleName, employee.LastName, employee.DepartmentId
                );
            }
        }

        private void SetControlsEnabled(bool state)
        {
            foreach (var control in panelPersonDetails.Controls)
            {
                ((Control)control).Enabled = state;
            }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = (int)dgvEmployees.SelectedRows[0].Cells["_index"].Value;
                SetDetails(employees[i]);
            }
            catch (Exception)
            {
                Employee employee = new Employee();
                SetDetails(employee);
            }
        }

        private void SetDetails(Employee employee)
        {
            txtId.Text = employee.Id.ToString();
            txtFirstName.Text = employee.FirstName;
            txtMiddleName.Text = employee.MiddleName;
            txtLastName.Text = employee.LastName;
            cbxSex.Text = employee.Sex;
            dtpBirthDate.Value = employee.BirthDate==null ? employee.BirthDate : DateTime.Today;
            txtContact.Text = employee.Contact;
            txtAddress.Text = employee.Address;
            dtpDateEmployed.Value = employee.DateEmployed==null ? employee.DateEmployed : DateTime.Today;
            cbxDepartment.SelectedIndex = employee.DepartmentId;
            txtPosition.Text = employee.Position;
            txtRate.Text = employee.Rate.ToString();
            txtTIN.Text = employee.TIN;
            txtSSN.Text = employee.SSN;
            txtPhilHealth.Text = employee.PhilHealth;
            txtPagibig.Text = employee.Pagibig;
            activeTemplate = employee.Fingerprint;
            pictureBoxFingerprint.Image = String.IsNullOrEmpty(activeTemplate) ? null : Properties.Resources.fingerprint;
            profilePicture.ImageLocation = employee.ImageLocation;
        }

        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ToggleEdit(true);
        }

        private void ToggleEdit(bool IsEditing)
        {
            //dgvEmployees.Enabled = !IsEditing;
            splitContainer1.Panel1.Enabled = !IsEditing;
            panelPersonDetails.Enabled = IsEditing;
        }

        private void Engine_OnCapture(bool ActionResult, object ATemplate)
        {
            if (ActionResult)
            {
                if (panelPersonDetails.Enabled)
                {
                    Program.biometrics.BeepAsync();
                    if (Program.biometrics.engine.LastQuality < 65)
                    {
                        Program.biometrics.Fail();
                        MessageBox.Show("Please put your finger firmly.");
                        activeTemplate = "";
                    }
                    else
                    {
                        Program.biometrics.Success();
                        pictureBoxFingerprint.Image = Program.biometrics.GetImage();
                        activeTemplate = Program.biometrics.engine.GetTemplateAsStringEx("9");
                    }
                }
            }
        }

        private void Engine_OnEnroll(bool ActionResult, object ATemplate)
        {
            if (ActionResult)
            {
                if (Program.biometrics.engine.LastQuality >= 60) //to ensure the fingerprint quality
                {
                    string regTemplate = Program.biometrics.engine.GetTemplateAsStringEx("9");                    
                    MessageBox.Show(regTemplate);
                    Clipboard.SetText(regTemplate);
                    //File.WriteAllText(Application.StartupPath + "\\fingerprint.txt", regTemplate);
                    MessageBox.Show("registered");
                }
                else
                {
                    MessageBox.Show("quality low");
                }
            }
            else
            {
                MessageBox.Show("register fail");
            }
        }

        private void buttonClearFinger_Click(object sender, EventArgs e)
        {
            pictureBoxFingerprint.Image = Properties.Resources.fingerprint;
            activeTemplate = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee(
                    String.IsNullOrEmpty(txtId.Text) ? -1 : int.Parse(txtId.Text),
                    txtFirstName.Text,
                    txtMiddleName.Text,
                    txtLastName.Text,
                    cbxDepartment.SelectedIndex + 1,
                    txtPosition.Text,
                    txtAddress.Text,
                    cbxSex.Text,
                    dtpBirthDate.Value,
                    dtpDateEmployed.Value,
                    txtTIN.Text,
                    txtSSN.Text,
                    txtPhilHealth.Text,
                    txtPagibig.Text,
                    txtContact.Text,
                    decimal.Parse(txtRate.Text),
                    activeTemplate,
                    profilePicture.ImageLocation
                );
                if(employee.Id == -1 || employee.Id == 0)
                {
                    Employee.AddEmployee(employee);
                }
                else
                {
                    Employee.EditEmployee(employee.Id, employee);
                }
                LoadEmployees();
                dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                ToggleEdit(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill in all fields " + ex.StackTrace);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dgvEmployees_SelectionChanged(sender, e);
            ToggleEdit(false);
            LoadEmployees();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ToggleEdit(true);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Add();
            dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
            ToggleEdit(true);
        }

        private void buttonBrowsePic_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
            if (dialog.ShowDialog(Program.MainForm) == DialogResult.OK)
            {
                profilePicture.ImageLocation = dialog.FileName;
                
            }

        }

        private void buttonClearPic_Click(object sender, EventArgs e)
        {
            profilePicture.ImageLocation = null;
        }
    }
}
