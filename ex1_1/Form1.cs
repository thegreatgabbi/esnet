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

namespace ex1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // write connection string
            string conS = "data source = (local); integrated security = SSPI; initial catalog = Dafesty";
            // create connection
            SqlConnection cn = new SqlConnection(conS);
            // create command
            SqlCommand cm = new SqlCommand();
            // change command text
            cm.CommandText =
                "update Movies " +
                "set RentalPrice = '" + RentalPriceTextBox.Text +
                "' where VideoCode = '" + VideoCodeTextBox.Text + "'";
            
            cm.Connection = cn;
            // open connection
            cn.Open();
            // execute command
            cm.ExecuteNonQuery();
            // close connection
            cn.Close();

            // What happens if a video code not existing in the database is entered?
            // No row in the database is updated.

            // What disciplines may you need to take to get this situation handled?
            // A: Exception handling. Display an alert if the video code does not exist.
        }
    }
}
