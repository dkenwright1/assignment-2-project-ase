using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logon
{
    public partial class edit_admin : Form
    {
        /// <summary>
        /// main method
        /// </summary>
        public edit_admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// method when the add admin button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_admin_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();//opens conection to database
            try
            {
                String user = admin_user.Text.ToString();
                String passwordcreated = admin_pass.Text.ToString();
                String confpassword = confpass.Text.ToString();
                if (passwordcreated == confpassword & user != null & passwordcreated != null & confpassword != null) //if statement to check information validity
                {

                    String query = "INSERT INTO admin ([Username], [password]) VALUES('" + admin_user.Text + "', '" + admin_pass.Text + "')";//query that adds info to the admin table so a new admin can be created
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery(); //executes query
                    MessageBox.Show("The account has been added to the admin database");
                    this.Close(); //closes form

                }
                else
                {
                    MessageBox.Show("Passwords must match and no fields can be empty");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
        /// <summary>
        /// method when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_admin_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open(); //opens connection
            string query = "Select [ID],[username] from admin ORDER BY [ID]"; //query selecting id and username from admin
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable admin = new DataTable();
            myDataAdapter.Fill(admin); //fills the datagrid with query results
            admin_data.DataSource = admin; //confirms data source
        }
    }
}
