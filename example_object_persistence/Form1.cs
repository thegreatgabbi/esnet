using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ef_object_persistence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();

            //// get the customer give the customer name and country name
            //Customer c = ctx.Customers.First(x => x.CustomerID == "1001");
            //label1.Text = c.CustomerName;
            //label2.Text = c.Country.CountryCode;

            Country cn = ctx.Countries.First(x => x.CountryCode == "SWZ");
            foreach (Customer cx in cn.Customers)
            {
                label2.Text += cx.CustomerName + Environment.NewLine;
            }
            
        }
    }
}
