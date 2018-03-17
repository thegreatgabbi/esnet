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

namespace example_dataset
{
    public partial class CustomersExample : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmb;

        public CustomersExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create connection string
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            // create connection object
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.CommandText = "Select CustomerID, CustomerName, MemberCategory from Customers";
            cm.Connection = cn;

            // create data adapter
            da = new SqlDataAdapter(cm);
            cmb = new SqlCommandBuilder(da);

            // create new data set
            ds = new DataSet();
            // creates scheme, takes data and fills it in
            da.Fill(ds, "Customers");

            // display number of tables in the label
            // label1.Text = ds.Tables[0].Rows.Count.ToString();
            // label1.Text = ds.Tables[0].Rows[5][1].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // label1.Text = cmb.GetInsertCommand().CommandText;

            ds.Tables[0].Rows[0][2] = "C";
            label1.Text = ds.Tables[0].Rows[5][1].ToString();

            da.Update(ds, "Customers");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Customers"].NewRow(); // Creates a new dataRow
            r["CustomerID"] = 1007;
            r["CustomerName"] = "Venkat";
            r["MemberCategory"] = "C";

            ds.Tables["Customers"].Rows.Add(r); // add the dataRow to DataSet
            da.Update(ds, "Customers");
        }
    }
}
