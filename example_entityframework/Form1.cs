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

        /// <summary>
        /// Example of LINQ Query returning only selected columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //DafestyEntities context = new DafestyEntities();
            //var q = from x in context.Customers
            //        select new { x.CustomerID, x.CustomerName, x.MemberRating }; // deriving anonymous class from the Customers class
            //var q1 = from x in context.Customers select x;
            //Customer c = q1.First();
            //dataGridView1.DataSource = q.ToList();

            DafestyEntities context = new DafestyEntities();

            var q = from x in context.Customers
                    group x by x.MemberRating into g
                    select new { MemberCategory = g.Key, AMT = g.Sum(y => y.AmountSpent) };
            dataGridView1.DataSource = q.ToList();
        }

        /// <summary>
        /// Demonstration of anonymous objects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            //Car c1 = new Car("Toyota", "cor"); // Using names
            //Car c2 = new Car("Honda", "City");
            //Car c3 = new Car("Toyota", "Camry");
            List<Car> lst = new List<Car>();
            lst.Add(new Car("Toyota", "cor")); // Look Ma, no variable names!
            lst.Add(new Car("Honda", "City"));
            lst.Add(new Car("Toyota", "Camry"));

            //label1.Text = lst[1].model;


        }

        class Car
        {
            public string model;
            public string make;

            public Car(string mk, string mdl)
            {
                model = mdl;
                make = mk;
            }
        }

    }
}
