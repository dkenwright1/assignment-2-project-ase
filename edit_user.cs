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
        /// <summary>
        /// main method
        /// </summary>
        public edit_user()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        /// <summary>
        /// method when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_user_Load(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open(); //opens connection
            string query = "Select * from users ORDER BY [ID]"; //query selecting all the information from the users table
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable users = new DataTable();
            myDataAdapter.Fill(users); //fils the datagrid with the results from the query
            userdata.DataSource = users;
        }
        /// <summary>
        /// method when the delete user button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow item in this.userdata.SelectedRows) //foreach loop that gets all the selected rows in the datagrid
                {
                    System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                    connection.Open();//opens connection
                    string user = userdata.SelectedRows[0].Cells[1].Value.ToString();
                    String query2 = "DELETE FROM users WHERE [username]='" + user + "'"; //query that deletes selected rows
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query2, connection);
                    cmd.ExecuteNonQuery(); //executes query
                    MessageBox.Show("deleted"); //message box confirming the account has been deleted
                    userdata.Rows.RemoveAt(item.Index); //removes user in the actual database

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
        /// <summary>
        /// method when the update user button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_user_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.userdata.SelectedRows) //foreach loop that goes through each selected row
                {
                    System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                    connection.Open();//opens connection
                    string user = userdata.SelectedRows[0].Cells[1].Value.ToString();//assigns user to the second array index on the table
                    String query = "UPDATE users SET [username] = '" + update_name.Text + "', [password] = '" + update_password.Text + "' WHERE [username] ='" + user + "'";//query that updates the username or password values where user is at the selected index
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();//executes query
                    MessageBox.Show("updated");//messagebox confirming the information has been updated
                    this.Refresh();//refeshes page
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

