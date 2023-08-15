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
    public partial class SyStem_Menu : Form
    {
        public SyStem_Menu()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eMPLOYEEINSTALLATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void eQUIPMENTINSTALLATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void aDDToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CUSTOMER_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer ob = new Customer();
            ob.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Equpment ob = new Equpment();
            ob.Show();
            this.Hide();
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee ob = new Employee();
            ob.Show();
            this.Hide();
        }

        private void PAYMENT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Payment ob = new Payment();
            ob.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            INSTALLATION ob = new INSTALLATION();
            ob.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EMPLOYEE__INSTALLATION ob = new EMPLOYEE__INSTALLATION();
            ob.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EQUIPMENT__INSTALLATION ob = new EQUIPMENT__INSTALLATION();
            ob.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            INSTALLATION_TYPE ob = new INSTALLATION_TYPE();
            ob.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }
    }
}
