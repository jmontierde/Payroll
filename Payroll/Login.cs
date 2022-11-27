using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Payroll
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.dataGet("Select * from [User] WHERE username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MainForm frm = new MainForm();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.frmChangePassword frmChange = new User.frmChangePassword();
            frmChange.StartPosition = FormStartPosition.CenterScreen;
            frmChange.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
