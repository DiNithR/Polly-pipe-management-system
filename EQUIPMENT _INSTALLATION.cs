using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Polly_Pipe_System
{
    public partial class EQUIPMENT__INSTALLATION : Form
    {
        public EQUIPMENT__INSTALLATION()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SyStem_Menu ob = new SyStem_Menu();
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {


                con.Open();

                SqlCommand command = new SqlCommand("INSERT INTO [INSTALLATION_EQUPMENT] (Emp_Id,InsID) VALUES ('" + txteqID.Text + "','" + txtinsID.Text + "')", con);
                command.ExecuteNonQuery();

                MessageBox.Show("Insert Successfully", "Polly System", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        
        
        }
    }
}
