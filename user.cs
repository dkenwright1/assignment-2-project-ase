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
    public partial class user : Form
    {
       
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="user"></param>

        public user(string user)//passes on username.
        {
            InitializeComponent();
            label3.Text = user;//text in label3 3 become username
            
        }

        private void user_Load(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// method for when the report button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportbtn_Click(object sender, EventArgs e)
        {
            report_bug reportpage = new report_bug(label3.Text);//opens the report form, passing on the username
            reportpage.ShowDialog();
        }
        /// <summary>
        /// method for when the fix bug button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fixbtn_Click(object sender, EventArgs e)
        {
           Fix_code fixpage = new Fix_code(label3.Text);//opens the fix page form, passing on the username
            fixpage.ShowDialog();
        }
        /// <summary>
        /// method for when the view submitted button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            fixed_code fixpage = new fixed_code(label3.Text);//opens the fixed bugs form, passing on the username
            fixpage.ShowDialog();
        }
        /// <summary>
        /// method for when the solved bugs button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solved_bugs_Click(object sender, EventArgs e)
        {
            solved_bugs solved = new solved_bugs(label3.Text); //opens the solved bugs form, passing on the username
            solved.ShowDialog();
        }
        /// <summary>
        /// method for when the log off button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();//open homepage
            this.Close();//closes this form
        }
    }
}
