namespace _10_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMainCourse = new System.Windows.Forms.GroupBox();
            this.radioButtonSalad = new System.Windows.Forms.RadioButton();
            this.radioButtonPizza = new System.Windows.Forms.RadioButton();
            this.radioButtonHamburger = new System.Windows.Forms.RadioButton();
            this.groupBoxAddOnItems = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxOrderTotal = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBoxMainCourse.SuspendLayout();
            this.groupBoxAddOnItems.SuspendLayout();
            this.groupBoxOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMainCourse
            // 
            this.groupBoxMainCourse.Controls.Add(this.radioButtonSalad);
            this.groupBoxMainCourse.Controls.Add(this.radioButtonPizza);
            this.groupBoxMainCourse.Controls.Add(this.radioButtonHamburger);
            this.groupBoxMainCourse.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMainCourse.Name = "groupBoxMainCourse";
            this.groupBoxMainCourse.Size = new System.Drawing.Size(133, 113);
            this.groupBoxMainCourse.TabIndex = 0;
            this.groupBoxMainCourse.TabStop = false;
            this.groupBoxMainCourse.Text = "Main course";
            // 
            // radioButtonSalad
            // 
            this.radioButtonSalad.AutoSize = true;
            this.radioButtonSalad.Location = new System.Drawing.Point(6, 90);
            this.radioButtonSalad.Name = "radioButtonSalad";
            this.radioButtonSalad.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSalad.TabIndex = 2;
            this.radioButtonSalad.TabStop = true;
            this.radioButtonSalad.Text = "Salad - $4.95";
            this.radioButtonSalad.UseVisualStyleBackColor = true;
            this.radioButtonSalad.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonPizza
            // 
            this.radioButtonPizza.AutoSize = true;
            this.radioButtonPizza.Location = new System.Drawing.Point(6, 51);
            this.radioButtonPizza.Name = "radioButtonPizza";
            this.radioButtonPizza.Size = new System.Drawing.Size(86, 17);
            this.radioButtonPizza.TabIndex = 1;
            this.radioButtonPizza.TabStop = true;
            this.radioButtonPizza.Text = "Pizza - $5.95";
            this.radioButtonPizza.UseVisualStyleBackColor = true;
            this.radioButtonPizza.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonHamburger
            // 
            this.radioButtonHamburger.AutoSize = true;
            this.radioButtonHamburger.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHamburger.Name = "radioButtonHamburger";
            this.radioButtonHamburger.Size = new System.Drawing.Size(113, 17);
            this.radioButtonHamburger.TabIndex = 0;
            this.radioButtonHamburger.TabStop = true;
            this.radioButtonHamburger.Text = "Hamburger - $6.95";
            this.radioButtonHamburger.UseVisualStyleBackColor = true;
            this.radioButtonHamburger.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxAddOnItems
            // 
            this.groupBoxAddOnItems.Controls.Add(this.checkBox3);
            this.groupBoxAddOnItems.Controls.Add(this.checkBox2);
            this.groupBoxAddOnItems.Controls.Add(this.checkBox1);
            this.groupBoxAddOnItems.Location = new System.Drawing.Point(160, 12);
            this.groupBoxAddOnItems.Name = "groupBoxAddOnItems";
            this.groupBoxAddOnItems.Size = new System.Drawing.Size(189, 113);
            this.groupBoxAddOnItems.TabIndex = 1;
            this.groupBoxAddOnItems.TabStop = false;
            this.groupBoxAddOnItems.Text = "Add-on items($ .75 each)";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, mustard, and mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce, tomato, and onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxOrderTotal
            // 
            this.groupBoxOrderTotal.Controls.Add(this.lblOrderTotal);
            this.groupBoxOrderTotal.Controls.Add(this.lblTax);
            this.groupBoxOrderTotal.Controls.Add(this.lblSubtotal);
            this.groupBoxOrderTotal.Controls.Add(this.label3);
            this.groupBoxOrderTotal.Controls.Add(this.label2);
            this.groupBoxOrderTotal.Controls.Add(this.label1);
            this.groupBoxOrderTotal.Location = new System.Drawing.Point(12, 131);
            this.groupBoxOrderTotal.Name = "groupBoxOrderTotal";
            this.groupBoxOrderTotal.Size = new System.Drawing.Size(249, 135);
            this.groupBoxOrderTotal.TabIndex = 2;
            this.groupBoxOrderTotal.TabStop = false;
            this.groupBoxOrderTotal.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(80, 103);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(151, 20);
            this.lblOrderTotal.TabIndex = 4;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(80, 65);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(152, 20);
            this.lblTax.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(80, 25);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(152, 20);
            this.lblSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (7.75):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add to Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "View Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(355, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 238);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your order:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Confirm Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 282);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxOrderTotal);
            this.Controls.Add(this.groupBoxAddOnItems);
            this.Controls.Add(this.groupBoxMainCourse);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.groupBoxMainCourse.ResumeLayout(false);
            this.groupBoxMainCourse.PerformLayout();
            this.groupBoxAddOnItems.ResumeLayout(false);
            this.groupBoxAddOnItems.PerformLayout();
            this.groupBoxOrderTotal.ResumeLayout(false);
            this.groupBoxOrderTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMainCourse;
        private System.Windows.Forms.GroupBox groupBoxAddOnItems;
        private System.Windows.Forms.GroupBox groupBoxOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSalad;
        private System.Windows.Forms.RadioButton radioButtonPizza;
        private System.Windows.Forms.RadioButton radioButtonHamburger;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}

