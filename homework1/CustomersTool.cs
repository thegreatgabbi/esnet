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

namespace homework1
{
    public partial class CustomersTool : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds;
        public CustomersTool()
        {
            InitializeComponent();
            // Create Connection
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            cn = new SqlConnection(conS);
            // Create Command
            cm = new SqlCommand();
            // Link Command to Connection
            cm.CommandText = "SELECT * FROM Customers";
            cm.Connection = cn;
            // Create DataAdapter
            da = new SqlDataAdapter(cm);
            // Create DataSet
            ds = new DataSet();
            da.Fill(ds, "Customers");
            // Define CustomerID as primary key
            ds.Tables["Customers"].PrimaryKey = new DataColumn[] { ds.Tables["Customers"].Columns["CustomerID"] };
        }

        /// <summary>
        /// Loads data from the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            // TODO: search CustomerID column for value in CustomerIDTextBox
            string cid = CustomerIDTextBox.Text;

            if (cid == "")
            {
                MessageBox.Show("Please enter a Customer ID.");
            } else {
                DataRow cidRow = ds.Tables["Customers"].Rows.Find(cid);
                if (cidRow != null)
                {
                    CustomerIDTextBox.Text = cidRow["CustomerID"].ToString();
                    CustomerNameTextBox.Text = cidRow["CustomerName"].ToString();
                    MemberCategoryTextBox.Text = cidRow["MemberCategory"].ToString();
                } else
                {
                    MessageBox.Show("Customer ID not found.");
                }
                
            }
        }

        /// <summary>
        /// Update CustomerName or MemberCategory of CustomerID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Creates a new row with CustomerID, CustomerName and MemberCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Given a CustomerID, deletes the row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Find details by CustomerID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {

        }
    }
}
