namespace Payroll.User
{
    partial class frmUserRegister
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
            this.components = new System.ComponentModel.Container();
            this.employee_name = new System.Windows.Forms.TextBox();
            this.employee_username = new System.Windows.Forms.TextBox();
            this.employee_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employee_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employee_birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.employee_position = new System.Windows.Forms.ComboBox();
            this.employee_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.register_save = new System.Windows.Forms.Button();
            this.register_update = new System.Windows.Forms.Button();
            this.register_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dg_serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_name
            // 
            this.employee_name.Location = new System.Drawing.Point(46, 149);
            this.employee_name.Name = "employee_name";
            this.employee_name.Size = new System.Drawing.Size(387, 26);
            this.employee_name.TabIndex = 0;
            this.employee_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // employee_username
            // 
            this.employee_username.Location = new System.Drawing.Point(46, 223);
            this.employee_username.Name = "employee_username";
            this.employee_username.Size = new System.Drawing.Size(190, 26);
            this.employee_username.TabIndex = 1;
            // 
            // employee_password
            // 
            this.employee_password.Location = new System.Drawing.Point(242, 223);
            this.employee_password.Name = "employee_password";
            this.employee_password.PasswordChar = '*';
            this.employee_password.Size = new System.Drawing.Size(191, 26);
            this.employee_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // employee_email
            // 
            this.employee_email.Location = new System.Drawing.Point(46, 284);
            this.employee_email.Name = "employee_email";
            this.employee_email.Size = new System.Drawing.Size(387, 26);
            this.employee_email.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Birthday";
            // 
            // employee_birthday
            // 
            this.employee_birthday.CustomFormat = "dd/MM/yyyy";
            this.employee_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.employee_birthday.Location = new System.Drawing.Point(41, 359);
            this.employee_birthday.Name = "employee_birthday";
            this.employee_birthday.Size = new System.Drawing.Size(190, 26);
            this.employee_birthday.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Position";
            // 
            // employee_position
            // 
            this.employee_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_position.FormattingEnabled = true;
            this.employee_position.Items.AddRange(new object[] {
            "Teacher"});
            this.employee_position.Location = new System.Drawing.Point(242, 359);
            this.employee_position.Name = "employee_position";
            this.employee_position.Size = new System.Drawing.Size(191, 28);
            this.employee_position.TabIndex = 12;
            // 
            // employee_address
            // 
            this.employee_address.Location = new System.Drawing.Point(46, 432);
            this.employee_address.Name = "employee_address";
            this.employee_address.Size = new System.Drawing.Size(387, 26);
            this.employee_address.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // register_save
            // 
            this.register_save.Location = new System.Drawing.Point(41, 483);
            this.register_save.Name = "register_save";
            this.register_save.Size = new System.Drawing.Size(120, 46);
            this.register_save.TabIndex = 15;
            this.register_save.Text = "Save";
            this.register_save.UseVisualStyleBackColor = true;
            this.register_save.Click += new System.EventHandler(this.register_save_Click);
            // 
            // register_update
            // 
            this.register_update.Location = new System.Drawing.Point(167, 483);
            this.register_update.Name = "register_update";
            this.register_update.Size = new System.Drawing.Size(131, 46);
            this.register_update.TabIndex = 16;
            this.register_update.Text = "Update";
            this.register_update.UseVisualStyleBackColor = true;
            this.register_update.Click += new System.EventHandler(this.register_update_Click);
            // 
            // register_delete
            // 
            this.register_delete.Location = new System.Drawing.Point(304, 483);
            this.register_delete.Name = "register_delete";
            this.register_delete.Size = new System.Drawing.Size(129, 46);
            this.register_delete.TabIndex = 17;
            this.register_delete.Text = "Delete";
            this.register_delete.UseVisualStyleBackColor = true;
            this.register_delete.Click += new System.EventHandler(this.register_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_serialnumber,
            this.dg_name,
            this.dg_birthday,
            this.dg_email,
            this.dg_username,
            this.dg_position,
            this.dg_address});
            this.dataGridView1.Location = new System.Drawing.Point(515, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 400);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // dg_serialnumber
            // 
            this.dg_serialnumber.HeaderText = "Serial Number";
            this.dg_serialnumber.MinimumWidth = 8;
            this.dg_serialnumber.Name = "dg_serialnumber";
            this.dg_serialnumber.Width = 150;
            // 
            // dg_name
            // 
            this.dg_name.HeaderText = "Name";
            this.dg_name.MinimumWidth = 8;
            this.dg_name.Name = "dg_name";
            this.dg_name.Width = 150;
            // 
            // dg_birthday
            // 
            this.dg_birthday.HeaderText = "Birthday";
            this.dg_birthday.MinimumWidth = 8;
            this.dg_birthday.Name = "dg_birthday";
            this.dg_birthday.Width = 150;
            // 
            // dg_email
            // 
            this.dg_email.HeaderText = "Email";
            this.dg_email.MinimumWidth = 8;
            this.dg_email.Name = "dg_email";
            this.dg_email.Width = 150;
            // 
            // dg_username
            // 
            this.dg_username.HeaderText = "Username";
            this.dg_username.MinimumWidth = 8;
            this.dg_username.Name = "dg_username";
            this.dg_username.Width = 150;
            // 
            // dg_position
            // 
            this.dg_position.HeaderText = "Position";
            this.dg_position.MinimumWidth = 8;
            this.dg_position.Name = "dg_position";
            this.dg_position.Width = 150;
            // 
            // dg_address
            // 
            this.dg_address.HeaderText = "Address";
            this.dg_address.MinimumWidth = 8;
            this.dg_address.Name = "dg_address";
            this.dg_address.Width = 150;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 778);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.register_delete);
            this.Controls.Add(this.register_update);
            this.Controls.Add(this.register_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employee_address);
            this.Controls.Add(this.employee_position);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.employee_birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employee_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_password);
            this.Controls.Add(this.employee_username);
            this.Controls.Add(this.employee_name);
            this.Name = "frmUserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.frmUserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employee_name;
        private System.Windows.Forms.TextBox employee_username;
        private System.Windows.Forms.TextBox employee_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox employee_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker employee_birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox employee_position;
        private System.Windows.Forms.TextBox employee_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button register_save;
        private System.Windows.Forms.Button register_update;
        private System.Windows.Forms.Button register_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_address;
    }
}