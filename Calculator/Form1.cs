using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        string input = String.Empty;        //String storing user input
        string operand1 = string.Empty;      //String storing first operand
        string operand2 = String.Empty;     //String storing second operand
        string operation;                     //char for operation
        double result = 0.0;                //calculated result



        public Calculator()
        {
            InitializeComponent();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == "+")
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = @"DIV/Zero!";
                }

            }


        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text = input;
        }

        private void Period_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text = input;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.textBox1.Text = "0";

        }

        private void One_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text = input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text = input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text = input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text = input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text = input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text = input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text = input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text = input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text = input;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "-";
            input = string.Empty;

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "+";
            input = string.Empty;

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "*";
            input = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = "/";
            input = string.Empty;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
