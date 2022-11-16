using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.User
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        // Event Handler

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtUsername.Text.Length > 0)
                {
                    txtOldPassword.Focus();
                }
                else
                {
                    txtUsername.Focus();
                }
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOldPassword.Text.Length > 0)
                {
                    txtNewPassword.Focus();
                }
                else
                {
                    txtOldPassword.Focus();
                }
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPassword.Text.Length > 0)
                {
                    txtConfirmPassword.Focus();
                }
                else
                {
                    txtNewPassword.Focus();
                }
            }
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewPassword.Text.Length > 0)
                {
                    btnChange.Focus();
                }
                else
                {
                    txtConfirmPassword.Focus();
                }
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Change Passworrd
        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to change your Passworrd?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Connection con = new Connection();
                con.dataGet("SELECT 1 FROM Users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtOldPassword.Text + "' ");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if(txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        if(txtNewPassword.Text.Length > 3)
                        {
                            con.dataSend("UPDATE Users SET password = '"+txtNewPassword.Text+"' WHERE username = '"+txtUsername.Text+"' AND password = '"+txtOldPassword.Text+"' ");
                            MessageBox.Show("Password successfully changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Password length must be greater than 8 characters.
                            errorProvider1.SetError(txtNewPassword, "Please enter minimum 4 character");
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(txtNewPassword, "Password Mismatched");
                        errorProvider1.SetError(txtConfirmPassword, "Password Mismatched");

                    }
                }
                else
                {
                    errorProvider1.SetError(txtUsername, "Please Check Username and Password");
                    errorProvider1.SetError(txtOldPassword, "Please Check Username and Password");

                }
            }
        }
    }
}
