namespace Payroll.Employee
{
    partial class frmEmployeeRegisterr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeRegisterr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeePictureBox = new System.Windows.Forms.PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPAN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dg_EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_pan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_bankDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeePictureBox
            // 
            this.employeePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
            this.employeePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("employeePictureBox.Image")));
            this.employeePictureBox.Location = new System.Drawing.Point(41, 39);
            this.employeePictureBox.Name = "employeePictureBox";
            this.employeePictureBox.Size = new System.Drawing.Size(291, 282);
            this.employeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeePictureBox.TabIndex = 0;
            this.employeePictureBox.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.lblFileName.Location = new System.Drawing.Point(36, 349);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 25);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File Name";
            this.lblFileName.Visible = false;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddFile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddFile.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAddFile.FlatAppearance.BorderSize = 5;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddFile.Location = new System.Drawing.Point(36, 397);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(143, 65);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnRemoveFile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRemoveFile.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnRemoveFile.FlatAppearance.BorderSize = 5;
            this.btnRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFile.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveFile.Location = new System.Drawing.Point(189, 397);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(143, 65);
            this.btnRemoveFile.TabIndex = 3;
            this.btnRemoveFile.Text = "Remove";
            this.btnRemoveFile.UseVisualStyleBackColor = false;
            this.btnRemoveFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(405, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(546, 103);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(293, 30);
            this.txtMobile.TabIndex = 7;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(405, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobile No.";
            // 
            // txtPAN
            // 
            this.txtPAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAN.Location = new System.Drawing.Point(546, 163);
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.Size = new System.Drawing.Size(293, 30);
            this.txtPAN.TabIndex = 9;
            this.txtPAN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPAN_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(405, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "PAN No.";
            // 
            // txtBank
            // 
            this.txtBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.Location = new System.Drawing.Point(546, 224);
            this.txtBank.Multiline = true;
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(293, 32);
            this.txtBank.TabIndex = 11;
            this.txtBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBank_KeyDown);
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.lbl4.Location = new System.Drawing.Point(405, 232);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(133, 25);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Bank Details";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(119)))), ((int)(((byte)(123)))));
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(546, 39);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Size = new System.Drawing.Size(293, 30);
            this.txtEmpId.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label6.Location = new System.Drawing.Point(856, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(959, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 30);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label7.Location = new System.Drawing.Point(856, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label8.Location = new System.Drawing.Point(856, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Birthday";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.label9.Location = new System.Drawing.Point(856, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(959, 224);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(288, 32);
            this.txtAddress.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSave.FlatAppearance.BorderSize = 5;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(603, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 69);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(788, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 69);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(959, 320);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 69);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
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
            this.dg_EmpID,
            this.dg_name,
            this.dg_mobile,
            this.dg_email,
            this.dg_pan,
            this.dg_birthday,
            this.dg_bankDetails,
            this.dg_address,
            this.dg_fileName,
            this.dg_image});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 492);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 256);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // dg_EmpID
            // 
            this.dg_EmpID.HeaderText = "Employee ID";
            this.dg_EmpID.MinimumWidth = 8;
            this.dg_EmpID.Name = "dg_EmpID";
            // 
            // dg_name
            // 
            this.dg_name.HeaderText = "Name";
            this.dg_name.MinimumWidth = 8;
            this.dg_name.Name = "dg_name";
            // 
            // dg_mobile
            // 
            this.dg_mobile.HeaderText = "Mobile";
            this.dg_mobile.MinimumWidth = 8;
            this.dg_mobile.Name = "dg_mobile";
            // 
            // dg_email
            // 
            this.dg_email.HeaderText = "Email";
            this.dg_email.MinimumWidth = 8;
            this.dg_email.Name = "dg_email";
            // 
            // dg_pan
            // 
            this.dg_pan.HeaderText = "PAN No.";
            this.dg_pan.MinimumWidth = 8;
            this.dg_pan.Name = "dg_pan";
            // 
            // dg_birthday
            // 
            this.dg_birthday.HeaderText = "Birthday";
            this.dg_birthday.MinimumWidth = 8;
            this.dg_birthday.Name = "dg_birthday";
            // 
            // dg_bankDetails
            // 
            this.dg_bankDetails.HeaderText = "Bank Details";
            this.dg_bankDetails.MinimumWidth = 8;
            this.dg_bankDetails.Name = "dg_bankDetails";
            // 
            // dg_address
            // 
            this.dg_address.HeaderText = "Address";
            this.dg_address.MinimumWidth = 8;
            this.dg_address.Name = "dg_address";
            // 
            // dg_fileName
            // 
            this.dg_fileName.HeaderText = "File Name";
            this.dg_fileName.MinimumWidth = 8;
            this.dg_fileName.Name = "dg_fileName";
            // 
            // dg_image
            // 
            this.dg_image.HeaderText = "Image";
            this.dg_image.MinimumWidth = 8;
            this.dg_image.Name = "dg_image";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(959, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 30);
            this.txtName.TabIndex = 25;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(957, 163);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(290, 30);
            this.dtpBirthday.TabIndex = 26;
            this.dtpBirthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpBirthday_KeyDown_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEmployeeRegisterr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1295, 744);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtPAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.employeePictureBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEmployeeRegisterr";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registration";
            this.Load += new System.EventHandler(this.frmEmployeeRegisterr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox employeePictureBox;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_pan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_bankDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_image;
    }
}