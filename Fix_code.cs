using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logon
{
    public partial class Fix_code : Form
    {
        //main method
        public Fix_code(string user)//passes the user name to the form
        {
            InitializeComponent();
            label3.Text = user;//label 3 becomes the usr variable when form opens
        }
        /// <summary>
        /// method when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fix_code_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");//label 4 becomes the current date and time

            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();//opens connection
            string query = "Select [ID], [user], [language], [description], [date added], [file], [Repo URL], [code] From error_code WHERE [Fixed] = 0";//query that gets information from records in the error code table where fixed is equal to zero
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable error_code = new DataTable();
            myDataAdapter.Fill(error_code); //fills the table with the query results
            code_data.DataSource = error_code;//assigns data source
        }
        /// <summary>
        /// method when the submit solution button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();//opens connection
            if (codeID != null && src_class != null && solution != null)//if statement that makes sure certain fields are filled in
            { 

            String query = "INSERT INTO fixed_code ([code ID], [user], [class], [method], [line], [solution], [time added]) VALUES(" + codeID.Text + ",'" + label3.Text + "','" + src_class.Text + "','" + method.Text + "'," + line.Text + ",'" + solution.Text + "','" + label4.Text + "')";
            //query that adds the values of the text boxes and rich text boxes to the database
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.ExecuteNonQuery();//executes query
            MessageBox.Show("Your solution has been added to the database");// message box to confirm that the database has been updated
            }
            else
            {
                MessageBox.Show("Code id class and solution must be filled in");
            }
        }
        /// <summary>
        /// method for when the bug log button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bug_log_Click(object sender, EventArgs e)
        {
            bug_catalogue bugpage = new bug_catalogue(label3.Text); //opens the bug catalogue form while passing on the username
            bugpage.ShowDialog(); //open dialogue on bug catalogue 
        }

        private void code_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// method for when the text is changed in the code data text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solution_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] words = new string[] { "class", "public void", "string" };//creates a string array with some values
                for (int i = 0; i < words.Length; i++) //for loop that increments the length of the word array
                {
                    Regex rx = new Regex(words[i]);//assigns the regualr expression variable to the array
                    int index = solution.SelectionStart;//assigns index the start of the teaxt box

                    foreach (Match m in rx.Matches(solution.Text))//foreach loop that goes throught all the words in the solution text box
                    {
                        solution.Select(m.Index, m.Value.Length);
                        solution.SelectionColor = Color.Blue;//changes matches to blue
                        solution.SelectionStart = index;
                        solution.SelectionColor = Color.Black;//sets default colour of the text
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);

            }
        }
    }
}
