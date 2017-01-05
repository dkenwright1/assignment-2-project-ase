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
          
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            OleDbCommand command = new OleDbCommand("Select * from error_code ORDER BY ID", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);

            }
          
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {


                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand("Select * from [error_code] WHERE ID = " + comboBox1.Text + " ORDER BY ID", connection);
                OleDbDataReader reader2 = command.ExecuteReader();



                while (reader2.Read())
                {
                    string a = reader2.GetString(1);
                    string b = reader2.GetString(2);
                    string c = reader2.GetString(3);
                    DateTime d = reader2.GetDateTime(4);
                    string f = reader2.GetString(5);

                    user.Text = a;
                    language.Text = b;
                    description.Text = c;
                    time.Text = d.ToString();
                    file.Text = f;

                }

                reader2.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
