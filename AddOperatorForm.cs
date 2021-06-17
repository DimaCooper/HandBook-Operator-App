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
    public partial class AddOperatorForm : Form
    {
        SqlConnection sqlConnection;
        
        public AddOperatorForm()
        {
            InitializeComponent();
            
            this.btnAddOp.Click += new EventHandler(btnAddOp_Click);
            this.btnExit.Click += new EventHandler(btnExit_Click);
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
            this.btnBack.Click += new EventHandler(btnBack_Click);
            this.btnOpSearch.Click += new EventHandler(btnOpSearch_Click);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
           
            ChooseForm objOptions = new ChooseForm();
            this.Hide();
            objOptions.Show();
            Close();


        }
        private async void btnOpSearch_Click(object sender, EventArgs e)
        {
            //Search operators and show them in listbox
            listboxOpSearch.Font = new Font("Bradley Hand ITC", 14);
            listboxOpSearch.Items.Clear();

            string connectionString = @"Data Source=localhost;Initial Catalog=Database;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SearchOp_Procedure @username", sqlConnection);

            try
            {
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtDeleteUsername.Text;
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    listboxOpSearch.Items.Add(Convert.ToString(sqlReader["Username"]));
                }

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            
        }

        private async void btnAddOp_Click(object sender, EventArgs e)
        {
            //Add new operator to DB
            string connectionString = @"Data Source=localhost;Initial Catalog=Database;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            {
                try
                {

                    await sqlConnection.OpenAsync();
                    SqlCommand command = new SqlCommand("AddOp_Procedure @username, @password", sqlConnection);
                    {
                        if (txtUser.Text != null && txtPass.Text != null)
                        {
                        command.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = txtUser.Text;
                        command.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = txtPass.Text;
                        }
                        else
                        {
                            MessageBox.Show("There are some empty fields!");
                        }
                            
                        int rowsAdded = command.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Operator added!" );
                        else
                            
                            MessageBox.Show("No row inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete operator from DB
            string connectionString = @"Data Source=localhost;Initial Catalog=Database;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            {
                try
                {

                    await sqlConnection.OpenAsync();
                    SqlCommand command = new SqlCommand("DelOp_Procedure @username", sqlConnection);
                    {
                        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtDeleteUsername.Text;
                        if (txtDeleteUsername.Text != "" )
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Operator deleted!");

                        }
                        else
                        {
                            MessageBox.Show("User not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {

            AddOperatorForm objOptions = new AddOperatorForm();
            this.Hide();
            objOptions.Show();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }
    }
}
