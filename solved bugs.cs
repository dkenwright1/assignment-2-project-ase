using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logon
{
    public partial class solved_bugs : Form
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="user"></param>
        public solved_bugs(string user)//passes on the username 
        {
            InitializeComponent();
            label3.Text = user;//label 3 text become the username
        }
        /// <summary>
        /// method for when form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solved_bugs_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");//lable 2 becomes the current date and time

            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();//opens connection
            string query = "Select [ID], [user], [language], [description], [date added], [file], [Repo URL], [code] From error_code WHERE [Fixed] = 1";//query selecting information from error code where fixed is equal to 1
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable error_code = new DataTable();
            myDataAdapter.Fill(error_code);//fills datagrid with results of query
            dataGridView1.DataSource = error_code;//assigns data source

        
            OleDbCommand command = new OleDbCommand("Select [ID] From error_code WHERE [Fixed] = 1", connection);//query to selct id form error code where fixed is equal to 1
            OleDbDataReader reader = command.ExecuteReader();//executes reader
            while (reader.Read())//while loop for when reader is running
            {
                comboBox1.Items.Add(reader[0]);//gives combobox1 the values from the query

            }
        }

        /// <summary>
        /// method for when the combobox1 index is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();//opens connection
                OleDbCommand command2 = new OleDbCommand("Select * from error_code WHERE [ID] = " + comboBox1.Text + "", connection);//query selecting all from errorcode where the id is equal to the combobox text
                OleDbDataReader reader3 = command2.ExecuteReader();//executes reader 2
                OleDbCommand command = new OleDbCommand("Select * from fixed_code WHERE [code ID] = " + comboBox1.Text + "", connection);//query selecting all from fixed code where code id is equal too the combobox text
                OleDbDataReader reader2 = command.ExecuteReader();//executes reader 2

                while (reader2.Read() && reader3.Read())//while loop for when reader2 and reader3 are active
                {

                    comboBox2.Items.Add(reader2[2]);//populates combobox 2 with the values from the first query
                    string a = reader3.GetString(8);//gets the information from index 8 of the second query

                    Orignal_code.Text = a;//assigns the reslt of index 8 as text in the original code textbox
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
        /// <summary>
        /// method for when the index is changed in combobox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();//opens connection
                OleDbCommand command = new OleDbCommand("Select * from fixed_code WHERE [code ID] = " + comboBox1.Text + " AND user = '" + comboBox2.Text + "'", connection);//query selecting all from fixed code where code id is equal to the combobox1 and the user is equal to combobox2
                OleDbDataReader reader2 = command.ExecuteReader();//executes reader2

                while (reader2.Read())//while loop for when reader2 is active
                {
                    string a = reader2.GetString(3);//gets the information from index 3 of the table
                    string b = reader2.GetString(4);//gets the information from index  of 4 the table
                    int c = reader2.GetInt32(5);//gets the information from index 5 of the table as an integer
                    DateTime d = reader2.GetDateTime(7);//gets the information from index 7 of the table as a datetime
                    string f = reader2.GetString(6);//gets the information from index 6 of the table







                    class_name.Text = a;//assigns value a to a text box
                    method.Text = b;//assigns value b to a text box
                    line.Text = c.ToString();//assigns value c to a text box
                    date.Text = d.ToString();//assigns value d to a text box
                    new_code.Text = f;//assigns value f to a text box




                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
    }
}
