using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ef_workshop
{
    public partial class Form1 : Form
    {
        DafestyEntities context;
        public Form1()
        {
            InitializeComponent();
            context = new DafestyEntities();
        }
        /// <summary>
        /// Retrieve all data from the Movies table with a LINQ query.
        /// </summary>
        private void Q1_LINQ()
        {
            //write LINQ Query
            var q = from x in context.Movies select x;

            BindingList<Movie> lst = new BindingList<Movie>(q.ToList());
            dataGridView1.DataSource = lst;
            dataGridView1.Columns["RentalPrice"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["RentalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        /// <summary>
        /// Retrieve all data from the Movies table with a Lambda expression.
        /// </summary>
        private void Q1_Lambda()
        {
            //write lambda expression
            List<Movie> lst = context.Movies.ToList();
            dataGridView1.DataSource = lst;
            dataGridView1.Columns["RentalPrice"].DefaultCellStyle.Format = "c";
            dataGridView1.Columns["RentalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        /// <summary>
        /// Retrieve all Movies and display the data in Ascending order of Movie Title with a LINQ query.
        /// </summary>
        private void Q2_LINQ()
        {
            //write LINQ Query
            var q = from x in context.Movies orderby x.MovieTitle ascending select x;

            List<Movie> lst = q.ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all Movies and display the data in Ascending order of Movie Title.
        /// </summary>
        private void Q2_Lambda()
        {
            //write lambda expression
            List<Movie> lst = context.Movies.OrderBy(x => x.MovieTitle).ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all Movies and display the data in Descending order of Rental Price with a LINQ query.
        /// </summary>
        private void Q3_LINQ()
        {
            //write LINQ Query
            var q = from x in context.Movies orderby x.RentalPrice descending select x;

            List<Movie> lst = q.ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all Movies and display the data in Descending order of Rental Price.
        /// </summary>
        private void Q3_Lambda()
        {
            //write lambda expression
            List<Movie> lst = context.Movies.OrderByDescending(x => x.RentalPrice).ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all R rated movies with a LINQ query.
        /// </summary>
        private void Q4_LINQ()
        {
            //write LINQ Query
            var q = from x in context.Movies where x.Rating == "R" select x;

            List<Movie> lst = q.ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all R rated movies with a Lambda expression.
        /// </summary>
        private void Q4_Lambda()
        {
            //write lambda expression
            List<Movie> lst = context.Movies.Where(x => x.Rating == "R").ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all Science Fiction movies produced by Warner with a LINQ query.
        /// </summary>
        private void Q5_LINQ()
        {
            //write LINQ Query
            var q = from x in context.Movies where x.MovieType == "Sci-fi" && x.ProducerID == "Warner" select x;

            List<Movie> lst = q.ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Retrieve all Science Fiction movies produced by Warner with a Lambda expression.
        /// </summary>
        private void Q5_Lambda()
        {
            //write lambda expression
            List<Movie> lst = context.Movies.Where(x => x.MovieType == "Sci-fi" && x.ProducerID == "Warner").ToList();
            dataGridView1.DataSource = lst;
        }
        /// <summary>
        /// Get the number of Action Movies in the Store with a LINQ query.
        /// </summary>
        private void Q6_LINQ()
        {
            //write LINQ Query
            int numAction = (from x in context.Movies where x.MovieType == "Action" select x).Count();

            label1.Text = numAction.ToString();
        }
        /// <summary>
        /// Get the number of Action Movies in the Store with a Lambda expression.
        /// </summary>
        private void Q6_Lambda()
        {
            //write lambda expression
            int numAction = context.Movies.Where(x => x.MovieType == "Action").Count();
            dataGridView1.DataSource = numAction;
        }
        /// <summary>
        /// Get the number of copies procured for Action movies (number of copies would mean the total stock of all action movies) with a LINQ query.
        /// </summary>
        private void Q7_LINQ()
        {
            //write LINQ Query
            int totalStock = (from x in context.Movies where x.MovieType == "Action" select (int)x.TotalStock).Sum();

            label1.Text = totalStock.ToString();
        }
        /// <summary>
        /// Get the number of copies procured for Action movies (number of copies would mean the total stock of all action movies) with a Lambda expression.
        /// </summary>
        private void Q7_Lambda()
        {
            //write lambda expression
            int totalStock = context.Movies.Where(x => x.MovieType == "Action").Sum(y => (int)y.TotalStock);
            label1.Text = totalStock.ToString();
        }
        /// <summary>
        /// Find the average price of Comedy movies with a LINQ query.
        /// </summary>
        private void Q8_LINQ()
        {
            //write LINQ Query
            var q = (from x in context.Movies where x.MovieType == "Comedy" select x.RentalPrice).Average();

            label1.Text = String.Format("{0:C}", q);
        }
        /// <summary>
        /// Find the average price of Comedy movies with a Lambda expression.
        /// </summary>
        private void Q8_Lambda()
        {
            //write lambda expression
            float? avgRental = context.Movies.Where(x => x.MovieType == "Comedy").Average(x => x.RentalPrice);

            label1.Text = String.Format("{0:C}", avgRental);
        }
        /// <summary>
        /// Rewrite exercise 4 but you should display only the Video Code, Movie Title and Rental Price with LINQ query.
        /// </summary>
        private void Q9_LINQ()
        {
            // write LNQ Query
            var q = from x in context.Movies where x.Rating == "R" select new { x.VideoCode, x.MovieTitle, x.RentalPrice };
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Rewrite exercise 4 but you should display only the Video Code, Movie Title and Rental Price with a Lambda expression.
        /// </summary>
        private void Q9_Lambda()
        {
            // write LNQ Query
            var q = context.Movies.Where(x => x.Rating == "R").Select(x => new { x.VideoCode, x.MovieTitle, x.RentalPrice });
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        ///  Rewrite exercise 7 to display the number of copies of movies held in each category. (this would need group by) using LINQ query.
        /// </summary>
        private void Q10_LINQ()
        {
            // write LINQ Query
            var q = from x in context.Movies
                    group x by x.MovieType into g
                    select new { MovieType = g.Key, Number = g.Sum(y => y.TotalStock)};
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Rewrite exercise 7 to display the number of copies of movies held in each category. (this would need group by) using Lambda expression.
        /// </summary>
        private void Q10_Lambda()
        {
            var q = context.Movies.GroupBy(x => x.MovieType).Select(g => new { MovieType = g.Key, Number = g.Sum(y => y.TotalStock) });
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Retrieve Movie with ID 5 and display the Movie Title, Rating and Producer Name using LINQ query.
        /// </summary>
        private void Q11_LINQ()
        {
            // write LINQ query
            var q = from x in context.Movies where x.VideoCode == 5 select new { x.MovieTitle, x.Rating, x.Producer.ProducerName };
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Retrieve Movie with ID 5 and display the Movie Title, Rating and Producer Name using Lambda expression.
        /// </summary>
        private void Q11_Lambda()
        {
            var q = context.Movies.Where(x => x.VideoCode == 5).Select(y => new { y.MovieTitle, y.Rating, y.Producer.ProducerName });
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Retrieve All movies produced by Walt Disney Studios. You should display the Producer Name, Movie Title and Movie Type with a LINQ Query.
        /// </summary>
        private void Q12_LINQ()
        {
            var q = from x in context.Movies where x.Producer.ProducerName == "Walt Disney Studio" select new { x.Producer.ProducerName, x.MovieTitle, x.MovieType };
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Retrieve All movies produced by Walt Disney Studios. You should display the Producer Name, Movie Title and Movie Type with a Lambda expression.
        /// </summary>
        private void Q12_Lambda()
        {
            var q = context.Movies.Where(x => x.Producer.ProducerName == "Walt Disney Studio").Select(x => new { x.Producer.ProducerName, x.MovieTitle, x.MovieType });
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Retrieve all movies and display the MovieTitle, Rating, MovieType and Producer Name in a Grid using a LINQ Query.
        /// </summary>
        private void Q13_LINQ()
        {
            var q = from x in context.Movies select new { x.MovieTitle, x.Rating, x.MovieType, x.Producer.ProducerName };
            dataGridView1.DataSource = q.ToList();
        }
        /// <summary>
        /// Retrieve all movies and display the MovieTitle, Rating, MovieType and Producer Name in a Grid using a Lambda expression.
        /// </summary>
        private void Q13_Lambda()
        {
            var q = context.Movies.Select(x => new { x.MovieTitle, x.Rating, x.MovieType, x.Producer.ProducerName });
            dataGridView1.DataSource = q.ToList();
        }
        private void LINQQueryButton_Click(object sender, EventArgs e)
        {

            switch (ExerciseComboBox.Text)
            {
                case "1":
                    Q1_LINQ();
                    break;
                case "2":
                    Q2_LINQ();
                    break;
                case "3":
                    Q3_LINQ();
                    break;
                case "4":
                    Q4_LINQ();
                    break;
                case "5":
                    Q5_LINQ();
                    break;
                case "6":
                    Q6_LINQ();
                    break;
                case "7":
                    Q7_LINQ();
                    break;
                case "8":
                    Q8_LINQ();
                    break;
                case "9":
                    Q9_LINQ();
                    break;
                case "10":
                    Q10_LINQ();
                    break;
                case "11":
                    Q11_LINQ();
                    break;
                case "12":
                    Q12_LINQ();
                    break;
                case "13":
                    Q13_LINQ();
                    break;
                default:
                    MessageBox.Show("Please select an exercise number.");
                    break;
            }
            if (ExerciseComboBox.Text != "")
            {
                toolStripStatusLabel1.Text = "Question " + ExerciseComboBox.Text + " (LINQ Query) selected.";
            }
        }
        private void LambdaQueryButton_Click(object sender, EventArgs e)
        {
            switch (ExerciseComboBox.Text)
            {
                case "1":
                    Q1_Lambda();
                    break;
                case "2":
                    Q2_Lambda();
                    break;
                case "3":
                    Q3_Lambda();
                    break;
                case "4":
                    Q4_Lambda();
                    break;
                case "5":
                    Q5_Lambda();
                    break;
                case "6":
                    Q6_Lambda();
                    break;
                case "7":
                    Q7_Lambda();
                    break;
                case "8":
                    Q8_Lambda();
                    break;
                case "9":
                    Q9_Lambda();
                    break;
                case "10":
                    Q10_Lambda();
                    break;
                case "11":
                    Q11_Lambda();
                    break;
                case "12":
                    Q12_Lambda();
                    break;
                case "13":
                    Q13_Lambda();
                    break;
                default:
                    MessageBox.Show("Please select an exercise number.");
                    break;
            }
            if (ExerciseComboBox.Text != "")
            {
                toolStripStatusLabel1.Text = "Question " + ExerciseComboBox.Text + " (Lambda function) selected.";
            }
        }
    }
}
