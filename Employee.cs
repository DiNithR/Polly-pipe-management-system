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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Emp_view();
        }

        public void Emp_view()
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT *  FROM [EMPLOYEE] ", con);
                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds;
                dataGridView1.Columns[0].HeaderText = "Emp_Id";
                dataGridView1.Columns[1].HeaderText = "Emp_Name";
                dataGridView1.Columns[2].HeaderText = "Emp_NIC";
                dataGridView1.Columns[3].HeaderText = "Emp_Address";
                dataGridView1.Columns[4].HeaderText = "Emp_Type";
                dataGridView1.Columns[5].HeaderText = "Contact_No";



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

                SqlCommand command = new SqlCommand("INSERT INTO [EMPLOYEE] (Emp_Id,Emp_Name,Emp_NIC,Emp_Address,Emp_Type,Contact_No) VALUES ('" + txteid.Text + "','" + txtename.Text + "','" + txtnic.Text + "','" + txtadd.Text + "','" + txttype.Text + "','" + txtnum.Text + "')", con);
                command.ExecuteNonQuery();

                MessageBox.Show("Insert Successfully", "Polly System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Emp_view();

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

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {
                con.Open();

                SqlCommand command = new SqlCommand("UPDATE [EMPLOYEE] SET Emp_Name = '" + txtename.Text + "', Emp_NIC = '" + txtnic.Text + "', Emp_Address = '" + txtadd.Text + "',Emp_Type = '" + txttype.Text + "',Contact_No = '" + txtnum.Text + "' WHERE Emp_Id = '" + txteid.Text + "' ", con);

                command.ExecuteNonQuery();

                MessageBox.Show("Update Successfully", "POLLI PIPE  System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Emp_view();
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

        private void txteid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txteid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtename.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtnic.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtadd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttype.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtnum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString(); 

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 objconnection = new Class1();
            string getstring = objconnection.conMethod();
            SqlConnection con = new SqlConnection(getstring);

            try
            {
                con.Open();

                SqlCommand command = new SqlCommand("delete  FROM [EMPLOYEE] where Emp_Id='" + txteid.Text + "' ", con);
                command.ExecuteNonQuery();

                MessageBox.Show("delete Successfully", "Polly System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Emp_view();
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
