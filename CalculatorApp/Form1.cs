using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class calculatorUI : Form
    {
        public calculatorUI()
        {
            InitializeComponent();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == "" || secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter Number for Addition");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                double result = firstNumber + secondNumber;

                resultTextBox.Text = result.ToString();
            }
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == "" || secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter Number for Subtraction");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                double result = firstNumber - secondNumber;

                resultTextBox.Text = result.ToString();
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == "" || secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter Number for Multiplication");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                double result = firstNumber * secondNumber;

                resultTextBox.Text = result.ToString();
            }
        }

        private void divitionButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text == "" || secondNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter Number for Divition");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                double result = firstNumber / secondNumber;

                resultTextBox.Text = result.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
