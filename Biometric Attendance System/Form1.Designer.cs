namespace Biometric_Attendance_System
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nav = new System.Windows.Forms.Panel();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.buttonSchedules = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.containerParent = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.nav.SuspendLayout();
            this.containerParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 44);
            this.panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(790, 6);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(132, 32);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Admin";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(926, 6);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(73, 32);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.buttonLogout.MouseLeave += new System.EventHandler(this.Mouse_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biometric Attendance System";
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.nav.Controls.Add(this.buttonPayroll);
            this.nav.Controls.Add(this.buttonSchedules);
            this.nav.Controls.Add(this.buttonEmployees);
            this.nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.nav.Location = new System.Drawing.Point(0, 44);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(209, 617);
            this.nav.TabIndex = 1;
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayroll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.buttonPayroll.Location = new System.Drawing.Point(0, 61);
            this.buttonPayroll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(209, 32);
            this.buttonPayroll.TabIndex = 2;
            this.buttonPayroll.Text = "Payroll";
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.ActivateButton);
            this.buttonPayroll.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.buttonPayroll.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // buttonSchedules
            // 
            this.buttonSchedules.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.buttonSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSchedules.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.buttonSchedules.Location = new System.Drawing.Point(0, 30);
            this.buttonSchedules.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSchedules.Name = "buttonSchedules";
            this.buttonSchedules.Size = new System.Drawing.Size(209, 32);
            this.buttonSchedules.TabIndex = 1;
            this.buttonSchedules.Text = "Schedules";
            this.buttonSchedules.UseVisualStyleBackColor = true;
            this.buttonSchedules.Click += new System.EventHandler(this.ActivateButton);
            this.buttonSchedules.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.buttonSchedules.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(154)))), ((int)(((byte)(217)))));
            this.buttonEmployees.Location = new System.Drawing.Point(0, -1);
            this.buttonEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(209, 32);
            this.buttonEmployees.TabIndex = 0;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.ActivateButton);
            this.buttonEmployees.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.buttonEmployees.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // containerParent
            // 
            this.containerParent.Controls.Add(this.container);
            this.containerParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerParent.Location = new System.Drawing.Point(209, 44);
            this.containerParent.Margin = new System.Windows.Forms.Padding(2);
            this.containerParent.Name = "containerParent";
            this.containerParent.Size = new System.Drawing.Size(799, 617);
            this.containerParent.TabIndex = 2;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Location = new System.Drawing.Point(6, 6);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(784, 599);
            this.container.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.containerParent);
            this.Controls.Add(this.nav);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1024, 700);
            this.Name = "MainForm";
            this.Text = "Biometric Attendance System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nav.ResumeLayout(false);
            this.containerParent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel containerParent;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonSchedules;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.Panel container;
    }
}

