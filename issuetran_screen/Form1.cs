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
    // TODO: Add IssueTran to EDM (Entity Domain Model)
    public partial class IssueTranForm : Form
    {
        public IssueTranForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Submits the Issue (Rental only)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string cid = CustomerIDTextBox.Text;
            string vcode = VideoCodeTextBox.Text;
            string issuedate = IssueDateTimePicker.Text;
            string duedate = DueDateTimePicker.Text;
            string remarks = RemarksTextBox.Text;

            // create LINQ Query with CustomerIDTextBox, VideoCodeTextBox, IssueDateTimePicker, DueDateTimePicker

            // instantiate context
            DafestyEntities context = new DafestyEntities();

            // Since you're not displaying information, you don't need a query obj

            // create new tran
            IssueTran t = new IssueTran();
            t.CustomerID = cid;
            t.VideoCode = Convert.ToInt16(vcode);
            t.DateIssue = Convert.ToDateTime(issuedate);
            t.DateDue = Convert.ToDateTime(duedate);
            t.Remarks = remarks;
            t.RentalStatus = "in";

            context.IssueTrans.Add(t);
            context.SaveChanges();

            MessageBox.Show("Issue Submitted");
        }
    }
}
