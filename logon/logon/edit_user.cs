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
    public partial class edit_user : Form
    {
        public edit_user()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void edit_user_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            string query = "Select * from users ORDER BY [ID]";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable users = new DataTable();
            myDataAdapter.Fill(users);
            userdata.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow item in this.userdata.SelectedRows)
                {
                    System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                    connection.Open();
                    string user = userdata.SelectedRows[0].Cells[1].Value.ToString();
                    String query2 = "DELETE FROM users WHERE [username]='" + user + "'";
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query2, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("deleted");
                    userdata.Rows.RemoveAt(item.Index);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to " + ex.Message);
            }
        }

        private void update_user_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.userdata.SelectedRows)
                {
                    System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                    connection.Open();
                    string user = userdata.SelectedRows[0].Cells[1].Value.ToString();
                    String query = "UPDATE users SET [username] = '" + update_name.Text + "', [password] = '" + update_password.Text + "' WHERE [username]='" + user + "'";
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("updated");
                    this.Refresh();
                    //userdata.Rows.Insert(item.Index);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
    }
}

