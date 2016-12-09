using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment_2_project_ase
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clearbtn_Click(object sender, EventArgs e)
        {
            user.Text = String.Empty;
            txtpass.Text = String.Empty;
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
                connection.Open();
                OleDbCommand command2 = new OleDbCommand("select * from admin where username='" + user.Text + "' and [password]='" + txtpass.Text + "'", connection);
                OleDbDataReader reader = command2.ExecuteReader();
                if (reader.Read() == true)
                {
                    Response.Write("admin signed in");
                    //new admin().Show();
                    //this.Hide();


                    // break;
                }
                else
                {

                    OleDbCommand command = new OleDbCommand("select * from users where username='" + user.Text + "' and [password]='" + txtpass.Text + "'", connection);
                    OleDbDataReader reader2 = command.ExecuteReader();






                    if (reader2.Read() == true)
                    {
                        //Session ["username"] = usernametxt.Text;

                        Response.Write("signed in as user");
                        //this.Hide();
                        //user userpage = new user(usernametxt.Text);
                        //userpage.ShowDialog();







                    }
                    else
                    {
                        Response.Write("account doesn't exist");
                        //   break;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Failed due to " + ex.Message);

            }
        }
    }
}