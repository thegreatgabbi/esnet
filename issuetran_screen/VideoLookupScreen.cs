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
    public partial class VideoLookupScreen : Form
    {
        public IssueTranForm refIssueTran;
        DafestyEntities context;
        public VideoLookupScreen()
        {
            InitializeComponent();
            // linq query
            context = new DafestyEntities();
            var q = from x in context.Movies select x;
            // display in datagridview
            VideoDataGridView.DataSource = q.ToList();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            // get selected index
            int selected = VideoDataGridView.CurrentCell.RowIndex;
            // get the value of VideoCode and MovieTitle from query
            var q = from x in context.Movies select x;
            List<Movie> l = q.ToList();

            // set Form1.CustomerIDTextBox.Text = selected row
            refIssueTran.VCode = l[selected].VideoCode.ToString();
            refIssueTran.MvTitle = l[selected].MovieTitle.ToString();

            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
