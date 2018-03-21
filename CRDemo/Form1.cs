using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create new dataset
            DafestySet ds = new DafestySet();
            // create new adapter
            DafestySetTableAdapters.CustomersTableAdapter ta = new DafestySetTableAdapters.CustomersTableAdapter();
            // fill the Customers dataset
            ta.Fill(ds.Customers);
            // Show that there's stuff
            label1.Text = ds.Customers.Count.ToString();



        }
    }
}
