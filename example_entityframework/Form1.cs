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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            dataGridView1.DataSource = context.Customers.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            // write a LINQ Query (don't need to type SQL)
            var q = from x in context.Customers where x.CustomerID == "1007" select x;

            // get first object from Collection
            Customer c = q.First();
            label1.Text = c.CustomerName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            var q = from x in context.Customers where x.MemberRating == "A" && x.CustomerName.Substring(0,1) == "R" orderby x.CustomerName select x;
            List<Customer> lst = q.ToList();
            dataGridView1.DataSource = lst;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            //var q = from x in context.Customers select x;

            //Customer c = context.Customers.Where(x => x.CustomerID == "1111").First();

            //label1.Text = c.CustomerName;

            List<Customer> lst = context.Customers.Where(x => x.MemberRating == "A").ToList();
            lst = context.Customers.OrderBy(x => x.CustomerName).ToList();
            lst = context.Customers.Where(y => y.MemberRating == "A").OrderBy(x => x.CustomerName).ToList();
            lst = context.Customers.Where(y => y.MemberRating == "A" && y.CustomerName.Substring(0,1) == "B").ToList();

            dataGridView1.DataSource = lst;

            int noofAmem = context.Customers.Count(x => x.MemberRating == "A");
            label1.Text = (noofAmem).ToString();
            decimal? d = context.Customers.Sum(x => x.AmountSpent); // nullable datatypes
            label1.Text = (d).ToString();
        }
    }
}
