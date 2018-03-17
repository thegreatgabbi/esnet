using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// A basic ADO.NET example with Connection and Command objects.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button which updates the Customers database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // create connection string
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            // create Connection object
            SqlConnection cn = new SqlConnection(conS);
            // create new Command object
            SqlCommand cm = new SqlCommand();
            // update CommandText and link to Connection
            cm.CommandText = "Update customers set MemberCategory='D' where customerID='1000'";
            cm.Connection = cn;

            cn.Open(); // open the Connection
            cm.ExecuteNonQuery();
            cn.Close(); // close the Connection

        }

        /// <summary>
        /// Reads CustomerName and MemberCategory in Customers database and displays it in a list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            // create connection object
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "Select * from Customers";
            cm.Connection = cn;

            cn.Open(); // open the connection
            SqlDataReader rd = cm.ExecuteReader();

            // update label1 with all the CustomerName and MemberCategory entries
            label1.Text = "";
            while(rd.Read())
            {
                label1.Text += rd["CustomerName"].ToString() + " " + rd["MemberCategory"].ToString() + Environment.NewLine;
            }

            rd.Close(); // close the reader object
            cn.Close(); // close the connection
        }

        /// <summary>
        /// Example of how to prevent SQL injection by using SQL variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            
            string sql = "Update customers set MemberCategory=@MC where CustomerID=@CID";
            SqlParameter pMC = new SqlParameter("@MC", SqlDbType.NVarChar, 2);
            SqlParameter pCID = new SqlParameter("@CID", SqlDbType.NVarChar, 4);

            cm.CommandText = sql;
            cm.Connection = cn;

            cm.Parameters.AddWithValue("@MC", "D");
            cm.Parameters.AddWithValue("@CID", 1000 );

            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
    }
}
