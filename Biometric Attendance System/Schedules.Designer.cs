namespace Biometric_Attendance_System
{
    partial class Schedules
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this._index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endsun = new System.Windows.Forms.DateTimePicker();
            this.startsun = new System.Windows.Forms.DateTimePicker();
            this.cbxsun = new System.Windows.Forms.CheckBox();
            this.endsat = new System.Windows.Forms.DateTimePicker();
            this.startsat = new System.Windows.Forms.DateTimePicker();
            this.cbxsat = new System.Windows.Forms.CheckBox();
            this.endfri = new System.Windows.Forms.DateTimePicker();
            this.startfri = new System.Windows.Forms.DateTimePicker();
            this.cbxfri = new System.Windows.Forms.CheckBox();
            this.endthurs = new System.Windows.Forms.DateTimePicker();
            this.startthurs = new System.Windows.Forms.DateTimePicker();
            this.cbxthurs = new System.Windows.Forms.CheckBox();
            this.endwed = new System.Windows.Forms.DateTimePicker();
            this.startwed = new System.Windows.Forms.DateTimePicker();
            this.cbxwed = new System.Windows.Forms.CheckBox();
            this.endtue = new System.Windows.Forms.DateTimePicker();
            this.starttue = new System.Windows.Forms.DateTimePicker();
            this.cbxtue = new System.Windows.Forms.CheckBox();
            this.endmon = new System.Windows.Forms.DateTimePicker();
            this.startmon = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxmon = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departments";
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._index,
            this.ID,
            this.DepartmentName});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartments.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDepartments.Location = new System.Drawing.Point(6, 21);
            this.dgvDepartments.MultiSelect = false;
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersVisible = false;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(535, 625);
            this.dgvDepartments.TabIndex = 1;
            this.dgvDepartments.SelectionChanged += new System.EventHandler(this.dgvDepartments_SelectionChanged);
            // 
            // _index
            // 
            this._index.HeaderText = "_index";
            this._index.Name = "_index";
            this._index.ReadOnly = true;
            this._index.Visible = false;
            // 
            // ID
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle10;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DepartmentName
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DepartmentName.DefaultCellStyle = dataGridViewCellStyle11;
            this.DepartmentName.HeaderText = "Department Name";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEdit.Location = new System.Drawing.Point(456, 652);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 35);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonAdd.Location = new System.Drawing.Point(6, 654);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 35);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.endsun);
            this.panel1.Controls.Add(this.startsun);
            this.panel1.Controls.Add(this.cbxsun);
            this.panel1.Controls.Add(this.endsat);
            this.panel1.Controls.Add(this.startsat);
            this.panel1.Controls.Add(this.cbxsat);
            this.panel1.Controls.Add(this.endfri);
            this.panel1.Controls.Add(this.startfri);
            this.panel1.Controls.Add(this.cbxfri);
            this.panel1.Controls.Add(this.endthurs);
            this.panel1.Controls.Add(this.startthurs);
            this.panel1.Controls.Add(this.cbxthurs);
            this.panel1.Controls.Add(this.endwed);
            this.panel1.Controls.Add(this.startwed);
            this.panel1.Controls.Add(this.cbxwed);
            this.panel1.Controls.Add(this.endtue);
            this.panel1.Controls.Add(this.starttue);
            this.panel1.Controls.Add(this.cbxtue);
            this.panel1.Controls.Add(this.endmon);
            this.panel1.Controls.Add(this.startmon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxmon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDepName);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(547, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 625);
            this.panel1.TabIndex = 22;
            // 
            // endsun
            // 
            this.endsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endsun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endsun.Location = new System.Drawing.Point(340, 453);
            this.endsun.Name = "endsun";
            this.endsun.Size = new System.Drawing.Size(137, 24);
            this.endsun.TabIndex = 64;
            // 
            // startsun
            // 
            this.startsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startsun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startsun.Location = new System.Drawing.Point(180, 453);
            this.startsun.Name = "startsun";
            this.startsun.Size = new System.Drawing.Size(137, 24);
            this.startsun.TabIndex = 63;
            // 
            // cbxsun
            // 
            this.cbxsun.AutoSize = true;
            this.cbxsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsun.Location = new System.Drawing.Point(45, 457);
            this.cbxsun.Name = "cbxsun";
            this.cbxsun.Size = new System.Drawing.Size(76, 22);
            this.cbxsun.TabIndex = 62;
            this.cbxsun.Text = "Sunday";
            this.cbxsun.UseVisualStyleBackColor = true;
            this.cbxsun.CheckedChanged += new System.EventHandler(this.cbxsun_CheckedChanged);
            // 
            // endsat
            // 
            this.endsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endsat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endsat.Location = new System.Drawing.Point(340, 393);
            this.endsat.Name = "endsat";
            this.endsat.Size = new System.Drawing.Size(137, 24);
            this.endsat.TabIndex = 58;
            // 
            // startsat
            // 
            this.startsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startsat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startsat.Location = new System.Drawing.Point(180, 393);
            this.startsat.Name = "startsat";
            this.startsat.Size = new System.Drawing.Size(137, 24);
            this.startsat.TabIndex = 57;
            // 
            // cbxsat
            // 
            this.cbxsat.AutoSize = true;
            this.cbxsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxsat.Location = new System.Drawing.Point(45, 397);
            this.cbxsat.Name = "cbxsat";
            this.cbxsat.Size = new System.Drawing.Size(85, 22);
            this.cbxsat.TabIndex = 56;
            this.cbxsat.Text = "Saturday";
            this.cbxsat.UseVisualStyleBackColor = true;
            this.cbxsat.CheckedChanged += new System.EventHandler(this.cbxsat_CheckedChanged);
            // 
            // endfri
            // 
            this.endfri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endfri.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endfri.Location = new System.Drawing.Point(340, 333);
            this.endfri.Name = "endfri";
            this.endfri.Size = new System.Drawing.Size(137, 24);
            this.endfri.TabIndex = 52;
            // 
            // startfri
            // 
            this.startfri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startfri.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startfri.Location = new System.Drawing.Point(180, 333);
            this.startfri.Name = "startfri";
            this.startfri.Size = new System.Drawing.Size(137, 24);
            this.startfri.TabIndex = 51;
            // 
            // cbxfri
            // 
            this.cbxfri.AutoSize = true;
            this.cbxfri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxfri.Location = new System.Drawing.Point(45, 337);
            this.cbxfri.Name = "cbxfri";
            this.cbxfri.Size = new System.Drawing.Size(67, 22);
            this.cbxfri.TabIndex = 50;
            this.cbxfri.Text = "Friday";
            this.cbxfri.UseVisualStyleBackColor = true;
            this.cbxfri.CheckedChanged += new System.EventHandler(this.cbxfri_CheckedChanged);
            // 
            // endthurs
            // 
            this.endthurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endthurs.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endthurs.Location = new System.Drawing.Point(340, 273);
            this.endthurs.Name = "endthurs";
            this.endthurs.Size = new System.Drawing.Size(137, 24);
            this.endthurs.TabIndex = 46;
            // 
            // startthurs
            // 
            this.startthurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startthurs.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startthurs.Location = new System.Drawing.Point(180, 273);
            this.startthurs.Name = "startthurs";
            this.startthurs.Size = new System.Drawing.Size(137, 24);
            this.startthurs.TabIndex = 45;
            // 
            // cbxthurs
            // 
            this.cbxthurs.AutoSize = true;
            this.cbxthurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxthurs.Location = new System.Drawing.Point(45, 277);
            this.cbxthurs.Name = "cbxthurs";
            this.cbxthurs.Size = new System.Drawing.Size(88, 22);
            this.cbxthurs.TabIndex = 44;
            this.cbxthurs.Text = "Thursday";
            this.cbxthurs.UseVisualStyleBackColor = true;
            this.cbxthurs.CheckedChanged += new System.EventHandler(this.cbxthurs_CheckedChanged);
            // 
            // endwed
            // 
            this.endwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endwed.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endwed.Location = new System.Drawing.Point(340, 213);
            this.endwed.Name = "endwed";
            this.endwed.Size = new System.Drawing.Size(137, 24);
            this.endwed.TabIndex = 40;
            // 
            // startwed
            // 
            this.startwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startwed.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startwed.Location = new System.Drawing.Point(180, 213);
            this.startwed.Name = "startwed";
            this.startwed.Size = new System.Drawing.Size(137, 24);
            this.startwed.TabIndex = 39;
            // 
            // cbxwed
            // 
            this.cbxwed.AutoSize = true;
            this.cbxwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxwed.Location = new System.Drawing.Point(45, 217);
            this.cbxwed.Name = "cbxwed";
            this.cbxwed.Size = new System.Drawing.Size(105, 22);
            this.cbxwed.TabIndex = 38;
            this.cbxwed.Text = "Wednesday";
            this.cbxwed.UseVisualStyleBackColor = true;
            this.cbxwed.CheckedChanged += new System.EventHandler(this.cbxwed_CheckedChanged);
            // 
            // endtue
            // 
            this.endtue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endtue.Location = new System.Drawing.Point(340, 153);
            this.endtue.Name = "endtue";
            this.endtue.Size = new System.Drawing.Size(137, 24);
            this.endtue.TabIndex = 34;
            // 
            // starttue
            // 
            this.starttue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.starttue.Location = new System.Drawing.Point(180, 153);
            this.starttue.Name = "starttue";
            this.starttue.Size = new System.Drawing.Size(137, 24);
            this.starttue.TabIndex = 33;
            // 
            // cbxtue
            // 
            this.cbxtue.AutoSize = true;
            this.cbxtue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtue.Location = new System.Drawing.Point(45, 157);
            this.cbxtue.Name = "cbxtue";
            this.cbxtue.Size = new System.Drawing.Size(83, 22);
            this.cbxtue.TabIndex = 32;
            this.cbxtue.Text = "Tuesday";
            this.cbxtue.UseVisualStyleBackColor = true;
            this.cbxtue.CheckedChanged += new System.EventHandler(this.cbxtue_CheckedChanged);
            // 
            // endmon
            // 
            this.endmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endmon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endmon.Location = new System.Drawing.Point(340, 93);
            this.endmon.Name = "endmon";
            this.endmon.Size = new System.Drawing.Size(137, 24);
            this.endmon.TabIndex = 28;
            // 
            // startmon
            // 
            this.startmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startmon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startmon.Location = new System.Drawing.Point(180, 93);
            this.startmon.Name = "startmon";
            this.startmon.Size = new System.Drawing.Size(137, 24);
            this.startmon.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Start Time:";
            // 
            // cbxmon
            // 
            this.cbxmon.AutoSize = true;
            this.cbxmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmon.Location = new System.Drawing.Point(45, 97);
            this.cbxmon.Name = "cbxmon";
            this.cbxmon.Size = new System.Drawing.Size(80, 22);
            this.cbxmon.TabIndex = 24;
            this.cbxmon.Text = "Monday";
            this.cbxmon.UseVisualStyleBackColor = true;
            this.cbxmon.CheckedChanged += new System.EventHandler(this.cbxmon_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Department Name:";
            // 
            // txtDepName
            // 
            this.txtDepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepName.Location = new System.Drawing.Point(236, 3);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(210, 24);
            this.txtDepName.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonSave.Location = new System.Drawing.Point(987, 652);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 35);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonCancel.Location = new System.Drawing.Point(896, 652);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 35);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.label1);
            this.Name = "Schedules";
            this.Size = new System.Drawing.Size(1075, 692);
            this.Load += new System.EventHandler(this.Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn _index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.DateTimePicker endsun;
        private System.Windows.Forms.DateTimePicker startsun;
        private System.Windows.Forms.CheckBox cbxsun;
        private System.Windows.Forms.DateTimePicker endsat;
        private System.Windows.Forms.DateTimePicker startsat;
        private System.Windows.Forms.CheckBox cbxsat;
        private System.Windows.Forms.DateTimePicker endfri;
        private System.Windows.Forms.DateTimePicker startfri;
        private System.Windows.Forms.CheckBox cbxfri;
        private System.Windows.Forms.DateTimePicker endthurs;
        private System.Windows.Forms.DateTimePicker startthurs;
        private System.Windows.Forms.CheckBox cbxthurs;
        private System.Windows.Forms.DateTimePicker endwed;
        private System.Windows.Forms.DateTimePicker startwed;
        private System.Windows.Forms.CheckBox cbxwed;
        private System.Windows.Forms.DateTimePicker endtue;
        private System.Windows.Forms.DateTimePicker starttue;
        private System.Windows.Forms.CheckBox cbxtue;
        private System.Windows.Forms.DateTimePicker endmon;
        private System.Windows.Forms.DateTimePicker startmon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxmon;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
