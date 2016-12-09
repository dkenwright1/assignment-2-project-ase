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
        public edit_admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_admin_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            try
            {
                String user = admin_user.Text.ToString();
                String passwordcreated = admin_pass.Text.ToString();
                String confpassword = confpass.Text.ToString();
                if (passwordcreated == confpassword & user != null & passwordcreated != null & confpassword != null)
                {

                    String query = "INSERT INTO users ([Username], [password]) VALUES('" + admin_user.Text + "', '" + admin_pass.Text + "')";
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The account has been added to the admin database");
                    this.Close();

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

        private void edit_admin_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            string query = "Select [ID],[username] from admin ORDER BY [ID]";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable admin = new DataTable();
            myDataAdapter.Fill(admin);
            admin_data.DataSource = admin;
        }
    }
}
