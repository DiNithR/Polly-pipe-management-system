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
    public partial class Customer : Form
    {
        public Customer()
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

                SqlCommand command = new SqlCommand("INSERT INTO [CUSTOMER] (C_Id,C_Name,C_NIC,C_Address,Con_No) VALUES ('" + txtcusid.Text + "','" + TxtcusName.Text + "','" + txtcusNic.Text + "','" + txtcusadd.Text + "','" + txtcusnum.Text + "')", con);
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

        private void Customer_Load(object sender, EventArgs e)
        {
            Cus_view();
        }

        public void Cus_view()
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT *  FROM [CUSTOMER] ", con);
                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.Columns[0].HeaderText = "Cust_Id";
                dataGridView1.Columns[1].HeaderText = "Cust_Name";
                dataGridView1.Columns[2].HeaderText = "Cust_NIC";
                dataGridView1.Columns[3].HeaderText = "Cust_Address";
                dataGridView1.Columns[4].HeaderText = "Contact_No";
         

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcusid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtcusName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcusNic.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcusadd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtcusnum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {
                con.Open();

                SqlCommand command = new SqlCommand("UPDATE [CUSTOMER] SET Cust_Name = '" + TxtcusName.Text + "', Cust_NIC = '" + txtcusNic.Text + "', Cust_Address = '" + txtcusadd.Text + "',Contact_No = '" + txtcusnum.Text + "' WHERE Cust_Id = '" + txtcusid.Text + "' ", con);

                command.ExecuteNonQuery();
            
                MessageBox.Show("Update Successfully", "POLLI PIPE  System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cus_view();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {
                con.Open();

                SqlCommand command = new SqlCommand("delete  FROM [CUSTOMER] where Cust_Id='" + txtcusid.Text + "' ", con);
                command.ExecuteNonQuery();

                MessageBox.Show("delete Successfully", "Polly System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cus_view();
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
