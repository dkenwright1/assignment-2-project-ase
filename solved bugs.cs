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
        public solved_bugs(string user)
        {
            InitializeComponent();
            label3.Text = user;
        }

        private void solved_bugs_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mmtt");

            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            string query = "Select [ID], [user], [language], [description], [date added], [file], [Repo URL], [code] From error_code WHERE [Fixed] = 1";
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
            cmd.CommandType = CommandType.Text;
            System.Data.OleDb.OleDbDataAdapter myDataAdapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable error_code = new DataTable();
            myDataAdapter.Fill(error_code);
            dataGridView1.DataSource = error_code;

        
            OleDbCommand command = new OleDbCommand("Select [ID] From error_code WHERE [Fixed] = 1", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();
                OleDbCommand command2 = new OleDbCommand("Select * from error_code WHERE [ID] = " + comboBox1.Text + "", connection);
                OleDbDataReader reader3 = command2.ExecuteReader();
                OleDbCommand command = new OleDbCommand("Select * from fixed_code WHERE [code ID] = " + comboBox1.Text + "", connection);
                OleDbDataReader reader2 = command.ExecuteReader();

                while (reader2.Read() && reader3.Read())
                {

                    comboBox2.Items.Add(reader2[2]);
                    string a = reader3.GetString(8);

                    Orignal_code.Text = a;





                    




                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {



                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand("Select * from fixed_code WHERE [code ID] = " + comboBox1.Text + " AND user = '" + comboBox2.Text + "'", connection);
                OleDbDataReader reader2 = command.ExecuteReader();

                while (reader2.Read())
                {
                    string a = reader2.GetString(3);
                    string b = reader2.GetString(4);
                    int c = reader2.GetInt32(5);
                    DateTime d = reader2.GetDateTime(7);
                    string f = reader2.GetString(6);







                    class_name.Text = a;
                    method.Text = b;
                    line.Text = c.ToString();
                    date.Text = d.ToString();
                    new_code.Text = f;




                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
    }
}
