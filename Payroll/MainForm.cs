using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void userRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.frmUserRegister frmRegister = new User.frmUserRegister();
            frmRegister.MdiParent = this;
            frmRegister.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.Show();
        }

        bool close = true;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;    
                }
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // When you clicked the Change Password it will appear the ChangePassword Formn
            User.frmChangePassword frmChange = new User.frmChangePassword();
            frmChange.MdiParent = this;
            frmChange.StartPosition = FormStartPosition.CenterScreen;
            frmChange.Show();
        }

      

        private void employeeRegisterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employee.frmEmployeeRegisterr frmEmployee = new Employee.frmEmployeeRegisterr();
            frmEmployee.MdiParent = this;
            frmEmployee.StartPosition = FormStartPosition.CenterScreen;
            frmEmployee.Show();
        }
    }
}
