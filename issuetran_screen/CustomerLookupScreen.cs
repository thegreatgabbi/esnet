﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace issuetran_screen
{
    // TODO: Event handler for OK Button
    // TODO: Event handler for Cancel Button
    public partial class CustomerLookupScreen : Form
    {
        public IssueTranForm refIssueTran;
        DafestyEntities context;
        public CustomerLookupScreen()
        {
            InitializeComponent();
            // linq query
            context = new DafestyEntities();
            var q = from x in context.Customers select x;
            // display in datagridview
            CustomerDataGridView.DataSource = q.ToList();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            // get selected index
            int selected = CustomerDataGridView.CurrentCell.RowIndex;
            // get the value of CustomerID and CustomerName from query
            var q = from x in context.Customers select x;
            List<Customer> l = q.ToList();

            // set Form1.CustomerIDTextBox.Text = selected row
            refIssueTran.Cid = l[selected].CustomerID;
            refIssueTran.Cname = l[selected].CustomerName;

            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
