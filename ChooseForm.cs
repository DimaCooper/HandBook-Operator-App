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
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
            this.btnExit.Click += new EventHandler(btnExit_Click);
            this.btnAddOperator.Click += new EventHandler(btnAddOperator_Click);
            this.btnAddRec.Click += new EventHandler(btnAddRec_Click);

        }

        private void btnAddOperator_Click(object sender, EventArgs e)
        {
            
                AddOperatorForm objOptions = new AddOperatorForm();
                this.Hide();
                objOptions.Show();
            Close();

        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            
                AddRecForm objOptions = new AddRecForm();
                this.Hide();
                objOptions.Show();
            Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}