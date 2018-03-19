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
        public Form1()
        {
            InitializeComponent();
        }
        private void Q1_LINQ()
        {
            MessageBox.Show("Q1 LINQ");
        }

        private void LINQQueryButton_Click(object sender, EventArgs e)
        {
            switch (ExerciseComboBox.SelectedItem.ToString())
            {
                case "1":
                    Q1_LINQ();
                    break;
                default:
                    MessageBox.Show("Please select an exercise number.");
                    break;
            }
        }
    }
}
