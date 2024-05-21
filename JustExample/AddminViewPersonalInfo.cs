using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustExample;
using Oracle.ManagedDataAccess.Client;
using Railway;

namespace RailWay
{
    public partial class AddminViewPersonalInfo : Form
    {

        Employee employee;
        public void CallUpdateStaffProcedure(string firstName, string lastName, string gender, string password)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(LogInPage.conStr))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("update_staff_info", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = employee.ID;
                        cmd.Parameters.Add("p_first_name", OracleDbType.Varchar2).Value = firstName;
                        cmd.Parameters.Add("p_last_name", OracleDbType.Varchar2).Value = lastName;
                        cmd.Parameters.Add("p_sex", OracleDbType.Char).Value = gender;
                        cmd.Parameters.Add("p_dob", OracleDbType.Date).Value = employee.DOB;
                        cmd.Parameters.Add("p_position", OracleDbType.Varchar2).Value = employee.Position;
                        cmd.Parameters.Add("p_salary", OracleDbType.Decimal).Value = employee.Salary;
                        cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public AddminViewPersonalInfo(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            lblId.Text = "" + employee.ID;
            txtUserName.Text = employee.FirstName + " " + employee.LastName;
            txtDOB.Text = String.Format($"{employee.DOB:d}");
            txtGender.Text = employee.Sex + "";
            lblPosition.Text = employee.Position;
            lblSalary.Text = employee.Salary + "";
            txtPassword.Text = employee.Password;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You want to update profile", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (LogInPage.CheckSpace(txtUserName.Text))
                {
                    if (txtPassword.Text.Length > 3)
                    {
                        if (txtGender.Text.Length == 1)
                        {
                            employee.FirstName = LogInPage.SeparateName(txtUserName.Text)[0].ToUpper();
                            employee.LastName = LogInPage.SeparateName(txtUserName.Text)[1].ToUpper();
                            employee.Sex = txtGender.Text.ToUpper()[0];
                            employee.Password = txtPassword.Text;
                            CallUpdateStaffProcedure(employee.FirstName, employee.LastName, txtGender.Text, txtPassword.Text);
                            MessageBox.Show("Update Successful", "Successful");
                            txtUserName.Text = employee.FirstName + " " + employee.LastName;
                        }
                        else MessageBox.Show("Input Gender Correcetly", "error");
                    }
                    else MessageBox.Show("Password > 3", "error");
                }
                else MessageBox.Show("Write Full Name Correctly", "error");
            }
        }

        private void AddminViewPersonalInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddMinFirst addMinFirst = new AddMinFirst(employee);
            addMinFirst.Show();
        }
    }
}
