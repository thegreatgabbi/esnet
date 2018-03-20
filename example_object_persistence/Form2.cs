using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_entityframework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Example of updating, adding and inserting the DB with EF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            Customer c = ctx.Customers.First(x => x.CustomerID == "1007"); // Lambda expression
            label1.Text = c.CustomerName + " " + c.MemberRating;
            c.MemberRating = "B";
            label1.Text = c.CustomerName + " " + c.MemberRating;

            //// create a new customer
            //Customer cN = new Customer();
            //cN.CustomerID = "1007";
            //cN.CustomerName = "Bond";
            //cN.MemberRating = "Z";

            //// added to the customers collection
            //ctx.Customers.Add(cN);

            // remove from customers collection
            ctx.Customers.Remove(c);

            ctx.SaveChanges(); // save your changes
        }
    }
}
