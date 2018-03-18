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
        DataTable dt;
        SqlCommandBuilder cmb;

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
            dt = ds.Tables["Customers"];

            // Define CustomerID as primary key
            dt.PrimaryKey = new DataColumn[] { dt.Columns["CustomerID"] };
            // Create new Command Builder
            cmb = new SqlCommandBuilder(da);
        }

        /// <summary>
        /// Gets the CustomerID and gets CustomerName and MemberCategory from the DataSet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            string cId = CustomerIDTextBox.Text;
            string cName = CustomerNameTextBox.Text;
            string memCat = MemberCategoryTextBox.Text;

            if (cId == "")
            {
                MessageBox.Show("Please enter a Customer ID.");
            }
            else
            {
                DataRow cidRow = dt.Rows.Find(cId);
                if (cidRow != null)
                {
                    CustomerIDTextBox.Text = cidRow["CustomerID"].ToString();
                    CustomerNameTextBox.Text = cidRow["CustomerName"].ToString();
                    MemberCategoryTextBox.Text = cidRow["MemberCategory"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer ID not found.");
                }
            }
        }

        /// <summary>
        /// Update CustomerName and/or MemberCategory of CustomerID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string cId = CustomerIDTextBox.Text;
            string cName = CustomerNameTextBox.Text;
            string memCat = MemberCategoryTextBox.Text;

            if (cId == "")
            {
                MessageBox.Show("Please enter a Customer ID.");
            }
            else
            {
                DataRow dr = dt.Rows.Find(cId);
                if (dr != null)
                {
                    dr["CustomerName"] = CustomerNameTextBox.Text;
                    dr["MemberCategory"] = MemberCategoryTextBox.Text;

                    da.Update(ds, "Customers");

                    MessageBox.Show("Customer ID " + cId + " updated.");
                }
                else
                {
                    MessageBox.Show("Customer ID not found.");
                }
            }
        }

        /// <summary>
        /// Creates a new row with CustomerID, CustomerName and MemberCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            string cId = CustomerIDTextBox.Text;
            string cName = CustomerNameTextBox.Text;
            string memCat = MemberCategoryTextBox.Text;

            if (cId == "")
            {
                MessageBox.Show("Please enter a Customer ID.");
            }
            else
            {
                DataRow dr = dt.Rows.Find(cId);
                if (dr == null)
                {
                    if (cId != "" &&
                        cName != "" &&
                        memCat != "")
                    {
                        // create new row
                        DataRow r = dt.NewRow();
                        r["CustomerID"] = cId;
                        r["CustomerName"] = cName;
                        r["MemberCategory"] = memCat;

                        // add row to DataSet
                        dt.Rows.Add(r);
                        // update DB
                        da.Update(ds, "Customers");

                        MessageBox.Show("Customer ID " + cId + " inserted.");
                    }
                    if (cName == "")
                    {
                        MessageBox.Show("Please enter a Customer Name.");
                    }
                    if (memCat == "")
                    {
                        MessageBox.Show("Please enter a Member Category.");
                    }
                }
                else
                {
                    MessageBox.Show("Customer ID already exists.");
                }
            }
        }

        /// <summary>
        /// Given a CustomerID, deletes the row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string cId = CustomerIDTextBox.Text;
            string cName = CustomerNameTextBox.Text;
            string memCat = MemberCategoryTextBox.Text;

            if (cId == "")
            {
                MessageBox.Show("Please enter a Customer ID.");
            }
            else
            {
                DataRow dr = dt.Rows.Find(cId);
                if (dr != null)
                {
                    // Delete Row
                    dr.Delete();
                    // Update DB
                    da.Update(ds, "Customers");
                    MessageBox.Show("Customer ID " + cId + " deleted.");
                    // Clear field
                    CustomerIDTextBox.Text = "";
                    CustomerNameTextBox.Text = "";
                    MemberCategoryTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Customer ID not found.");
                }
            }
        }

        /// <summary>
        /// Find details by CustomerID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                bool hasName = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (SearchTextBox.Text == row["CustomerName"].ToString())
                    {
                        hasName = true;
                        CustomerIDTextBox.Text = row["CustomerID"].ToString();
                        CustomerNameTextBox.Text = row["CustomerName"].ToString();
                        MemberCategoryTextBox.Text = row["MemberCategory"].ToString();
                    }
                }
                if (hasName == false)
                {
                    MessageBox.Show("Couldn't find " + SearchTextBox.Text + ".");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name.");
            }
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.Rows[0];
            CustomerIDTextBox.Text = dr["CustomerID"].ToString();
            CustomerNameTextBox.Text = dr["CustomerName"].ToString();
            MemberCategoryTextBox.Text = dr["MemberCategory"].ToString();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            int count = dt.Rows.Count;
            DataRow dr = dt.Rows[count-1];
            CustomerIDTextBox.Text = dr["CustomerID"].ToString();
            CustomerNameTextBox.Text = dr["CustomerName"].ToString();
            MemberCategoryTextBox.Text = dr["MemberCategory"].ToString();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDTextBox.Text != "")
            {
                DataRow newRow;
                if (GetCustomerIndex() == 0) // if first row
                {
                    newRow = dt.Rows[dt.Rows.Count - 1]; // go to last row
                }
                else
                {
                    newRow = dt.Rows[GetCustomerIndex() - 1];
                }
                // Display fields
                CustomerIDTextBox.Text = newRow["CustomerID"].ToString();
                CustomerNameTextBox.Text = newRow["CustomerName"].ToString();
                MemberCategoryTextBox.Text = newRow["MemberCategory"].ToString();
            }
            else
            {
                MessageBox.Show("Enter a Customer ID.");
            }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDTextBox.Text != "")
            {
                DataRow newRow;
                if (GetCustomerIndex() == dt.Rows.Count - 1) // if last row
                {
                    newRow = dt.Rows[0]; // go to first row
                }
                else
                {
                    newRow = dt.Rows[GetCustomerIndex() + 1];
                }
                // Display fields
                CustomerIDTextBox.Text = newRow["CustomerID"].ToString();
                CustomerNameTextBox.Text = newRow["CustomerName"].ToString();
                MemberCategoryTextBox.Text = newRow["MemberCategory"].ToString();
            }
            else
            {
                MessageBox.Show("Enter a Customer ID.");
            }
        }

        private int GetCustomerIndex()
        {
            string cId = CustomerIDTextBox.Text;
            DataRow dr = dt.Rows.Find(cId);
            return dt.Rows.IndexOf(dr);
        }

    }
}
