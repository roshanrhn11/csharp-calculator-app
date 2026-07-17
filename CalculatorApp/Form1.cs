using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        string historyText = ""; 
        string currentInput = "0"; 

        public Form1()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (string.IsNullOrEmpty(historyText))
            {
                txtDisplay.Text = currentInput;
            }
            else
            {
            
                txtDisplay.Text = historyText + Environment.NewLine + currentInput;
            }
        }

        private void button4_Click(object sender, EventArgs e) { }
        private void button14_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }


        private void button_Click(object sender, EventArgs e)
        {
            if ((currentInput == "0") || (isOperationPerformed))
                currentInput = "";

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!currentInput.Contains("."))
                    currentInput = currentInput + button.Text;
            }
            else
            {
               
                currentInput = currentInput + button.Text;
            }

            UpdateDisplay();
        }


        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            if (currentInput.Contains("+") || currentInput.Contains("-") || currentInput.Contains("*") || currentInput.Contains("/"))
            {
                currentInput = currentInput.Substring(0, currentInput.Length - 2);
            }
            else
            {
                resultValue = double.Parse(currentInput);
            }

            operationPerformed = button.Text;

           
            currentInput = resultValue + " " + operationPerformed + " ";
            isOperationPerformed = false;
            UpdateDisplay();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            currentInput = "0";
            resultValue = 0;
            operationPerformed = "";
            historyText = "";
            UpdateDisplay();
        }

 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            historyText = txtDisplay.Text + " =";

           
            string[] parts = currentInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3) return; 

            double secondOperand = double.Parse(parts[2]);

            switch (operationPerformed)
            {
                case "+":
                    currentInput = (resultValue + secondOperand).ToString();
                    break;
                case "-":
                    currentInput = (resultValue - secondOperand).ToString();
                    break;
                case "*":
                    currentInput = (resultValue * secondOperand).ToString();
                    break;
                case "/":
                    currentInput = (resultValue / secondOperand).ToString();
                    break;
            }


            resultValue = double.Parse(currentInput);
            historyText = "Ans = " + resultValue;
            operationPerformed = "";
            isOperationPerformed = true;

            UpdateDisplay();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }
    }
}