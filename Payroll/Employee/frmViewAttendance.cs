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
    public partial class frmViewAttendance : Form
    {
        public frmViewAttendance()
        {
            InitializeComponent();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
            }
            if (cmbSearch.SelectedIndex != 0)
            {
                txtSearch.Visible = true;
                txtSearch.Clear();
            }
            
        }


        // Dynamically show the datagrid
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
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dgviewcolumn1, this.dgviewcolumn2 });
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
        // Position of datagrid
        void Search(int LX, int LY, int DW, int DH, string ColName, String ColSize)
        {
            this.dgview.Location = new System.Drawing.Point(LX, LY);
            this.dgview.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = ColSize.Split(',');
            // Size
            for (int i = 0; i < ClSize.Length; i++)
            {
                if (int.Parse(ClSize[i]) != 0)
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
            for (int i = 0; i < ClName.Length; i++)
            {
                this.dgview.Columns[i].HeaderText = ClName[i];
                this.dgview.Columns[i].Visible = true;

            }
        }


        bool change = true;
        private void employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txtSearch.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                this.dgview.Visible = false;
                cmbYear.Focus();
                change = true;
            }
        }

        private void frmViewAttendance_Load(object sender, EventArgs e)
        {
            Search();
            txtSearch.Visible = false;
            cmbSearch.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                if(cmbSearch.SelectedIndex == 1)
                {
                    this.dgview.Visible = true;
                    dgview.BringToFront();
                    Search(120, 90, 400, 200, "Employee ID, Employee Name", "100,0");
                    this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.employee_MouseDoubleClick);
                    Connection con = new Connection();
                    con.dataGet("SELECT Top(10) employeeId, name  FROM Employee WHERE employeeId LIKE '" + txtSearch.Text + "%' ");
                    DataTable dt = new DataTable();
                    con.sda.Fill(dt);
                    dgview.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        int n = dgview.Rows.Add();
                        dgview.Rows[n].Cells[0].Value = row["employeeId"].ToString();
                        dgview.Rows[n].Cells[1].Value = row["name"].ToString();
                    }
                }
            }
        }

        Connection con = new Connection();
        void LoadData(string condition)
        {
            con.dataGet("SELECT EmployeeAttendance. *, Employee.name FROM Employee INNER JOIN EmployeeAttendance ON Employee.employeeId = EmployeeAttendance.employeeId "+condition+"");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dg_employeeId"].Value = row["employeeId"].ToString();
                dataGridView1.Rows[n].Cells["dg_employeeName"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["dg_year"].Value = row["year"].ToString();
                dataGridView1.Rows[n].Cells["dg_month"].Value = row["month"].ToString();
                dataGridView1.Rows[n].Cells["dg_totalDays"].Value = row["totalDays"].ToString();
                dataGridView1.Rows[n].Cells["dg_workingDays"].Value = row["workingDays"].ToString();
                dataGridView1.Rows[n].Cells["dg_presentDays"].Value = row["presentDays"].ToString();
                dataGridView1.Rows[n].Cells["dg_absentDays"].Value = row["absentDays"].ToString();
                dataGridView1.Rows[n].Cells["dg_lopDays"].Value = row["lopDays"].ToString();

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(dgview.Rows.Count > 0)
                {
                    txtSearch.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    dgview.Visible = false;
                    cmbYear.Focus();
                }
                else
                {
                    this.dgview.Visible = false;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0)
            {
                LoadData("WHERE EmployeeAttendance.year = '" + cmbYears.Text + "' AND EmployeeAttendance.month = '" + cmbMonths.Text + "' ");
            }
            if (cmbSearch.SelectedIndex == 1)
            {
                LoadData("WHERE EmployeeAttendance.employeeId = '" + txtSearch.Text + "' AND EmployeeAttendance.year = '" + cmbYears.Text + "' AND EmployeeAttendance.month = '" + cmbMonths.Text + "' ");
            }
        }
    }
}
