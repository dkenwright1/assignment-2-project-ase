using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment_2_project_ase
{
    public partial class create_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confpass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\ASD\ase 2\user Database.accdb");
            connection.Open();
            try
            {
                String user = createuser.Text.ToString();
                String passwordcreated = createpass.Text.ToString();
                String confpassword = confpass.Text.ToString();
                if ((passwordcreated == confpassword) && (user != null) && (passwordcreated != null) && (confpassword != null))
                {

                    String query = "INSERT INTO users ([username], [password]) VALUES('" + createuser.Text + "','" + createpass.Text + "')";
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    Response.Write("Your acccount has been added to the database");
                    

                }
                else
                {
                    Response.Write("Passwords must match and no fields can be empty");
                }

            }
            catch (Exception ex)
            {
                Response.Write("Failed due to " + ex.Message);
            }
        }
    }
}