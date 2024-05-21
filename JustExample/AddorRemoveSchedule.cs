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
using Railway;

namespace RailWay
{
    public partial class AddorRemoveSchedule : Form
    {
        Employee employee;
        public AddorRemoveSchedule(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            MinuteGetter.Maximum = 60;
            MinuteGetter.Minimum = 0;
            HourGetter.Maximum = 23;
            HourGetter.Minimum = 0;
            DateTime now = DateTime.Now;
            lblTodayDate.Text = now.ToString("f");
            ScheduleShower.DataSource = LogInPage.GetDataFromView("Schedule_info_view ORDER BY schedule_id DESC", LogInPage.conStr);
            DataTable dt = LogInPage.GetDataFromView("route", LogInPage.conStr);
            foreach (DataRow row in dt.Rows)
            {
                comboBox2.Items.Add($"{row[0]}          {row[1]}          {row[2]}");
            }
            stationViewer.DataSource = LogInPage.GetDataFromView("station", LogInPage.conStr);
            comboBox2.SelectedIndex = 0;

        }

        private void AddorRemoveSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddMinFirst addMinFirst = new AddMinFirst(employee);
            addMinFirst.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ScheduleShower_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DO sth here
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = pickDate.Value;
            string dte = date.ToString("yyyy-MM-dd"); // Format date as "YYYY-MM-DD"
            DataTable dt = LogInPage.GetDataFromView($"train t join schedule on t.id = schedule.train_id where trunc(start_date) != TO_DATE('{dte}', 'YYYY-MM-DD')", LogInPage.conStr);
            comboBox1.Enabled = true;
            comboBox1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add($"{row[0]}          {row[1]}          {row[2]}");
            }
            comboBox1.SelectedIndex = 0;
            inpDate.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
