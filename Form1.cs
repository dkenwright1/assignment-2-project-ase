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
    public String username;//username which is passed to several forms
    /// <summary>
    /// main method
    /// </summary>
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
    /// <summary>
    /// method when the clear button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void clear_button_Click(object sender, EventArgs e)
    {
        usernametxt.Text = String.Empty;//clears username text box
        passwordtxt.Text = String.Empty;//clears password text box
    }
    /// <summary>
    /// method when the logon button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void logon_button_Click(object sender, EventArgs e)
    {
        try
        {
            username = usernametxt.Text.ToString();//assigns username to the value of the username text box
            System.Data.OleDb.OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();//opens connection
            OleDbCommand command2 = new OleDbCommand("select * from admin where username='" + usernametxt.Text + "' and [password]='" + passwordtxt.Text + "'", connection);
            OleDbDataReader reader = command2.ExecuteReader(); //executes data reader
            if (reader.Read() == true)//if statement to see whether the reader is true
            {
                MessageBox.Show("admin signed in");//message box confirming that the admin has been signed in
                new admin().Show(); //opens admin form
                this.Hide(); //hides this form

            }
            else
            {

                OleDbCommand command = new OleDbCommand("select * from users where username='" + usernametxt.Text + "' and [password]='" + passwordtxt.Text + "'", connection); //query selecting all the information from the user that matches the username and password
                OleDbDataReader reader2 = command.ExecuteReader();//executes reader2



                if (reader2.Read() == true)//if statement for when reader 2 is true 
                {
             

                    MessageBox.Show("signed in as user");//meassage box confirming the user has signed in
                    this.Hide();//hides this form
                    user userpage = new user(usernametxt.Text);//open uesrpage while passing on user name
                    userpage.ShowDialog();//shows username dialogue on new form
                }
                else
                {
                    MessageBox.Show("account doesn't exist");//message for if data is invalid
                    //   break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed due to " + ex.Message);

        }
        }
        /// <summary>
        /// method for when the create account button is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void create_button_Click(object sender, EventArgs e)
    {
        new create().Show();//open the create user form
            
    }


        
}

}
    

