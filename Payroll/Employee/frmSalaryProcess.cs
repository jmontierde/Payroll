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
    public partial class frmSalaryProcess : Form
    {
        public frmSalaryProcess()
        {
            InitializeComponent();
        }

        float salary = 0;
        float workingDays = 0;
        float presentDays = 0;
        float lopDays = 0;
        float perDay = 0;
        float netSalary = 0;
        Connection con = new Connection();

        private void btnStart_Click(object sender, EventArgs e)
        {
            con.dataGet("SELECT * FROM employeeAttendance WHERE year = '" + cmbYear.Text + "' AND month = '" + cmbMonth.Text + "' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    con.dataGet(@"SELECT EmployeeSalary.salary, EmployeeAttendance.workingDays, EmployeeAttendance.presentDays, EmployeeAttendance.lopDays FROM employeeAttendance EmployeeAttendance INNER JOIN employeeSalary EmployeeSalary ON EmployeeAttendance.employeeId = EmployeeSalary.employeeId
                    WHERE EmployeeAttendance.year = '" + cmbYear.Text + "' AND EmployeeAttendance.month = '" + cmbMonth.Text + "' AND EmployeeAttendance.employeeId = '" + dt.Rows[0]["employeeId"].ToString() + "' ");
                    DataTable dt1 = new DataTable();
                    con.sda.Fill(dt1);
                    salary = float.Parse(dt1.Rows[0]["salary"].ToString());
                    workingDays = float.Parse(dt1.Rows[0]["workingDays"].ToString());
                    presentDays = float.Parse(dt1.Rows[0]["presentDays"].ToString());
                    lopDays = float.Parse(dt1.Rows[0]["lopDays"].ToString());
                    // Computation of Salary
                    perDay = (salary / 12) / workingDays;
                    netSalary = (perDay * presentDays) - (perDay * lopDays);
                    con.dataSend("INSERT INTO SalaryProcess(employeeId, year, month, netSalary) VALUES('" + dt.Rows[0]["employeeId"].ToString() + "', '" + cmbYear.Text + "', '" + cmbMonth.Text + "', '" + netSalary + "')");
                    MessageBox.Show("Salary Processed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        void LoadData()
        {
            con.dataGet("SELECT SalaryProcess. *,Employee.Name FROM Employee INNER JOIN SalaryProcess ON Employee.employeeId = SalaryProcess.employeeID");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            if(dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["dg_employeeId"].Value = row["employeeID"].ToString();
                    dataGridView1.Rows[n].Cells["dg_name"].Value = row["name"].ToString();
                    dataGridView1.Rows[n].Cells["dg_month"].Value = row["month"].ToString();
                    dataGridView1.Rows[n].Cells["dg_year"].Value = row["year"].ToString();
                    dataGridView1.Rows[n].Cells["dg_salary"].Value = row["netSalary"].ToString();
                }
            }
           
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.dataGet("SELECT SalaryProcess. *,Employee.Name FROM Employee INNER JOIN SalaryProcess ON Employee.employeeId = SalaryProcess.employeeID WHERE SalaryProcess.Year = '"+cmbYear.Text+"' AND SalaryProcess.Month = '"+cmbMonth.Text+"' ");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["dg_employeeId"].Value = row["employeeID"].ToString();
                    dataGridView1.Rows[n].Cells["dg_name"].Value = row["name"].ToString();
                    dataGridView1.Rows[n].Cells["dg_month"].Value = row["month"].ToString();
                    dataGridView1.Rows[n].Cells["dg_year"].Value = row["year"].ToString();
                    dataGridView1.Rows[n].Cells["dg_salary"].Value = row["netSalary"].ToString();
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }
    }
}
