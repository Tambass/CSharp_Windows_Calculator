﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Windows_Calculator
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if(resultBox.Text == "0")
            {
                resultBox.Clear();
            }

            Button button = (Button)sender;
            resultBox.Text = resultBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorClicked = button.Text;
            resultValue = Double.Parse(resultBox.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultValue = 0;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "×":
                    resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "÷":
                    resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
