using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Employee
{
    public partial class frmEmployeeAttendance : Form
    {
        public frmEmployeeAttendance()
        {
            InitializeComponent();
        }

        private void frmEmployeeAttendance_Load(object sender, EventArgs e)
        {
            Search();
            this.ActiveControl = txtEmployeeId;
           
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void txtEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtTotalDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtWorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void frmEmployeeAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // Fetch the data from table
        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcolumn1;
        private DataGridViewTextBoxColumn dgviewcolumn2;

        void Search()
        {
            // Instantiate the GridView
            dgview = new DataGridView();
            dgviewcolumn1 = new DataGridViewTextBoxColumn();
            dgviewcolumn2 = new DataGridViewTextBoxColumn();

            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dgviewcolumn1, this.dgviewcolumn2});
            this.dgview.Name = "dgview";
            dgview.Visible = false;
            this.dgviewcolumn1.Visible = false;
            this.dgviewcolumn2.Visible = false;
            this.dgview.AllowUserToAddRows = false;
            this.dgview.RowHeadersVisible = false;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(dgview);
            this.dgview.ReadOnly = true;
            dgview.BringToFront();

        }

        // Two Column
        void Search(int LX, int LY, int DW, int DH, string ColName, String ColSize)
        {
            this.dgview.Location = new System.Drawing.Point(LX, LY);
            this.dgview.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            // Size
            for (int i = 0; i < ClSize.Length; i++)
            {
                if(int.Parse(ClSize[i]) != 0)
                {
                    dgview.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else
                {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            // Name
            string[] ClName = ColName.Split(',');
            for (int i= 0; i < ClName.Length; i++)
            {
                this.dgview.Columns[i].HeaderText = ClName[i];
                this.dgview.Columns[i].Visible = true;

            }
        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {
            if(txtEmployeeId.Text.Length > 0)
            {
                this.dgview.Visible = true;
                dgview.BringToFront();
                Search(90, 70, 400, 300, "Employee ID, Employee Name", "100,0");
                this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);
                Connection con = new Connection();
                con.dataGet("SELECT Top(10) employeeId, name  FROM Employee WHERE employeeId LIKE '"+txtEmployeeId.Text+"%' ");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dgview.Rows.Clear();
                foreach(DataRow row in dt.Rows)
                {
                    int n = dgview.Rows.Add();
                    dgview.Rows[n].Cells[0].Value = row["employeeId"].ToString();
                    dgview.Rows[n].Cells[1].Value = row["name"].ToString();
                }
            }
            else
            {
                dgview.Visible = false;
            }
        }
        //

        bool change = true;
        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txtEmployeeId.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                txtEmployeeName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                this.dgview.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }

        private void txtEmployeeId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgview.Rows.Count > 0)
                {  
                    txtEmployeeId.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmployeeName.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgview.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    this.dgview.Visible = false;
                }
            }
        }

        private void cmbYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbYear.SelectedIndex != -1)
                {
                    cmbMonth.Focus();
                }
                else
                {
                    cmbYear.Focus();

                }
                 
            }
        }

        Connection con = new Connection();
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMonth.SelectedIndex != 1)
            {
                con.dataGet("SELECT * FROM EmployeeAttendance WHERE employeeId = '"+txtEmployeeId.Text+"' AND year = '"+cmbYear.Text+"' AND month = '"+cmbMonth.Text+"' ");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    txtTotalDays.Text = dt.Rows[0]["totalDays"].ToString();
                    txtWorkingDays.Text = dt.Rows[0]["workingDays"].ToString();
                    txtPresentDays.Text = dt.Rows[0]["presentDays"].ToString();
                    txtAbsentDays.Text = dt.Rows[0]["absentDays"].ToString();
                    txtLOPDays.Text = dt.Rows[0]["lopDays"].ToString();
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                txtTotalDays.Text = "";
                txtWorkingDays.Text = "";
                txtPresentDays.Text = "";
                txtAbsentDays.Text = "";
                txtLOPDays.Text = "";
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtEmployeeId.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmployeeId, "Employee ID is Required");
            }
            else if (string.IsNullOrEmpty(cmbYear.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbYear, "Select Year");
            }
            else if (string.IsNullOrEmpty(cmbMonth.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbMonth, "Select Month");
            }
            else if (string.IsNullOrEmpty(txtTotalDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtTotalDays, "Total Days is Required");
            }
            else if (string.IsNullOrEmpty(txtWorkingDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtWorkingDays, "Working Days is Required");
            }
            else if (string.IsNullOrEmpty(txtPresentDays.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPresentDays, "Present Days is Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //if (IfEmployeeExist(txtName.Text, txtMobile.Text, txtPAN.Text))
                //{
                //    MessageBox.Show("Employee is already exist");
                //}
                //else
                //{
                    con.dataSend(@"INSERT INTO EmployeeAttendance(employeeId, year, month, totalDays, workingDays, presentDays, absentDays, lopDays)
                    VALUES ('" + txtEmployeeId.Text + "', '" + cmbYear.Text + "', '" + cmbMonth.Text + "', '" + txtTotalDays.Text + "', '" + txtWorkingDays.Text + "', '" + txtPresentDays.Text + "','" + txtAbsentDays.Text + "','" + txtLOPDays.Text + "')");
                    MessageBox.Show("Successfully Save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();    
                    //LoadData();
                //}
            }
        }
        private void ClearData()
        {
            txtEmployeeId.Clear();
            txtEmployeeName.Clear();
            cmbYear.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1; 
            txtTotalDays.Clear();
            txtWorkingDays.Clear();
            txtPresentDays.Clear();
            txtAbsentDays.Clear();
            txtLOPDays.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your data?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE EmployeeAttendance SET presentDays = '"+txtPresentDays.Text+"', absentDays = '"+txtAbsentDays.Text+"', totalDays = '"+txtTotalDays.Text+"', workingDays = '"+txtWorkingDays.Text+"', lopDays = '"+txtLOPDays.Text+"' WHERE employeeId = '"+txtEmployeeId.Text+"' AND year = '"+cmbYear.Text+"' AND month = '"+cmbMonth.Text+"' ");
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your data?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("DELETE FROM EmployeeAttendance WHERE employeeId = '" + txtEmployeeId.Text + "' AND year = '" + cmbYear.Text + "' AND month = '" + cmbMonth.Text + "' ");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //Employee.frmViewAttendance frmViewAttendance = new Employee.frmViewAttendance();
            //frmViewAttendance.MdiParent = this;
            //frmViewAttendance.StartPosition = FormStartPosition.CenterScreen;
            //frmViewAttendance.Show();
            Employee.frmViewAttendance frmViewAttendance = new Employee.frmViewAttendance();
            frmViewAttendance.MdiParent = this.MdiParent;
            frmViewAttendance.Show();
        }
    }
}
