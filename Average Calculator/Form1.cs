using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project_8_1
{
    public partial class Form1 : Form
    {

        List<int> scores = new List<int>();
        int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData()) //If none of the methods (IsPresent,IsInteger,IsWithinRange) return false, the program will try to convert the users input in the fields and send them to the calculate method.
                {
                    //Get input
                    int newScore = int.Parse(txtBoxScore.Text);

                    //Update list
                    scores.Add(newScore);

                    //Calculate and update total textbox
                    total += newScore;
                    txtBoxScoreTotal.Text = total.ToString();

                    //Calculate and update count textbox
                    txtBoxScoreCount.Text = scores.Count.ToString();

                    //Calculate and update average textbox
                    int sum = total / scores.Count();
                    txtBoxAverage.Text = sum.ToString();

                    //Clear score textbox after clicking "add" button
                    txtBoxScore.Text = string.Empty;
                    txtBoxScore.Focus(); //Resets button focus in case we want to add another number

                    //Gets lowest score then prints in label
                    int lowestScore = scores.Min();
                    lblLowestScore.Text = "Lowest Score: " + Convert.ToString(lowestScore);

                    //Gets highest score then prints in label
                    int highestScore = scores.Max();
                    lblHighestScore.Text = "Highest Score: " + Convert.ToString(highestScore);
                }
            }

            catch (Exception ex) //Generic exception and info
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        public bool IsValidData() //This returns the boolean values of the following methods (IsPresent,IsInteger,IsWithinRange) and shows a messagebox if any of them are false
        {
            return
                IsPresent(txtBoxScore, "Score") &&
                IsInteger(txtBoxScore, "Score") &&
                IsWithinRange(txtBoxScore, "Score", 0, 100);
        }

        public bool IsPresent(TextBox textBox, string name) //Checks if any textbox is empty
        {
            if (txtBoxScore.Text == "")
            {
                MessageBox.Show(name + " is a required field, please enter a valid response.", "Entry Error");
                txtBoxScore.Focus(); //Focusses on textbox where error has occured
                return false;
            }
            return true;
        }

        public bool IsInteger(TextBox textBox, string name) //Checks if users input is of the Integer type
        {
            try
            {
                Convert.ToInt64(txtBoxScore.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a integer value, please enter a valid response.", "Entry Error");
                txtBoxScore.Focus(); //Focusses on textbox where error has occured
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max) //Checks if users input within range specified below
        {
            decimal number = Convert.ToDecimal(txtBoxScore.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                txtBoxScore.Focus(); //Focusses on textbox where error has occured
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e) //Clears all input/result fields upon click event
        {
            scores.Clear();
            total = 0;

            txtBoxScore.Text = "";
            txtBoxScoreTotal.Text = "";
            txtBoxScoreCount.Text = "";
            txtBoxAverage.Text = "";

            lblLowestScore.Text = "Lowest Score: ";
            lblHighestScore.Text = "Highest Score: ";
        }

        private void btnDisplay_Click(object sender, EventArgs e) //Displays unsorted scores upon click
        {
            string scoresString = "";
            foreach (int i in scores)
                scoresString += i.ToString() + "\n";
            MessageBox.Show(scoresString, "Unsorted Scores");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay2_Click(object sender, EventArgs e) //Displays sorted scores upon click
        {
            List<int> scoresCopy = scores.ToList(); //creates copy of original list so you can still view the unsorted one and it doesn't save over the original list
            scoresCopy.Sort();

            string scoresString = "";
            foreach (int i in scoresCopy)
                scoresString += i.ToString() + "\n";
            MessageBox.Show(scoresString, "Sorted Scores");
        }
    }
}
