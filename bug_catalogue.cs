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
    public partial class bug_catalogue : Form
    {
        public bug_catalogue(string user)
        {
            InitializeComponent();
            label4.Text = user;
        }

        private void bug_catalogue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_DatabaseDataSet.error_code' table. You can move, or remove it, as needed.
            this.error_codeTableAdapter.Fill(this.user_DatabaseDataSet.error_code);
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();


                OleDbCommand command = new OleDbCommand("Select * from error_code", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader.GetString(1);
                    string b = reader.GetString(2);
                    string c = reader.GetString(3);
                    DateTime d = reader.GetDateTime(4);
                    string f = reader.GetString(5);

                    user.Text = a;
                    language.Text = b;
                    description.Text = c;
                    time.Text = d.ToString();
                    file.Text = f;

                }
                reader.Close();
            
            
            }
            catch  (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
      }
    }
}
