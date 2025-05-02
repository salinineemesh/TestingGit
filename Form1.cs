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

namespace insert_delete_upadta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string query = "";
       // string contr = "Data Source=LAPTOP-RUJNVDST\\SQLEXPRESS;database=employee_details;Integrated Security=True"; 
        private void insert_Click(object sender, EventArgs e)
        {
            int myVar = 0;
            // If myVar is an even number, click Button2.
            if (myVar % 2 == 0)
            {
                insert.PerformClick();
                // Display the status of Button2's Click event.
                MessageBox.Show("button2 was clicked ");
            }
            else
            {
                // Display the status of Button2's Click event.
                MessageBox.Show("button2 was NOT clicked");
            }
            // Increment myVar.   
            myVar = myVar + 1;
            //SqlConnection con = new SqlConnection(contr);
            //if (txtid.Text == "")
            //{
            //    MessageBox.Show("Enter Employee ID");

            //}
            //else if (txtname.Text == "")
            //{
            //    MessageBox.Show("Enter Employee name");

            //}
            //else if (txtsalary.Text == "")
            //{
            //    MessageBox.Show("Enter Employee salary");

            //}
            //else
            //     query = "insert in to tbl_empdetails (empid,empname,salary) values (@empid,@empname,@salary)";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@empid", txtid.Text);
            //cmd.Parameters.AddWithValue("@empname", txtname.Text);
            //cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
            //con.Open()  ;
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //if (i < 0)

            //{
            //    MessageBox.Show("sucess");
            //    txtid.Text = "";
            //    txtname.Text = "";
            //    txtsalary.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("not sucess");
            //    txtid.Text = "";
            //    txtname.Text = "";
            //    txtsalary.Text = "";
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-RUJNVDST\\SQLEXPRESS;database=employee_details;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbl_empdetails", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = rdr;
            dataGridView1.DataSource=source;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
}
