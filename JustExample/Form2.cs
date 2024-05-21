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
using RailWay;

namespace Railway
{
    public partial class AddMinFirst : Form
    {
        Employee employee;
        public AddMinFirst(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            lblUserName.Text = $"Welcome {employee.FirstName} {employee.LastName}";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", employee.FirstName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogInPage logInPage = new LogInPage();
                this.Hide();
                logInPage.Show();
            }
        }

        private void btnViewPersonalInfo_Click(object sender, EventArgs e)
        {
            AddminViewPersonalInfo view = new AddminViewPersonalInfo(employee);
            view.Show();
            this.Hide();
        }

        private void AddMinFirst_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddScheduleOpt_Click(object sender, EventArgs e)
        {
            AddorRemoveSchedule addorRemoveSchedule = new AddorRemoveSchedule(employee);
            addorRemoveSchedule.Show();
            this.Hide();
        }
    }
}
