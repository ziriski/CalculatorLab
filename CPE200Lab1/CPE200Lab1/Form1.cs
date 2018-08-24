using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float Input1 = 0;
        float Input2 = 0;
        int round = 0;
        int Operator = 0; //Plus = 1, Minus = 2, Multiply = 3, Divide = 4
        int element = 0;
        int point = 0;
        bool equal = false;

        private void btnX_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0" || element == 0)
            {
                lblDisplay.Text = "";
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += btn.Text;
                element++;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(element == 0)
            {
                lblDisplay.Text = "0";
                element++;
            }
            if (lblDisplay.Text != "0" && lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operator = 1;
            if(round == 0)
            {
                Input1 = float.Parse(lblDisplay.Text);
                round++;
            }
            else
            {
                Input2 = float.Parse(lblDisplay.Text);
                Input1 += Input2;
                lblDisplay.Text = Input1.ToString();
            }
            element = 0;
            point = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(!equal)
            {
                Input2 = float.Parse(lblDisplay.Text);
            }
            switch (Operator)
            {
                case 1:
                    Input1 += Input2;
                    break;
                case 2:
                    Input1 -= Input2;
                    break;
                case 3:
                    Input1 *= Input2;
                    break;
                case 4:
                    Input1 /= Input2;
                    break;
            }
            lblDisplay.Text = Input1.ToString();
            equal = true;
            point = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(point == 0)
            {
                lblDisplay.Text += ".";
                point++;
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = ((float.Parse(lblDisplay.Text) / 100) * Input1).ToString();
        }
    }
}
