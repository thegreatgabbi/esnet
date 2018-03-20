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
    public partial class Q1_4 : Form
    {
        public Q1_4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieve the movie with code 5 (Nemesis).
        /// </summary>
        private void Ex_4a()
        {
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Movies where x.VideoCode == 5 select x.MovieTitle;
            label1.Text = q.First().ToString();

        }
        /// <summary>
        /// Update the rental cost of this movie to $1.80.
        /// </summary>
        private void Ex_4b()
        {
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Movies where x.VideoCode == 5 select x;
            Movie m = q.First();
            m.RentalCost = (float)1.80;

            context.SaveChanges();
        }
        /// <summary>
        /// Create a new Movie with id 400, name of the movie is Sully, genere is Drama, Producer is Warner Brothers, rental price is $2.50, Rating is U, number of copies (total stock) is 4.
        /// </summary>
        private void Ex_4c()
        {
            DafestyEntities context = new DafestyEntities();
            // create new movie object
            Movie m = new Movie();
            m.VideoCode = 400;
            m.MovieTitle = "Sully";
            m.Genre = "Drama";
            m.ProducerID = "Warner";
            m.RentalCost = (float)2.50;
            m.Rating = "U";
            m.TotalStock = 4;
            // add to context
            context.Movies.Add(m);
            // Save Changes
            context.SaveChanges();
        }
        /// <summary>
        /// Modify the Producer of Demolition Man (code 4) from Universal to Pixar. Alter the association from Movie object (1-side).
        /// </summary>
        private void Ex_4d()
        {
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Movies where x.VideoCode == 4 select x;
            Movie mv = q.First();

            mv.ProducerID = "Pixar";

            context.SaveChanges();
        }
        /// <summary>
        /// Modify the Producer of Die Hard 2 (code 11) from Pixar to Warner. Alter the association from the Producer side (n-side).
        /// </summary>
        private void Ex_4e()
        {
            DafestyEntities context = new DafestyEntities();
            Movie m = context.Movies.Where(x => x.VideoCode == 11).First();
            Producer p = context.Producers.Where(x => x.ProducerID == "Warner").First();
            p.Movies.Add(m);

            context.SaveChanges();
        }
        /// <summary>
        /// Delete the movie with code 400.
        /// </summary>
        private void Ex_4f()
        {
            DafestyEntities context = new DafestyEntities();
            Movie m = context.Movies.Where(x => x.VideoCode == 400).First();
            context.Movies.Remove(m);

            context.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "4a":
                    Ex_4a();
                    break;
                case "4b":
                    Ex_4b();
                    break;
                case "4c":
                    Ex_4c();
                    break;
                case "4d":
                    Ex_4d();
                    break;
                case "4e":
                    Ex_4e();
                    break;
                case "4f":
                    Ex_4f();
                    break;
                default:
                    break;
            }
        }
    }
}
