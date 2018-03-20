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
    public partial class Q5 : Form
    {
        string vc, mvt, gr, rc;
        DafestyEntities context;
        List<Movie> mv;
        int current;

        public Q5()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            context = new DafestyEntities();
            // load all entries into a variable?
            mv = context.Movies.ToList();

            toolStripStatusLabel1.Text = "Movies loaded.";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            RetrieveTextBoxes();

            // check if all fields populated
            if (vc != "" &&
                mvt != "" &&
                gr != "" &&
                rc != "")
            {
                // update the corresponding Movie object
                Movie movObj = mv.Where(x => x.VideoCode == Convert.ToInt16(vc)).First();

                movObj.MovieTitle = mvt;
                movObj.Genre = gr;
                movObj.RentalCost = Convert.ToSingle(rc);

                context.SaveChanges();
                toolStripStatusLabel1.Text = "Video ID " + vc + " updated.";
            }
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            RetrieveTextBoxes();

            // check if all fields populated
            if (vc != "" &&
                mvt != "" &&
                gr != "" &&
                rc != "")
            {
                // create a new Movie
                Movie mvObj = new Movie();

                mvObj.VideoCode = Convert.ToInt16(vc);
                mvObj.MovieTitle = mvt;
                mvObj.Genre = gr;
                mvObj.RentalCost = Convert.ToSingle(rc);

                context.Movies.Add(mvObj);
                context.SaveChanges();
                toolStripStatusLabel1.Text = "Video ID " + vc + " inserted.";
            }
            else
            {
                string msg = "Please enter";
                if (vc == "")
                {
                    // append to msg
                    msg += " Video Code";
                }
                else if (mvt == "")
                {
                    // append to msg
                    msg += " Movie Title";
                }
                else if (gr == "")
                {
                    // append to msg.
                    msg += " Genre";
                }
                else if (rc == "")
                {
                    // append to msg.
                    msg += "Rental Cost ";
                }
                toolStripStatusLabel1.Text = msg + ".";
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RetrieveTextBoxes();

            // check if all fields populated
            if (vc != "")
            {
                // create a new Movie
                Movie movObj = mv.Where(x => x.VideoCode == Convert.ToInt16(vc)).First();

                context.Movies.Remove(movObj);
                context.SaveChanges();
                toolStripStatusLabel1.Text = "Video ID " + vc + " deleted.";
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a Video Code.";
            }
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {
            DirButton_Click("prev");
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            DirButton_Click("next");
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            // go to the first index of mv
            // FillTextBoxes(mov)
            FillTextBoxes(mv[0]);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            // go to the last index of mv
            // FillTextBoxes(mov)
            FillTextBoxes(mv[mv.Count - 1]);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text != "")
            {
                // get Movie from FindTextBox
                Movie foundMovie = mv.Find(x => x.VideoCode == Convert.ToInt16(FindTextBox.Text));
                if (foundMovie != null)
                {
                    FillTextBoxes(foundMovie);
                    toolStripStatusLabel1.Text = "Video Code " + FindTextBox.Text + " found.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Video Code " + FindTextBox.Text + " not found.";
                }

            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter a Video Code.";
            }
        }

        private void DirButton_Click(string direction)
        {
            RetrieveTextBoxes();
            // if video code text box not blank
            if (vc != "")
            {
                // find the index of the current video code
                current = Convert.ToInt32(mv.FindIndex(x => x.VideoCode == Convert.ToInt16(vc)));
                // decrement index by one
                if (direction == "prev")
                {
                    if (current == 0) // first item
                    {
                        toolStripStatusLabel1.Text = "First item reached.";
                    }
                    else
                    {
                        current--;
                        // load the details of the new index
                        Movie newMov = mv.ElementAt(current);
                        FillTextBoxes(newMov);
                        toolStripStatusLabel1.Text = "Item: " + current;
                    }
                }
                else // direction == "next" 
                {
                    if (current == mv.Count - 1) // last item
                    {
                        toolStripStatusLabel1.Text = "Last item reached.";
                    }
                    else
                    {
                        current++;
                        // load the details of the new index
                        Movie newMov = mv.ElementAt(current);
                        FillTextBoxes(newMov);
                        toolStripStatusLabel1.Text = "Item: " + current;
                    }
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Please enter Video Code.";
            }
        }

        private void FillTextBoxes(Movie mov)
        {
            VideoCodeTextBox.Text = mov.VideoCode.ToString();
            MovieTitleTextBox.Text = mov.MovieTitle.ToString();
            GenreTextBox.Text = mov.Genre.ToString();
            RentalCostTextBox.Text = mov.RentalCost.ToString();
        }

        private void RetrieveTextBoxes()
        {
            vc = VideoCodeTextBox.Text;
            mvt = MovieTitleTextBox.Text;
            gr = GenreTextBox.Text;
            rc = RentalCostTextBox.Text;
        }
    }
}
