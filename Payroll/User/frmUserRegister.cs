using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Payroll.User
{
    public partial class frmUserRegister : Form
    {
        public frmUserRegister()
        {
            InitializeComponent();
        }

        private void frmUserRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = employee_name;
            register_update.Enabled = false;
            register_delete.Enabled = false;
            LoadData();
            
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(employee_name.Text.Length > 0)
                {
                    employee_username.Focus();
                }
                else
                {
                    employee_name.Focus();
                }
            }
        }

        // To Clear Data from User Registration form
        private void clearData()
        {
            employee_name.Clear();
            employee_username.Clear();
            employee_password.Clear();
            employee_email.Clear();
            employee_address.Clear();
            employee_position.SelectedIndex = -1;
            employee_birthday.Value = DateTime.Now;
            register_update.Enabled = false;
            register_delete.Enabled = false;
            register_save.Enabled = true;
             
        }       

        // Validation for user to fill-out the registration form
        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(employee_name.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_name, "Name Required");
            }
            else if (string.IsNullOrEmpty(employee_username.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_username, "Username Required");
            }
            else if (string.IsNullOrEmpty(employee_password.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_password, "Password Required");
            }
            else if(employee_password.Text.Length < 4)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_password, "The minimum password is 4 Character");
            }
            else if (string.IsNullOrEmpty(employee_email.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_email, "Email Required");
            }
            else if(employee_position.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_position, "Please select your position");
            }
            else if (string.IsNullOrEmpty(employee_address.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(employee_address, "Email Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        //Hahanapin nito kung may account naba si user
        Connection con = new Connection();
        private bool FindUserAccount(string userName)
        {
           
            con.dataGet("Select 1 From [User] WHERE username = '" + userName +"'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void register_save_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (FindUserAccount(employee_username.Text))
                {
                    MessageBox.Show("Username is already exist");
                }
                else
                {
                    Connection con = new Connection();  
                    con.dataSend("INSERT INTO [User](name, email, username, password, position, birthday, address)VALUES('"+employee_name.Text+"', '"+employee_email.Text+"', '"+employee_username.Text+"', '"+employee_password+"', '"+employee_position.Text+"', '"+employee_birthday.Value.ToString("yyyy/MM/dd") +"', '"+employee_address.Text+"' )");
                    MessageBox.Show("Record has been successfully saved.");
                    clearData();
                    LoadData();
                }
            }
        }
      
        private void LoadData()
        {
            con.dataGet("SELECT * FROM [User]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            { 
              //dataGridView1.Rows[n].Cells["dg_birthday"].Value = String.Format(row["birthday"].ToString(), "yyyy/MM/dd", null);

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dg_serialnumber"].Value = n + 1;
                dataGridView1.Rows[n].Cells["dg_name"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dg_birthday"].Value = String.Format(row["birthday"].ToString(), "yyyy/MM/dd", null);
                dataGridView1.Rows[n].Cells["dg_email"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["dg_username"].Value = row["username"].ToString();
                dataGridView1.Rows[n].Cells["dg_position"].Value = row["position"].ToString();
                dataGridView1.Rows[n].Cells["dg_address"].Value = row["address"].ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            employee_name.Text = dataGridView1.SelectedRows[0].Cells["dg_name"].Value.ToString();
            employee_username.Text = dataGridView1.SelectedRows[0].Cells["dg_username"].Value.ToString();
            employee_email.Text = dataGridView1.SelectedRows[0].Cells["dg_email"].Value.ToString();
            employee_address.Text = dataGridView1.SelectedRows[0].Cells["dg_address"].Value.ToString();
            employee_birthday.Text = dataGridView1.SelectedRows[0].Cells["dg_birthday"].Value.ToString();
            employee_position.Text = dataGridView1.SelectedRows[0].Cells["dg_position"].Value.ToString();
            register_save.Enabled = false;
            register_update.Enabled = true;
            register_delete.Enabled = true;



        }

        private void register_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your data?", "Update", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE [User] SET name ='"+employee_name.Text+"', email ='"+employee_email.Text+"', position ='"+employee_position.Text+"', birthday ='"+employee_birthday.Value.ToString("MM/dd/yyyy")+"', address = '"+employee_address.Text+"' WHERE username ='"+employee_username.Text+"'");
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                register_save.Enabled = true;   
                register_update.Enabled = false;
                register_delete.Enabled = false;
            }
        }

        private void register_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your data?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("DELETE from [User] WHERE username = '"+employee_username.Text+"'");
                MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                register_save.Enabled = true;
                register_update.Enabled = false;
                register_delete.Enabled = false;
            }
        }
    }
}
