using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ef_movies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            dataGridView1.DataSource = context.Movie.ToList();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            // get the entity collection
            DafestyEntities context = new DafestyEntities();

            //short vc = Convert.ToInt16(VideoCodeTextBox.Text.ToString());
            // queries a entity collection! Not the database.
            var q = from x in context.Movie where x.VideoCode == 1 select x;

            var m = q.First();
            MovieTitleLabel.Text = m.MovieTitle;
            
        }

    }
}
