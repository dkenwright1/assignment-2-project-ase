using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;

namespace logon
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            try
            {
                String user = usercreate.Text.ToString();
                String passwordcreated = passwordcreate.Text.ToString();
                String confpassword = confpass.Text.ToString();
                if ((passwordcreated == confpassword) && (user != null) && (passwordcreated!= null) && (confpassword!= null))
                {
                
                String query = "INSERT INTO users ([username], [password]) VALUES('" + usercreate.Text + "','" + passwordcreate.Text + "')";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your account has been added to the database");
                    string AccountSid = "AC0f14b91fbabaea30a3fec2b0c00854d4";
                    string AuthToken = "4a7015a3f4a2b4a7ffc9d43a0e63cba1";
                    var twilio = new TwilioRestClient(AccountSid, AuthToken);

                    var message = twilio.SendMessage("+441302590414", "+447568435918", "An account has been added to the user database " + usercreate.Text);
                    Console.WriteLine(message.Sid);
                    this.Close();
                
                }
                 else{
                       MessageBox.Show("Passwords must match and no fields can be empty");
                     }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to " + ex.Message);
            }
        }
    }
}
