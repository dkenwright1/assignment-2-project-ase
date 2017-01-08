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
    /// <summary>
    /// admin login homepage
    /// </summary>
    public partial class admin : Form

    {
        /// <summary>
        /// initializes program, main method
        /// </summary>
        public admin()
        {
            InitializeComponent(); //starts program
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// action when the delete account button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_account_Click(object sender, EventArgs e)
        {
            new edit_user().Show(); //opens up the edit user form
        }
        /// <summary>
        /// action when the create admin button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_admin_Click(object sender, EventArgs e)
        {
            new edit_admin().Show(); //opens the edit admin form
        }

        /// <summary>
        /// action when the admin logoff button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void admin_logoff_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show(); //logs off the admin, opens the login form
        }

        /// <summary>
        /// action when the fixed state button button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            new fix_changing().Show(); //open the fix changing form
        }
    }
}
