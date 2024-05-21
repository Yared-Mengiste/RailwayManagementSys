using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Railway;
namespace JustExample
{

    public partial class LogInPage : Form
    {
        public static string conStr = @"DATA SOURCE = yared:1521/XE;User Id=RAILWAY;Password=1234;";

        public void CallProcedure()
        {
            try
            {
                string connString = "your connection string here";
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand("procedure_name", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("parameter1", OracleDbType.Int32).Value = 123;  // Example parameter
                                                                                           // Add other parameters as required

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataTable GetDataFromView(string viewName, string connString)
        {
            try
            {
                DataTable dt = new DataTable();
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {viewName}";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static OracleDataReader GetData(string viewName, string connString)
        {
            try
            {
                OracleDataReader dr = null;
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {viewName}";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        dr = cmd.ExecuteReader();
                    }
                }
                return dr;
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static int GetRowCount(OracleDataReader rd)
        {
            int RowCount = 0;
            while (rd.Read())
            {
                RowCount++;
            }
            return RowCount;
        }

        public static List<String> SeparateName(String fullName)
        {
            fullName = fullName.Trim();
            List<String> separatedName = new List<string>();
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == ' ')
                {
                    separatedName.Add(fullName.Substring(0, i).ToUpper());
                    separatedName.Add(fullName.Substring(i + 1).Trim().ToUpper());
                }

            }
            return separatedName;
        }

        public static bool CheckSpace(String word)
        {
            String trimmed = word.Trim();

            if (trimmed.Length > 2)
                for (int i = 0; i < trimmed.Length; i++)
                {
                    if (trimmed[i] == ' ')
                    {
                        for (int j = 0; j < trimmed.Substring(i).Trim().Length; j++)
                            if (trimmed.Substring(i).Trim()[j] == ' ')
                            {
                                return false;
                            }
                        return true;
                    }

                }

            return false;
        }
        public OracleDataReader AuthenticateEmployee(string conStr, Employee employee)
        {
            OracleConnection con = new OracleConnection(conStr);
            con.Open();

            OracleCommand cmd = new OracleCommand
            {
                Connection = con,
                CommandText = "SELECT * FROM STAFF WHERE FIRST_NAME = :firstName AND LAST_NAME = :lastName AND PASSWORD = :password"
            };

            cmd.Parameters.Add(new OracleParameter("firstName", employee.FirstName));
            cmd.Parameters.Add(new OracleParameter("lastName", employee.LastName));
            cmd.Parameters.Add(new OracleParameter("password", employee.Password));

            OracleDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        public LogInPage()
        {
            InitializeComponent();
        }
        public LogInPage(Form previousForm)
        {
            InitializeComponent();
            previousForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (CheckSpace(txtUserName.Text))
            {
                if (txtPassword.Text.Length > 3)
                {
                    string tempName = txtUserName.Text;
                    string tempPassword = txtPassword.Text;
                    Employee employee = new Employee(SeparateName(tempName)[0], SeparateName(tempName)[1], tempPassword);
                    OracleDataReader dr = AuthenticateEmployee(conStr, employee);

                    if (dr.HasRows)
                    {
                        dr.Read();
                        employee.ID = Convert.ToInt32(dr["id"]); // Assuming id is an integer
                        employee.Sex = char.Parse(dr["sex"].ToString());
                        employee.DOB = Convert.ToDateTime(dr["dob"]); // Assuming dob is a DateTime
                        employee.Position = dr["position"].ToString();
                        employee.Salary = Convert.ToDecimal(dr["salary"]); // Assuming salary is a decimal
                        employee.Password = dr["password"].ToString();
                        AddMinFirst addMin = new AddMinFirst(employee);
                        addMin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Check Your Name or Password", "Unknown Employee");
                    }
                }
                else MessageBox.Show("Please enter your password Correctly", "Incorrect Password");

            }
            else MessageBox.Show("Please enter your username Correctly 'FirstName LastName'", "Incorrect Format");


        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void LogInPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char? Sex { get; set; }
        public DateTime? DOB { get; set; }
        public string Position { get; set; }
        public decimal? Salary { get; set; }
        public string Password { get; set; }

        // Constructor
        public Employee(int id, string firstName, string lastName, char? sex, DateTime? dob, string position, decimal? salary, string password)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            DOB = dob;
            Position = position;
            Salary = salary;
            Password = password;
        }
        public Employee(string firstName, string lastName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
    }

}
