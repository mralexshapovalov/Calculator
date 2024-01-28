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
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValues = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
        }

        private void BtnMathOperation(object sender, EventArgs e)
        {
            if (result != 0)
            {
                buttonEqually.PerformClick();
            }
            else result = Double.Parse(textBox1.Text);

            Button button = (Button)sender;

            operation = button.Text;
            enterValues = true;

            if (textBox1.Text != "0")
            {
                textBox.Text = fstNum = $"{result}{operation}";
                textBox1.Text = string.Empty;
            }
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            secNum = textBox1.Text;
            textBox.Text = $"{textBox.Text}{textBox1.Text}=";
            if (textBox1.Text != string.Empty)
            {
                if (textBox1.Text == "0")
                {
                    textBox.Text = string.Empty;


                }
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        textBox.Text = $"{textBox1.Text}=";
                        break;

                }
                result = Double.Parse(textBox1.Text);
                operation = string.Empty;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

            }
            if (textBox1.Text == string.Empty) textBox1.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox.Text = string.Empty;
            result = 0;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Btn_OpearionClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            {
                case "Cor":
                    textBox.Text = $"Cor({textBox1.Text})";
                    textBox1.Text = Convert.ToString(Math.Sqrt(Double.Parse(textBox1.Text)));
                    break;
                case "^2":
                    textBox.Text = $"({textBox1.Text})^2";
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
                    break;
                case "1/x":
                    textBox.Text = $"1/x({textBox1.Text})";
                    textBox1.Text = Convert.ToString(1.0 / (Double.Parse(textBox1.Text)));
                    break;
                case "%":
                    textBox.Text = $"%({textBox1.Text})";
                    textBox1.Text = Convert.ToString(Double.Parse(textBox1.Text) / Convert.ToDouble(100));
                    break;
                case "+/-":
                    textBox1.Text = Convert.ToString(-1 * Double.Parse(textBox1.Text));
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNum_Clicl(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || enterValues)
            {
                textBox1.Text = string.Empty;
            }

            enterValues = false;

            Button button = (Button)sender;

            if(button.Text == ",") 
            {
            
                if(textBox1.Text.Contains(","))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
        }


    }
}




        
        

