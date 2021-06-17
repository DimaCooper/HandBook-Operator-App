using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandBookApp
{
    public partial class AddRecForm : Form
    {

        SqlConnection sqlConnection;
        public AddRecForm()
        {
            InitializeComponent();

            this.btnAdd.Click += new EventHandler(btnAdd_Click);
            this.btnExit.Click += new EventHandler(btnExit_Click);
            this.btnClear.Click += new EventHandler(btnClear_Click);
            this.btnBack.Click += new EventHandler(btnBack_Click);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close connection and go back
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            ChooseForm objOptions = new ChooseForm();
            this.Hide();
            objOptions.Show();
            Close();


        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=localhost;Initial Catalog=Handbook;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            {
                try
                {

                    await sqlConnection.OpenAsync();
                    SqlCommand command = new SqlCommand("AddRec_Procedure @firstname, @secondname, @surname, @dateofbirth, @phonenumber, @address", sqlConnection);
                    {
                        if (txtFirstName.Text != ""  && txtSurname.Text != "" && txtDateofBirth.Text != "" && txtPhoneNumber.Text != "" && rtxtAddress.Text != "")
                        {
                            // Insert new row to db
                            command.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = Convert.ToString(txtFirstName.Text);
                            command.Parameters.AddWithValue("@secondname", SqlDbType.NVarChar).Value = Convert.ToString(txtSecondName.Text);
                            command.Parameters.AddWithValue("@surname", SqlDbType.NVarChar).Value = Convert.ToString(txtSurname.Text);
                            command.Parameters.AddWithValue("@dateofbirth", SqlDbType.Char).Value = Convert.ToString(txtDateofBirth.Text);
                            command.Parameters.AddWithValue("@phonenumber", SqlDbType.NVarChar).Value = Convert.ToString(txtPhoneNumber.Text);
                            command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = Convert.ToString(rtxtAddress.Text);
                        }
                        else
                        {
                            MessageBox.Show("There are some empty fields!");
                        }

                        int rowsAdded = command.ExecuteNonQuery();
                        if (rowsAdded > 0)

                            MessageBox.Show("Success");

                        else
                            // Well this should never really happen
                            MessageBox.Show("No row inserted");
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Clear all textboxes
                    txtFirstName.Clear();
                    txtSecondName.Clear();
                    txtSurname.Clear();
                    txtDateofBirth.Clear();
                    txtPhoneNumber.Clear();
                    rtxtAddress.Clear();
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtSurname.Clear();
            txtDateofBirth.Clear();
            txtPhoneNumber.Clear();
            rtxtAddress.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            Application.Exit();
        }



        private void AddRecForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
