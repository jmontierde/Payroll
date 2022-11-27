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
    public partial class frmEmployeeSalary : Form
    {
        public frmEmployeeSalary()
        {
            InitializeComponent();
        }

        Connection con = new Connection();
        private void txtEmpId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    txtEmpId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();

                }
            }
        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    txtEmpId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                    txtEmpName.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    dtpJoinDate.Focus();

                }
            }
        }
            
        // To track all employee account 
        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("SELECT Top(10) employeeId, name FROM Employee WHERE employeeId LIKE  '"+txtEmpId.Text+"%' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.DataSource = dt;  
        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            con.dataGet("SELECT Top(10) employeeId, name FROM Employee WHERE name LIKE  '" + txtEmpName.Text + "%' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void frmEmployeeSalary_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEmpId;
            LoadData();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dtpJoinDate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSalary.Focus();
            }
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSalary.Text.Length > 0)
                {
                    btnSave.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                if (IfEmployeeExist(txtEmpId.Text))
                {
                    MessageBox.Show("Record is already exist");
                }
                else
                {
                    con.dataSend(@"INSERT INTO EmployeeSalary(employeeID, joinDate, salary)VALUES ('" + txtEmpId.Text + "', '" + dtpJoinDate.Value.ToString("MM/dd/yyyy") + "','" + txtSalary.Text + "')");
                    MessageBox.Show("Successfully Save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }
        }

        private void ClearData()
        {
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtSalary.Clear();
            dtpJoinDate.Value = DateTime.Now;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void LoadData()
        {
            con.dataGet("SELECT EmployeeSalary. *,Employee.Name FROM Employee INNER JOIN EmployeeSalary ON Employee.employeeId = EmployeeSalary.employeeID");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dg_employeeId"].Value = row["employeeID"].ToString();
                dataGridView1.Rows[n].Cells["dg_employeeName"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dg_joinDate"].Value = Convert.ToDateTime(row["joinDate"].ToString()).ToString();
                dataGridView1.Rows[n].Cells["dg_salary"].Value = row["salary"].ToString();



            }
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtEmpId.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmpId, "Name Required");
            }
            else if (string.IsNullOrEmpty(txtSalary.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSalary, "Username Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private bool IfEmployeeExist(string empId)
        {
            con.dataGet("Select 1 From EmployeeSalary WHERE employeeId = '" + empId + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {

            }
            {
                return false;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpId.Text = dataGridView1.SelectedRows[0].Cells["dg_employeeId"].Value.ToString();
            txtEmpName.Text = dataGridView1.SelectedRows[0].Cells["dg_employeeName"].Value.ToString();
            dtpJoinDate.Text = dataGridView1.SelectedRows[0].Cells["dg_joinDate"].Value.ToString();
            txtSalary.Text = dataGridView1.SelectedRows[0].Cells["dg_salary"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your data?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE EmployeeSalary SET joinDate = '" + dtpJoinDate.Value.ToString("MM/dd/yyyy") + "', salary = '" + txtSalary.Text + "' WHERE employeeId = '" + txtEmpId.Text + "' ");
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your data?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("DELETE from EmployeeSalary WHERE employeeId = '" + txtEmpId.Text + "'");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();

                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
