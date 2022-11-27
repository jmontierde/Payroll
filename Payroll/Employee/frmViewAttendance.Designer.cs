namespace Payroll.Employee
{
    partial class frmViewAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.Label();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dg_employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_totalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_workingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_presentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_absentDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_lopDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "All",
            "Employee ID"});
            this.cmbSearch.Location = new System.Drawing.Point(227, 98);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(261, 28);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // cmbYears
            // 
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbYears.Location = new System.Drawing.Point(633, 98);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(261, 28);
            this.cmbYears.TabIndex = 3;
            // 
            // cmbYear
            // 
            this.cmbYear.AutoSize = true;
            this.cmbYear.Location = new System.Drawing.Point(554, 98);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(43, 20);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.Text = "Year";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(227, 180);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 26);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoSize = true;
            this.cmbMonth.Location = new System.Drawing.Point(554, 186);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(54, 20);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.Text = "Month";
            // 
            // cmbMonths
            // 
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonths.Location = new System.Drawing.Point(633, 178);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(261, 28);
            this.cmbMonths.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_employeeId,
            this.dg_employeeName,
            this.dg_year,
            this.dg_month,
            this.dg_totalDays,
            this.dg_workingDays,
            this.dg_presentDays,
            this.dg_absentDays,
            this.dg_lopDays});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(152, 427);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 275);
            this.dataGridView1.TabIndex = 8;
            // 
            // dg_employeeId
            // 
            this.dg_employeeId.HeaderText = "Employee ID";
            this.dg_employeeId.MinimumWidth = 8;
            this.dg_employeeId.Name = "dg_employeeId";
            // 
            // dg_employeeName
            // 
            this.dg_employeeName.HeaderText = "Name";
            this.dg_employeeName.MinimumWidth = 8;
            this.dg_employeeName.Name = "dg_employeeName";
            // 
            // dg_year
            // 
            this.dg_year.HeaderText = "Year";
            this.dg_year.MinimumWidth = 8;
            this.dg_year.Name = "dg_year";
            // 
            // dg_month
            // 
            this.dg_month.HeaderText = "Month";
            this.dg_month.MinimumWidth = 8;
            this.dg_month.Name = "dg_month";
            // 
            // dg_totalDays
            // 
            this.dg_totalDays.HeaderText = "Total Days";
            this.dg_totalDays.MinimumWidth = 8;
            this.dg_totalDays.Name = "dg_totalDays";
            // 
            // dg_workingDays
            // 
            this.dg_workingDays.HeaderText = "Working Days";
            this.dg_workingDays.MinimumWidth = 8;
            this.dg_workingDays.Name = "dg_workingDays";
            // 
            // dg_presentDays
            // 
            this.dg_presentDays.HeaderText = "Present";
            this.dg_presentDays.MinimumWidth = 8;
            this.dg_presentDays.Name = "dg_presentDays";
            // 
            // dg_absentDays
            // 
            this.dg_absentDays.HeaderText = "Absent Days";
            this.dg_absentDays.MinimumWidth = 8;
            this.dg_absentDays.Name = "dg_absentDays";
            // 
            // dg_lopDays
            // 
            this.dg_lopDays.HeaderText = "Loss of Pay Days";
            this.dg_lopDays.MinimumWidth = 8;
            this.dg_lopDays.Name = "dg_lopDays";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(487, 295);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(128, 57);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 737);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbYears);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmViewAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Attendance";
            this.Load += new System.EventHandler(this.frmViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Label cmbYear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label cmbMonth;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_month;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_totalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_workingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_presentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_absentDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_lopDays;
        private System.Windows.Forms.Button btnView;
    }
}