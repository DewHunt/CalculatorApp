namespace CalculatorApp
{
    partial class calculatorUI
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberLebel = new System.Windows.Forms.Label();
            this.secondNumberLebel = new System.Windows.Forms.Label();
            this.resultLebel = new System.Windows.Forms.Label();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divitionButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(290, 33);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(201, 20);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(290, 60);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(201, 20);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(290, 86);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(201, 20);
            this.resultTextBox.TabIndex = 2;
            // 
            // firstNumberLebel
            // 
            this.firstNumberLebel.AutoSize = true;
            this.firstNumberLebel.Location = new System.Drawing.Point(154, 36);
            this.firstNumberLebel.Name = "firstNumberLebel";
            this.firstNumberLebel.Size = new System.Drawing.Size(66, 13);
            this.firstNumberLebel.TabIndex = 3;
            this.firstNumberLebel.Text = "First Number";
            this.firstNumberLebel.UseWaitCursor = true;
            // 
            // secondNumberLebel
            // 
            this.secondNumberLebel.AutoSize = true;
            this.secondNumberLebel.Location = new System.Drawing.Point(154, 63);
            this.secondNumberLebel.Name = "secondNumberLebel";
            this.secondNumberLebel.Size = new System.Drawing.Size(84, 13);
            this.secondNumberLebel.TabIndex = 4;
            this.secondNumberLebel.Text = "Second Number";
            // 
            // resultLebel
            // 
            this.resultLebel.AutoSize = true;
            this.resultLebel.Location = new System.Drawing.Point(154, 89);
            this.resultLebel.Name = "resultLebel";
            this.resultLebel.Size = new System.Drawing.Size(37, 13);
            this.resultLebel.TabIndex = 5;
            this.resultLebel.Text = "Result";
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(157, 132);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(75, 23);
            this.additionButton.TabIndex = 6;
            this.additionButton.Text = "Addition";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(243, 132);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(75, 23);
            this.subtractionButton.TabIndex = 7;
            this.subtractionButton.Text = "Subtraction";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(328, 131);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(79, 23);
            this.multiplicationButton.TabIndex = 8;
            this.multiplicationButton.Text = "Multiplication";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divitionButton
            // 
            this.divitionButton.Location = new System.Drawing.Point(416, 131);
            this.divitionButton.Name = "divitionButton";
            this.divitionButton.Size = new System.Drawing.Size(75, 23);
            this.divitionButton.TabIndex = 9;
            this.divitionButton.Text = "Division";
            this.divitionButton.UseVisualStyleBackColor = true;
            this.divitionButton.Click += new System.EventHandler(this.divitionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(201, 161);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(372, 161);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 276);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divitionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.resultLebel);
            this.Controls.Add(this.secondNumberLebel);
            this.Controls.Add(this.firstNumberLebel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "calculatorUI";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label firstNumberLebel;
        private System.Windows.Forms.Label secondNumberLebel;
        private System.Windows.Forms.Label resultLebel;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divitionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

