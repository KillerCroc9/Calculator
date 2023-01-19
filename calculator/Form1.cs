using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        bool IsOperationClicked = false;
        bool IsOperation = false;

        public Form1()
        {
            InitializeComponent();
        }
        static string ReplaceLastLetter(string text, string newLetter)
        {
            string substring = text.Substring(0, text.Length - 1); // ABC -> AB
            return substring + newLetter; // ABD
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text== "Cannot divide by zero")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         

            if (IsOperation == false) {
                equal();
                if (textBox1.Text == "Cannot divide by zero")
                {
                    textBox1.Text = "0";
                }
                FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text += "+";
            Operation = "+";
            IsOperationClicked = true;
                IsOperation = true;
            }
            else
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                FirstNumber = Convert.ToDouble(textBox1.Text);
                
                textBox1.Text += "+";
                Operation = "+";
                IsOperationClicked = true;
                IsOperation = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsOperation == false)
            {
                equal();
                if(textBox1.Text == "Cannot divide by zero")
                {
                    textBox1.Text = "0";
                }
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "-";
                Operation = "-";
                IsOperationClicked = true;
                IsOperation = true;
            }
            else
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                FirstNumber = Convert.ToDouble(textBox1.Text);

                textBox1.Text += "-";
                Operation = "-";
                IsOperationClicked = true;
                IsOperation = true;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (IsOperation == false)
            {
                equal();
                if (textBox1.Text == "Cannot divide by zero")
                {
                    textBox1.Text = "0";
                }
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "*";
                Operation = "*";
                IsOperationClicked = true;
                IsOperation = true;
            }
            else
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                FirstNumber = Convert.ToDouble(textBox1.Text);

                textBox1.Text += "*";
                Operation = "*";
                IsOperationClicked = true;
                IsOperation = true;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; 
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
                IsOperationClicked = false;
                IsOperation = false;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            equal();
        }
        private void equal()
        {
            String SecondNumberString = textBox1.Text;
            if (IsOperationClicked == true && IsOperation ==false)
            {
              
                int indexOperation = SecondNumberString.IndexOf(Operation,1);
                if (indexOperation != -1)
                {
                    double SecondNumber;
                    SecondNumber = 0;
                    double Result;
                    SecondNumberString = SecondNumberString.Substring(indexOperation + 1);

                    if (SecondNumberString != "" && SecondNumberString != ".")
                    {
                        SecondNumber = Convert.ToDouble(SecondNumberString);
                    }
                    if (Operation == "+")
                    {
                        Result = (FirstNumber + SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    if (Operation == "-")
                    {
                        Result = (FirstNumber - SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    if (Operation == "*")
                    {
                        Result = (FirstNumber * SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                    if (Operation == "/")
                    {
                        if (SecondNumber == 0)
                        {
                            textBox1.Text = "Cannot divide by zero";

                        }
                        else
                        {
                            Result = (FirstNumber / SecondNumber);
                            textBox1.Text = Convert.ToString(Result);
                            FirstNumber = Result;
                        }
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equal();
            if (textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "0";
            }
            if (IsOperation == false)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "/";
                Operation = "/";
                IsOperationClicked = true;
                IsOperation = true;
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                FirstNumber = Convert.ToDouble(textBox1.Text);

                textBox1.Text += "/";
                Operation = "/";
                IsOperationClicked = true;
                IsOperation = true;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            IsOperation = false;
            if (textBox1.Text == "0" && textBox1.Text != null || textBox1.Text == "Cannot divide by zero")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

       
    }
}