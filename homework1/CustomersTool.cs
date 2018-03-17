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
        public CustomersTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads data from the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            // Create Connection
            string conS = "data source=(local); integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            // Create Command
            SqlCommand cm = new SqlCommand();
            // Link Command to Connection
            cm.CommandText = "SELECT * FROM Customers";
            cm.Connection = cn;
            // Create DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cm);
            // Create DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");

            // display first row
            CustomerIDTextBox.Text = ds.Tables[0].Rows[0][0].ToString();
            CustomerNameTextBox.Text = ds.Tables[0].Rows[0][1].ToString();
            MemberCategoryTextBox.Text = ds.Tables[0].Rows[0][2].ToString();
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
