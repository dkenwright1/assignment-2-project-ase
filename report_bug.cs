using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logon
{
    public partial class report_bug : Form
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="user"></param>
       public report_bug(string user)//passed username value
        {
            InitializeComponent();
            label2.Text = user;//label 2 becomes the username
        }

        private void report_bug_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");//label 6 becomes the curretn date and time
        }
        /// <summary>
        /// method when the report button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();//opens connection


                if (filename != null)//if statement for when filename isn't null  
                {
                    String query = "INSERT INTO error_code ([user], [language], [description], [date added], [file], [Repo URL], [code]) VALUES('" + label2.Text + "','" + comboBox1.Text + "','" + summary.Text + "', '" + label6.Text + "', '" + filename.Text + "', '" + URL.Text + "', '" + code.Text + "')";
                    //query that inserts the information into the database for another bug repot
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();//executes query
                    MessageBox.Show("Your code has been added to the database");//confimation message
                }

                else
                {
                    MessageBox.Show("No fields can be blank");//validation message
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// method for when the file upload butto is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;//initializes size to -1
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = folderBrowserDialog1.SelectedPath;//assign file to the selected file path

                try
                {
                    string text = File.ReadAllText(file);//variable reads the text file
                    size = text.Length;//get size of file
                    filename.Text = folderBrowserDialog1.SelectedPath;//changes the text in the text box to the file name

                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); //writes the file size to the console
            Console.WriteLine(result);//writes the result to the console

        }
        /// <summary>
        /// method for when the text has changed in the code text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
