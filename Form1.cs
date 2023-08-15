using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polly_Pipe_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter User Name and Password");
            }
            else if (txtUserName.Text == "Admin" && txtPassword.Text == "123" && cmboxLoginType.Text == "Admin")
            {
                SyStem_Menu ob = new SyStem_Menu();
                ob.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" User Name OR  Password is Wrong ");
            }
        }
    }
}
