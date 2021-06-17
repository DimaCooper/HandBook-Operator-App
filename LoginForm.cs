using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandBookApp
{
    public partial class LoginForm : Form
    {
        
        SqlConnection sqlConnection;
        public LoginForm()
        {
            InitializeComponent();
            this.btnExit.Click += new EventHandler(btnExit_Click);
            this.btnLogin.Click += new EventHandler(btnLogin_Click);

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //Connecting to DB and compare username and password from textbox to log in
            string connectionString = @"Data Source=localhost;Initial Catalog=Database;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            string query = "SELECT * FROM OperatorsDB WHERE Username = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPasswd.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connectionString);

            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                // switch window is success
                ChooseForm objOptions = new ChooseForm();
                this.Hide();
                objOptions.Show();
            }
            else
            {
                MessageBox.Show("Check your Login and Password");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close SQL connection and close app
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }
    }
}
