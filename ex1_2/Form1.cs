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

namespace ex1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // define connection string
            string conS = "data source = (local); integrated security = SSPI; initial catalog = Dafesty";
            // create connection
            SqlConnection cn = new SqlConnection(conS);
            // create command
            SqlCommand cm = new SqlCommand();

            cm.CommandText = "select * from Movies";
            cm.Connection = cn;

            // open connection
            cn.Open();
            SqlDataReader rd = cm.ExecuteReader();

            // execute command
            while(rd.Read())
            {
                MovieListBox.Items.Add(rd["MovieTitle"]);
            }
        }
    }
}
