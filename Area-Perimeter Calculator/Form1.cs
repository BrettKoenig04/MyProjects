using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateArea_Perimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtLength.Text == "" || txtWidth.Text == "")             //Checks if input fields are empty
            {
                MessageBox.Show("Please enter a valid number");          //Error message if they are empty
            }

            float length = Convert.ToSingle(txtLength.Text);             //Creates variable and converts textbox field to float (Length)
            float width = Convert.ToSingle(txtWidth.Text);              //Creates variable and converts textbox field to float (Width)

            float areaResult = width * length;                           //Calculates for Area (using length/width variables)
            float perimeterResult = 2 * width + 2 * length;              //Calculates for Perimeter (using length/width variables)

            lblAreaResult.Text = Convert.ToString(areaResult);           //Prints to Area label
            lblPerimeterResult.Text = Convert.ToString(perimeterResult); //Prints to Perimeter label
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                                                //Closes when button clicked
        }

        private void clearFutureValue(object sender, EventArgs e) //Method to clear results after user inputs new data
        {
            lblAreaResult.Text = "";
            lblPerimeterResult.Text = "";
        }
    }
}
