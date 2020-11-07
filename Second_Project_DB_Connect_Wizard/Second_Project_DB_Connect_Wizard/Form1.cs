using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace First_Project_DB_App_Config
{
    public partial class frmDBConnectionForm : Form
    {
        SqlConnection SqlConn;
        SqlDataReader SqlDr;
        SqlCommand SqlCommand;

        String ConnectionString;

        public frmDBConnectionForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        try
            {
                SqlConn = new SqlConnection(ConnectionString);
                SqlConn.Open();
                SqlCommand = new SqlCommand("SELECT * FROM PersonalDetails", SqlConn);
                SqlDr = SqlCommand.ExecuteReader();

                while (SqlDr.Read())
                {
                    lbIndexNo.Items.Add(SqlDr[0].ToString());
                    lbFirstName.Items.Add(SqlDr[1].ToString());
                    lbLastName.Items.Add(SqlDr[2].ToString());
                    lbAddress.Items.Add(SqlDr[3].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConn.Close();
            }
        }

        private void frmDBConnectionForm_Load(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=CHIRAN-PC;Initial Catalog=FirstDatabaseProject;Integrated Security=True";
        }
    }
}
