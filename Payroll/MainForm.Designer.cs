namespace Payroll
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(186, 668);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegisterToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 29);
            this.toolStripMenuItem1.Text = "User";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // userRegisterToolStripMenuItem
            // 
            this.userRegisterToolStripMenuItem.Name = "userRegisterToolStripMenuItem";
            this.userRegisterToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.userRegisterToolStripMenuItem.Text = "User Register";
            this.userRegisterToolStripMenuItem.Click += new System.EventHandler(this.userRegisterToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegisterToolStripMenuItem,
            this.employeeSalaryToolStripMenuItem,
            this.employeeAttendanceToolStripMenuItem,
            this.attendanceViewToolStripMenuItem,
            this.salaryProcessToolStripMenuItem});
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // employeeRegisterToolStripMenuItem
            // 
            this.employeeRegisterToolStripMenuItem.Name = "employeeRegisterToolStripMenuItem";
            this.employeeRegisterToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.employeeRegisterToolStripMenuItem.Text = "Employee Register";
            this.employeeRegisterToolStripMenuItem.Click += new System.EventHandler(this.employeeRegisterToolStripMenuItem_Click_1);
            // 
            // employeeSalaryToolStripMenuItem
            // 
            this.employeeSalaryToolStripMenuItem.Name = "employeeSalaryToolStripMenuItem";
            this.employeeSalaryToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.employeeSalaryToolStripMenuItem.Text = "Employee Salary";
            this.employeeSalaryToolStripMenuItem.Click += new System.EventHandler(this.employeeSalaryToolStripMenuItem_Click);
            // 
            // employeeAttendanceToolStripMenuItem
            // 
            this.employeeAttendanceToolStripMenuItem.Name = "employeeAttendanceToolStripMenuItem";
            this.employeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.employeeAttendanceToolStripMenuItem.Text = "Employee Attendance";
            this.employeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.employeeAttendanceToolStripMenuItem_Click);
            // 
            // attendanceViewToolStripMenuItem
            // 
            this.attendanceViewToolStripMenuItem.Name = "attendanceViewToolStripMenuItem";
            this.attendanceViewToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.attendanceViewToolStripMenuItem.Text = "Attendance View";
            this.attendanceViewToolStripMenuItem.Click += new System.EventHandler(this.attendanceViewToolStripMenuItem_Click);
            // 
            // salaryProcessToolStripMenuItem
            // 
            this.salaryProcessToolStripMenuItem.Name = "salaryProcessToolStripMenuItem";
            this.salaryProcessToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.salaryProcessToolStripMenuItem.Text = "Salary Process";
            this.salaryProcessToolStripMenuItem.Click += new System.EventHandler(this.salaryProcessToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1167, 668);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryProcessToolStripMenuItem;
    }
}