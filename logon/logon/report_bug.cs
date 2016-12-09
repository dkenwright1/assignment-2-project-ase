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
    public partial class report_bug : Form
    {
        public report_bug(string user)
        {
            InitializeComponent();
            label2.Text = user;
        }

        private void report_bug_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();


                if (description != null || reported_code != null)
                {
                    String query = "INSERT INTO error_code ([user], [code], [description], [date added]) VALUES('" + label2.Text + "','" + reported_code.Text + "','" + description.Text + "', '" + label6.Text + "')";
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your code has been added to the database");
                }

                else
                {
                    MessageBox.Show("No fields can be blank");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
    }
}
