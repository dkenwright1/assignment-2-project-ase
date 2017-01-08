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
    /// <summary>
    /// form where user can create an account
    /// </summary>
    public partial class create : Form
    {
        /// <summary>
        /// main method
        /// </summary>
        public create()
        {
            InitializeComponent();
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method that activates when logon button is collected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open(); //opens a connection to the database
            try
            {
                String user = usercreate.Text.ToString(); //assigns a user variable to the value in the user create text box
                String passwordcreated = passwordcreate.Text.ToString(); //assigns the passwordcreated variable the value in the password create text box
                String confpassword = confpass.Text.ToString(); //assigns the value of confpassword the value entered in the confpass 
                if ((passwordcreated == confpassword) && (user != null) && (passwordcreated!= null) && (confpassword!= null)) //if statement which checkes if passowrd created and confpass match, and if eveythings filled in
                {
                
                String query = "INSERT INTO users ([username], [password]) VALUES('" + usercreate.Text + "','" + passwordcreate.Text + "')"; //query that insert account information into the users table
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                cmd.ExecuteNonQuery(); //executes query
                MessageBox.Show("Your account has been added to the database");
                    string AccountSid = "AC0f14b91fbabaea30a3fec2b0c00854d4"; //adds a account sid value
                    string AuthToken = "4a7015a3f4a2b4a7ffc9d43a0e63cba1"; // adds a accounttoken value

                    var twilio = new TwilioRestClient(AccountSid, AuthToken);

                    var message = twilio.SendMessage("+441302590414", "+447568435918", "An account has been added to the user database " + usercreate.Text); //assigns number to send a sms message to and from, and creates the message
                    Console.WriteLine(message.Sid); //sends sms message
                    this.Close(); //closes form
                
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

        private void create_Load(object sender, EventArgs e)
        {

        }
    }
}
