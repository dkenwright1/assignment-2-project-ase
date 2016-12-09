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
    public partial class Fix_code : Form
    {
        public Fix_code(string user)
        {
            InitializeComponent();
            label3.Text = user;
        }

        private void Fix_code_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");

            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            string query = "Select [ID],[user],[code],[description],[date added] from error_code ORDER BY [ID]";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable error_code = new DataTable();
            myDataAdapter.Fill(error_code);
            code_data.DataSource = error_code;
        }
    }
}
