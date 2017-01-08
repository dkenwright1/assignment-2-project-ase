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
    public partial class fixed_code : Form
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="user"></param>
        public fixed_code(string user)//passes the username
        {
            InitializeComponent();
            label4.Text = user;//makes the text of label 4 to the username
        }
        /// <summary>
        /// method when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fixed_code_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");//label 2 becomes the current date and time

            
        }
        /// <summary>
        /// method when the search button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string searchstring = search.Text;
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();//opens connection

            string query = "Select [code ID], [user], [class], [method], [line], [solution], [time added] FROM fixed_code WHERE [code ID] LIKE '%" + searchstring + "%'";//query that searches the fixed code where the code id is like the search string
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable fixed_code = new DataTable();
            myDataAdapter.Fill(fixed_code);//fills datagrid with search results
            dataGridView1.DataSource = fixed_code;//assigns the data source
        }

    }
    }

