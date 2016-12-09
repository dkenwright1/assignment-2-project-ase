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
    public partial class Form1 : Form
    {
        public String username;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            usernametxt.Text = String.Empty;
            passwordtxt.Text = String.Empty;
        }

        private void logon_button_Click(object sender, EventArgs e)
        {
            try
            {
                username = usernametxt.Text.ToString();
                System.Data.OleDb.OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();
                OleDbCommand command2 = new OleDbCommand("select * from admin where username='" + usernametxt.Text + "' and [password]='" + passwordtxt.Text + "'", connection);
                OleDbDataReader reader = command2.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("admin signed in");
                    new admin().Show();
                    this.Hide();

                    
                    // break;
                }
                else
                {

                    OleDbCommand command = new OleDbCommand("select * from users where username='" + usernametxt.Text + "' and [password]='" + passwordtxt.Text + "'", connection);
                    OleDbDataReader reader2 = command.ExecuteReader();



                   
                    

                    if (reader2.Read() == true)
                    {
                        //Session ["username"] = usernametxt.Text;

                        MessageBox.Show("correct");
                        this.Hide();
                        user userpage = new user(usernametxt.Text);
                        userpage.ShowDialog();
                        






                    }
                    else
                    {
                        MessageBox.Show("account doesn't exist");
                        //   break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);

            }
            }

        private void create_button_Click(object sender, EventArgs e)
        {
            new create().Show();
            
        }


        //   connection.Close();
        //  command.Dispose();
        //  connection.Dispose();

    }

    }
    

