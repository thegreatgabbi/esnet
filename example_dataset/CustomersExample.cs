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

        /// <summary>
        /// Display data from Customers table by creating DataSet, using DataAdapter to .Fill it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            //// create connection string
            //string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            //// create connection object
            //cn = new SqlConnection(conS);
            //cm = new SqlCommand();
            //cm.CommandText = "Select CustomerID, CustomerName, MemberCategory from Customers";
            //cm.Connection = cn;

            //// create DataAdapter
            //da = new SqlDataAdapter(cm);

            //// create DataSet
            //ds = new DataSet();
            //// populates DataSet with data from Customers
            //da.Fill(ds, "Customers");

            //// display table entry in label1
            //// label1.Text = ds.Tables[0].Rows.Count.ToString();
            //label1.Text = ds.Tables[0].Rows[5][1].ToString();


            ds.Tables["Customers"].Rows.Find("1000");

        }

        /// <summary>
        /// Assumes data has been loaded into DataSet. `Update`s the DB with the DataSet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Make changes to your DataSet
            ds.Tables[0].Rows[5][1] = "Stephen Ou";
            label1.Text = ds.Tables[0].Rows[5][1].ToString();

            da.Update(ds, "Customers");
        }

        /// <summary>
        /// Assumes data has been loaded into DataSet. Creates a 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Create a new row (haven't change DataSet yet!)
            DataRow r = ds.Tables["Customers"].NewRow();
            // Update corresponding fields
            r["CustomerID"] = 1007;
            r["CustomerName"] = "Venkat";
            r["MemberCategory"] = "C";

            // Add the row to your DataSet
            ds.Tables["Customers"].Rows.Add(r);
            // Update the DB with your DataSet
            da.Update(ds, "Customers");
        }
    }
}
