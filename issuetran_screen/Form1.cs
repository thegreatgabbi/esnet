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
    // DONE: Add IssueTran to EDM (Entity Domain Model)
    // DONE: Design IssueTranScreen
    // TODO: Design Customer Lookup Screen
    // TODO: Design Video Lookup Screen
    // DONE: Make Due Date Default to Issue Date + 3 days

    public partial class IssueTranForm : Form
    {
        public IssueTranForm()
        {
            InitializeComponent();
            // Due Date = Issue Date + 3 days
            DueDateTimePicker.Value = IssueDateTimePicker.Value.AddDays(3);
        }
        /// <summary>
        /// Submits the Issue with RentalStatus "in".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string cid = CustomerIDTextBox.Text;
            string vcode = VideoCodeTextBox.Text;
            DateTime issuedate = IssueDateTimePicker.Value;
            DateTime duedate = DueDateTimePicker.Value;
            string remarks = RemarksTextBox.Text;

            // create LINQ Query with CustomerIDTextBox, VideoCodeTextBox, IssueDateTimePicker, DueDateTimePicker

            // instantiate context
            DafestyEntities context = new DafestyEntities();

            // Since you're not displaying information, you don't need a query obj

            // create new tran
            IssueTran t = new IssueTran();
            t.CustomerID = cid;
            t.VideoCode = Convert.ToInt16(vcode);
            t.DateIssue = issuedate;
            t.DateDue = duedate;
            t.Remarks = remarks;
            t.RentalStatus = "in";

            context.IssueTrans.Add(t);
            context.SaveChanges();

            MessageBox.Show("Issue Submitted");
        }
    }
}
