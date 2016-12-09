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
       


        public user(string user)
        {
            InitializeComponent();
            label3.Text = user;
            
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

        private void reportbtn_Click(object sender, EventArgs e)
        {
            report_bug reportpage = new report_bug(label3.Text);
            reportpage.ShowDialog();
        }

        private void fixbtn_Click(object sender, EventArgs e)
        {
           Fix_code fixpage = new Fix_code(label3.Text);
           fixpage.ShowDialog();
        }
    }
}
