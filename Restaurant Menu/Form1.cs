using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _10_2
{
    public partial class Form1 : Form
    {
        // Global variables used within methods //
        double maincourse = new double();
        double addon = new double();
        double subtotal = new double();
        double tax = new double();
        double total = new double();
        double newTotal = new double();

        // List used to add each item user selects //
        List<string> orderItems = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Calls calculations method upon clicked //
        private void button1_Click(object sender, EventArgs e)
        {
            calculations();
        }

        // When radioButton3 (Hamburger) is checked, the text of the groupbox and checkboxes are changed //
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAddOnItems.Text = "Add-on Item($0.75 each)";
            checkBox1.Text = "Lettuce, tomato and onions";
            checkBox2.Text = "Ketchup, mustard and mayo";
            checkBox3.Text = "French fries";

            clearAddOns();
        }

        // When radioButton2 (Pizza) is checked, the text of the groupbox and checkboxes are changed //
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAddOnItems.Text = "Add-on Item ($0.50 each)";
            checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";

            clearAddOns();
        }

        // When radioButton3 (Salad) is checked, the text of the groupbox and checkboxes are changed //
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAddOnItems.Text = "Add-on Item ($0.25 each)";
            checkBox1.Text = "Croutons";
            checkBox2.Text = "Bacon bits";
            checkBox3.Text = "Bread sticks";

            clearAddOns();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals(); //Clears totals check checkbox state has changed
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals(); //Clears totals check checkbox state has changed
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            clearTotals(); //Clears totals check checkbox state has changed
        }

        // Clears labels when called //
        private void clearTotals()
        {
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblOrderTotal.Text = "";
        }

        // Clears checkboxes when called (addons) //
        private void clearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        // Closes program upon click //
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculations()
        {
            // Checks which radio buttons or checkboxes are selected than assigns prices for main courses and addons //
            if (radioButtonHamburger.Checked)
            {
                maincourse = 6.95;
                addon = 0.75;

                orderItems.Add("Hamburger"); //Adds radio button name to list
            }

            else if (radioButtonPizza.Checked)
            {
                maincourse = 5.95;
                addon = 0.50;

                orderItems.Add("Pizza"); //Adds radio button name to list
            }

            else if (radioButtonSalad.Checked)
            {
                maincourse = 4.95;
                addon = 0.25;

                orderItems.Add("Salad"); //Adds radio button name to list
            }

            subtotal = maincourse;

            if (checkBox1.Checked)
            {
                subtotal = subtotal + addon;

                orderItems.Add("  -" + checkBox1.Text); //Adds checkbox name to list
            }

            if (checkBox2.Checked)
            {
                subtotal = subtotal + addon;

                orderItems.Add("  -" + checkBox2.Text); //Adds checkbox name to list
            }

            if (checkBox3.Checked)
            {
                subtotal = subtotal + addon;

                orderItems.Add("  -" + checkBox3.Text); //Adds checkbox name to list
            }

            // This calculates the tax and total (newTotal variable is used to allow  the user to select multiple items and calculate the entire total)
            tax = subtotal * .0775;
            total = tax + subtotal;
            newTotal += total;
            
            // Converts and prints the subtotal, tax, and order total to the labels //
            lblSubtotal.Text = subtotal.ToString("$#.##");
            lblTax.Text = tax.ToString(("$#.##"));
            lblOrderTotal.Text = newTotal.ToString("$#.##");
        }
        // This button adds all the items in the list (orderItems) to the listbox and displays them
        private void button2_Click(object sender, EventArgs e)
        {
            // Add every
            foreach (string item in orderItems)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
        // This clears all the totals, lists, and changes checkbox states back to false (Hamburger is set to default) //
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been created!");
            tax = 0;
            total = 0;
            newTotal = 0;
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblOrderTotal.Text = "";
            orderItems.Clear();
            listBox1.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButtonHamburger.Checked = true;
        }
    }
}
