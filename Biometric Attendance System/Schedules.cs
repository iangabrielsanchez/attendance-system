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
    public partial class Schedules : UserControl
    {
        Department[] departments;
        public Schedules()
        {
            InitializeComponent();
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            departments = Department.GetDepartments();
            dgvDepartments.Rows.Clear();
            for (int i = 0; i < departments.Length; i++)
            {
                var department = departments[i];
                dgvDepartments.Rows.Add(
                    i, department.Id, department.Name
                );
            }
        }

        private void EditMode(bool state)
        {
            dgvDepartments.Enabled = !state;
            buttonAdd.Enabled = !state;
            buttonEdit.Enabled = !state;
            panel1.Enabled = state;
            buttonSave.Enabled = state;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            EditMode(false);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditMode(true);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            dgvDepartments.Rows.Add();
            dgvDepartments.Rows[dgvDepartments.Rows.Count - 1].Selected = true;
            EditMode(true);
        }

        private void cbxmon_CheckedChanged(object sender, EventArgs e)
        {
            startmon.Enabled = cbxmon.Checked;
            endmon.Enabled = cbxmon.Checked;
        }

        private void cbxtue_CheckedChanged(object sender, EventArgs e)
        {
            starttue.Enabled = cbxtue.Checked;
            endtue.Enabled = cbxtue.Checked;
        }

        private void cbxwed_CheckedChanged(object sender, EventArgs e)
        {
            startwed.Enabled = cbxwed.Checked;
            endwed.Enabled = cbxwed.Checked;
        }

        private void cbxthurs_CheckedChanged(object sender, EventArgs e)
        {
            startthurs.Enabled = cbxthurs.Checked;
            endthurs.Enabled = cbxthurs.Checked;
        }

        private void cbxfri_CheckedChanged(object sender, EventArgs e)
        {
            startfri.Enabled = cbxfri.Checked;
            endfri.Enabled = cbxfri.Checked;
        }

        private void cbxsat_CheckedChanged(object sender, EventArgs e)
        {
            startsat.Enabled = cbxsat.Checked;
            endsat.Enabled = cbxsat.Checked;
        }

        private void cbxsun_CheckedChanged(object sender, EventArgs e)
        {
            startsun.Enabled = cbxsun.Checked;
            endsun.Enabled = cbxsun.Checked;
        }

        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int i = (int)dgvDepartments.SelectedRows[0].Cells["_index"].Value;
                var d = departments[i];
                txtDepName.Text = d.Name;
                if (d.StartMon.HasValue)
                {
                    cbxmon.Checked = true;
                    startmon.Value = DateTime.Today.Add(d.StartMon.Value);
                    endmon.Value = DateTime.Today.Add(d.EndMon.Value);
                }
                else
                {
                    cbxmon.Checked = false;
                    startmon.Enabled = false;
                    endmon.Enabled = false;
                }
                if (d.StartTue.HasValue)
                {
                    cbxtue.Checked = true;
                    starttue.Value = DateTime.Today.Add(d.StartTue.Value);
                    endtue.Value = DateTime.Today.Add(d.EndTue.Value);
                }
                else
                {
                    cbxtue.Checked = false;
                    starttue.Enabled = false;
                    endtue.Enabled = false;
                }
                if (d.StartWed.HasValue)
                {
                    cbxwed.Checked = true;
                    startwed.Value = DateTime.Today.Add(d.StartWed.Value);
                    endwed.Value = DateTime.Today.Add(d.EndWed.Value);
                }
                else
                {
                    cbxwed.Checked = false;
                    startwed.Enabled = false;
                    endwed.Enabled = false;
                }
                if (d.StartThurs.HasValue)
                {
                    cbxthurs.Checked = true;
                    startthurs.Value = DateTime.Today.Add(d.StartThurs.Value);
                    endthurs.Value = DateTime.Today.Add(d.EndThurs.Value);
                }
                else
                {
                    cbxthurs.Checked = false;
                    startthurs.Enabled = false;
                    endthurs.Enabled = false;
                }
                if (d.StartFri.HasValue)
                {
                    cbxfri.Checked = true;
                    startfri.Value = DateTime.Today.Add(d.StartFri.Value);
                    endfri.Value = DateTime.Today.Add(d.EndFri.Value);
                }
                else
                {
                    cbxfri.Checked = false;
                    startfri.Enabled = false;
                    endfri.Enabled = false;
                }
                if (d.StartSat.HasValue)
                {
                    cbxsat.Checked = true;
                    startsat.Value = DateTime.Today.Add(d.StartSat.Value);
                    endsat.Value = DateTime.Today.Add(d.EndSat.Value);
                }
                else
                {
                    cbxsat.Checked = false;
                    startsat.Enabled = false;
                    endsat.Enabled = false;
                }
                if (d.StartSun.HasValue)
                {
                    cbxsun.Checked = true;
                    startsun.Value = DateTime.Today.Add(d.StartSun.Value);
                    endsun.Value = DateTime.Today.Add(d.EndSun.Value);
                }
                else
                {
                    cbxsun.Checked = false;
                    startsun.Enabled = false;
                    endsun.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                txtDepName.Text = "";
                cbxmon.Checked = false;
                startmon.Enabled = false;
                endmon.Enabled = false;
                cbxtue.Checked = false;
                starttue.Enabled = false;
                endtue.Enabled = false;
                cbxwed.Checked = false;
                startwed.Enabled = false;
                endwed.Enabled = false;
                cbxthurs.Checked = false;
                startthurs.Enabled = false;
                endthurs.Enabled = false;
                cbxfri.Checked = false;
                startfri.Enabled = false;
                endfri.Enabled = false;
                cbxsat.Checked = false;
                startsat.Enabled = false;
                endsat.Enabled = false;
                cbxsun.Checked = false;
                startsun.Enabled = false;
                endsun.Enabled = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TimeSpan? s1=null, e1 = null, s2 = null, e2 = null, s3 = null, e3 = null, 
                s4 = null, e4 = null, s5 = null, e5 = null, s6 = null, e6 = null, s7 = null, e7 = null;
            if (cbxmon.Checked)
            {
                s1 = startmon.Value.TimeOfDay;
                e1 = endmon.Value.TimeOfDay;
            }
            if (cbxtue.Checked)
            {
                s2 = starttue.Value.TimeOfDay;
                e2 = endtue.Value.TimeOfDay;
            }
            if (cbxwed.Checked)
            {
                s3 = startwed.Value.TimeOfDay;
                e3 = endwed.Value.TimeOfDay;
            }
            if (cbxthurs.Checked){
                s4 = startthurs.Value.TimeOfDay;
                e4 = endthurs.Value.TimeOfDay;
            }
            if (cbxfri.Checked)
            {
                s5 = startfri.Value.TimeOfDay;
                e5 = endfri.Value.TimeOfDay;
            }
            if (cbxsat.Checked)
            {
                s6 = startsat.Value.TimeOfDay;
                e6 = endsat.Value.TimeOfDay;
            }
            if (cbxsat.Checked)
            {
                s7 = startsun.Value.TimeOfDay;
                e7 = endsat.Value.TimeOfDay;
            }

            Department department = new Department(
                -1,
                txtDepName.Text, "", s1, e1, s2, e2, s3, e3, s4, e4, s5, e5, s6, e6, s7, e7);
            Department.AddDepartments(department);
            Schedules_Load(null, null);
            EditMode(false);
        }
    }
}
