using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Employee
{
    public partial class frmEmployeeRegisterr : Form
    {
        public frmEmployeeRegisterr()
        {
            InitializeComponent();
        }
        string fileName;

        private void button1_Click(object sender, EventArgs e) // BtnAdd
        {
            // To add a employee picture    
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    lblFileName.Text = fileName;
                    employeePictureBox.Image = Image.FromFile(fileName);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // BtnRemove
        {
            employeePictureBox.Image = null;
        }

        private void frmEmployeeRegisterr_Load(object sender, EventArgs e) // Form for Employee Register
        {
            this.ActiveControl = txtName;
            LoadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Event Handler 
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMobile.Text.Length > 0)
                {
                    txtEmail.Focus();
                }
                else
                {
                    txtMobile.Focus();
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmail.Text.Length > 0)
                {
                    txtPAN.Focus();
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        }

        private void txtPAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPAN.Text.Length > 0)
                {
                    dtpBirthday.Focus();
                }
                else
                {
                    txtPAN.Focus();
                }
            }
        }
        private void dtpBirthday_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBank.Focus();
            }
        }


        private void txtBank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBank.Text.Length > 0)
                {
                    txtAddress.Focus();
                }
                else
                {
                    txtBank.Focus();
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtName.Text.Length > 0)
                {
                    txtMobile.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtName, "Name Required");
            }
            else if (string.IsNullOrEmpty(txtMobile.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMobile, "Mobile Number Required");
            }
            else if (string.IsNullOrEmpty(txtPAN.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPAN, "PAN Number Required");
            }
            else if (txtEmail.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Email Required");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAddress, "Address Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        Connection con = new Connection(); // Connection to database

        private bool IfEmployeeExist(string name, string mobile, string pan)
        {
            con.dataGet("Select 1 From Employee WHERE name = '" + name + "' AND mobile ='" + mobile + "' AND pan = '" + pan + "' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        byte[] ConvertImageToBinary(Image img) // Converting the image into binary form
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray(); 
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (IfEmployeeExist(txtName.Text,txtMobile.Text,txtPAN.Text))
                {
                    MessageBox.Show("Employee is already exist");
                }
                else
                {
                    con.dataSend(@"INSERT INTO Employee(name, mobile, email, pan, birthday, bankDetails, address, fileName, imageData)
                    VALUES('" + txtName.Text + "', '" + txtMobile.Text + "', '" + txtEmail.Text + "', '" + txtPAN.Text + "', '" + dtpBirthday.Value.ToString("MM/dd/yyyy") + "', '" + txtBank.Text + "', '" + txtAddress.Text + "', '" + fileName + "', '" + ConvertImageToBinary(employeePictureBox.Image) + "')");
                    MessageBox.Show("Successfully Save.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadData();
                }
            }
        }

        private void ClearData()
        {
            txtEmpId.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtPAN.Clear();
            dtpBirthday.Value = DateTime.Now;
            txtBank.Clear();
            txtAddress.Clear();
            employeePictureBox.Image = null;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;      

        }

        private void LoadData()
        {
            con.dataGet("SELECT * FROM Employee");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dg_EmpID"].Value = row["employeeId"].ToString(); 
                dataGridView1.Rows[n].Cells["dg_name"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dg_birthday"].Value = Convert.ToDateTime(row["birthday"].ToString()).ToString("dd/MM/yyyy");
                dataGridView1.Rows[n].Cells["dg_email"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["dg_mobile"].Value = row["mobile"].ToString();
                dataGridView1.Rows[n].Cells["dg_pan"].Value = row["pan"].ToString();
                dataGridView1.Rows[n].Cells["dg_bankDetails"].Value = row["bankDetails"].ToString();
                dataGridView1.Rows[n].Cells["dg_address"].Value = row["address"].ToString();
                dataGridView1.Rows[n].Cells["dg_fileName"].Value = row["fileName"].ToString();
                dataGridView1.Rows[n].Cells["dg_image"].Value = row["imageData"].ToString();

            }
        }

        // Para ma open lahat ng data sa textbox
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpId.Text = dataGridView1.SelectedRows[0    ].Cells["dg_EmpID"].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells["dg_name"].Value.ToString();
            txtMobile.Text = dataGridView1.SelectedRows[0].Cells["dg_mobile"].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells["dg_email"].Value.ToString();
            txtPAN.Text = dataGridView1.SelectedRows[0].Cells["dg_pan"].Value.ToString();
            dtpBirthday.Text = dataGridView1.SelectedRows[0].Cells["dg_birthday"].Value.ToString();
            txtBank.Text = dataGridView1.SelectedRows[0].Cells["dg_bankDetails"].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells["dg_address"].Value.ToString();
            lblFileName.Text = dataGridView1.SelectedRows[0].Cells["dg_filename"].Value.ToString();
            employeePictureBox.Image = Image.FromFile(dataGridView1.SelectedRows[0].Cells["dg_filename"].Value.ToString()); // May kailangan ayusin
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your data?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE Employee SET email = '" + txtEmail.Text + "', bankDetails = '" + txtBank.Text + "', address = '" + txtAddress.Text + "', fileName '" + fileName + "', imageData = '" + ConvertImageToBinary(employeePictureBox.Image) + "' WHERE employeeId = '" + txtEmpId.Text + "' ");
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
                con.dataSend("DELETE from Employee WHERE employeeId = '" + txtEmpId.Text + "'");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
