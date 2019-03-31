using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kevin_calculator
{
    public partial class Form1 : Form
    {
        Double resultVal = 0;
        String operation = "";
        bool isOpPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || isOpPerformed)
            {
                textBox1.Clear();
            }
            isOpPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text += button.Text;
                }
            }
            else
                textBox1.Text+= button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultVal != 0)
            {
                buttonEqual.PerformClick();
                operation = button.Text;
                labelCurrentOp.Text = resultVal + " " + operation;
                isOpPerformed = true;
            }
            else
            {
                operation = button.Text;
                resultVal = Double.Parse(textBox1.Text);
                labelCurrentOp.Text = resultVal + " " + operation;
                isOpPerformed = true;
            }
        }

        private void buttonC_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultVal = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (resultVal + Double.Parse(textBox1.Text)).ToString(); break;

                case "-":
                    textBox1.Text = (resultVal - Double.Parse(textBox1.Text)).ToString(); break;

                case "*":
                    textBox1.Text = (resultVal * Double.Parse(textBox1.Text)).ToString(); break;

                case "/":
                    textBox1.Text = (resultVal / Double.Parse(textBox1.Text)).ToString(); break;

                default: break;

            }
            resultVal = Double.Parse(textBox1.Text);
            labelCurrentOp.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCurrentOp_Click(object sender, EventArgs e)
        {

        }
    }
}
