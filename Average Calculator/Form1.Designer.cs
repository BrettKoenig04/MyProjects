namespace Project_8_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxScore = new System.Windows.Forms.TextBox();
            this.txtBoxScoreTotal = new System.Windows.Forms.TextBox();
            this.txtBoxScoreCount = new System.Windows.Forms.TextBox();
            this.txtBoxAverage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplay2 = new System.Windows.Forms.Button();
            this.lblLowestScore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average:";
            // 
            // txtBoxScore
            // 
            this.txtBoxScore.Location = new System.Drawing.Point(90, 23);
            this.txtBoxScore.Name = "txtBoxScore";
            this.txtBoxScore.Size = new System.Drawing.Size(100, 20);
            this.txtBoxScore.TabIndex = 1;
            // 
            // txtBoxScoreTotal
            // 
            this.txtBoxScoreTotal.Location = new System.Drawing.Point(90, 53);
            this.txtBoxScoreTotal.Name = "txtBoxScoreTotal";
            this.txtBoxScoreTotal.ReadOnly = true;
            this.txtBoxScoreTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxScoreTotal.TabIndex = 0;
            this.txtBoxScoreTotal.TabStop = false;
            // 
            // txtBoxScoreCount
            // 
            this.txtBoxScoreCount.Location = new System.Drawing.Point(90, 89);
            this.txtBoxScoreCount.Name = "txtBoxScoreCount";
            this.txtBoxScoreCount.ReadOnly = true;
            this.txtBoxScoreCount.Size = new System.Drawing.Size(100, 20);
            this.txtBoxScoreCount.TabIndex = 0;
            this.txtBoxScoreCount.TabStop = false;
            // 
            // txtBoxAverage
            // 
            this.txtBoxAverage.Location = new System.Drawing.Point(90, 122);
            this.txtBoxAverage.Name = "txtBoxAverage";
            this.txtBoxAverage.ReadOnly = true;
            this.txtBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAverage.TabIndex = 0;
            this.txtBoxAverage.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 160);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(128, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display scores (Unsorted)";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Scores";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(152, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplay2
            // 
            this.btnDisplay2.Location = new System.Drawing.Point(152, 160);
            this.btnDisplay2.Name = "btnDisplay2";
            this.btnDisplay2.Size = new System.Drawing.Size(128, 23);
            this.btnDisplay2.TabIndex = 4;
            this.btnDisplay2.Text = "Display scores (Sorted)";
            this.btnDisplay2.UseVisualStyleBackColor = true;
            this.btnDisplay2.Click += new System.EventHandler(this.btnDisplay2_Click);
            // 
            // lblLowestScore
            // 
            this.lblLowestScore.AutoSize = true;
            this.lblLowestScore.Location = new System.Drawing.Point(15, 229);
            this.lblLowestScore.Name = "lblLowestScore";
            this.lblLowestScore.Size = new System.Drawing.Size(78, 13);
            this.lblLowestScore.TabIndex = 7;
            this.lblLowestScore.Text = "Lowest Score: ";
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Location = new System.Drawing.Point(15, 259);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(80, 13);
            this.lblHighestScore.TabIndex = 8;
            this.lblHighestScore.Text = "Highest Score: ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(289, 281);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.lblLowestScore);
            this.Controls.Add(this.btnDisplay2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAverage);
            this.Controls.Add(this.txtBoxScoreCount);
            this.Controls.Add(this.txtBoxScoreTotal);
            this.Controls.Add(this.txtBoxScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxScore;
        private System.Windows.Forms.TextBox txtBoxScoreTotal;
        private System.Windows.Forms.TextBox txtBoxScoreCount;
        private System.Windows.Forms.TextBox txtBoxAverage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplay2;
        private System.Windows.Forms.Label lblLowestScore;
        private System.Windows.Forms.Label lblHighestScore;
    }
}

