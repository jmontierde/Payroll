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

        Connection con = new Connection(); // Connection from database

        private bool IfEmployeeExist(string name, string mobile, string pan)
        {
            con.dataGet("Select 1 From [Employee] WHERE Name = '" + name + "' AND Mobile ='"+mobile+"' AND PANNo = '"+pan+"' ");
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
                    MessageBox.Show("The employee is already exist");
                }
                else
                {
                    Connection con = new Connection();
                    con.dataSend(@"INSERT INTO [Employee] (Name, Mobile, Email, PANNo, Birthday, BankDetails, Address, FileName, ImageData)
                    VALUES ('" + txtName.Text + "', '" + txtMobile.Text + "', '" + txtEmail.Text + "', '" + txtPAN.Text + "', '" + dtpBirthday.Value.ToString("MM/dd/yyyy") + "', '" + txtBank.Text + "','" + txtAddress.Text + "', '" + fileName + "', '" + ConvertImageToBinary(employeePictureBox.Image) + "')");
                    MessageBox.Show("Successfully Save.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearData();
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

        }
    }
}
