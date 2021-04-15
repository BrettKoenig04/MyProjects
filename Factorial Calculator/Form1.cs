using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) //Sets button click event
        {
            /*Long type can store up to 8 bytes, this is why I chose it along with Int64*/
            long userInput = Convert.ToInt64(txtBoxInput.Text); //Converts textbox (txtBoxInput)
            long userInputDuplicate = userInput; //We compare this with the variable "x" for operation (Acts as a constant variable)

            /*For loop ideology*/
            //I chose a backwards approach therefore I don't need to check if "x" would be less then 0 through decrementing

            //Create variable "x" and assigns it a value one 1
            //We check if "x" is less then our duplicate variable (duplicate variable stays constant, only used for testing condition)
            //If x is lower than the users input, we increment x
            //Then we take "userInput" and multiply it by "x" and store it in the variable "userInput" and repeat loop until x is equal to "userInputDuplicate"
            for (long x = 1; x < userInputDuplicate; x++)
            {
                userInput = userInput * x;
            }

            lblResult.Text = userInput.ToString("N0"); //"N0" formats the output with comma's (no decimals)
        }

        private void btnExit_Click(object sender, EventArgs e) //Sets button click event
        {
            this.Close(); //Closes form on click
        }
    }
}
