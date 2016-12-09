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
                if ((passwordcreated == confpassword) || (user != null) || (passwordcreated!= null) || (confpassword!= null))
                {
                
                String query = "INSERT INTO users ([username], [password]) VALUES('" + usercreate.Text + "','" + passwordcreate.Text + "')";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your acccount has been added to the database");
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
