using System;
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
        public IssueTranForm RefToForm1;
        public CustomerLookupScreen()
        {
            InitializeComponent();
            // linq query
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Customers select x;
            // display in datagridview
            CustomerDataGridView.DataSource = q.ToList();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            int selected = CustomerDataGridView.CurrentCell.RowIndex;
            // set Form1.CustomerIDTextBox.Text = selected row
            RefToForm1.Cid = "1000";
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
