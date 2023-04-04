using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public int Number1;
        public int Number2;
        public int Result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click_1(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "0";
                else
                    LBLNumber1.Text = "0";
                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "0";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "0";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "1";
                else
                    LBLNumber1.Text = "1";
                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "1";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "1";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "2";
                else
                    LBLNumber1.Text = "2";
                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "2";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "2";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "3";
                else
                    LBLNumber1.Text = "3";

                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "3";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "3";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "4";
                else
                    LBLNumber1.Text = "4";
                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "4";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "4";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "5";
                else
                    LBLNumber1.Text = "5";
                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "5";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "5";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "6";
                else
                    LBLNumber1.Text = "6";

                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "6";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "6";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "7";
                else
                    LBLNumber1.Text = "7";

                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "7";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "7";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "8";
                else
                    LBLNumber1.Text = "8";

                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "8";
                Number2 = Convert.ToInt32(LBLNumber2.Text);

            }
            else
            {
                LBLNumber2.Text = "8";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text == "" | LblOperator.Text == null)
            {
                if (LBLNumber1.Text != "")
                    LBLNumber1.Text += "9";
                else
                    LBLNumber1.Text = "9";

                Number1 = Convert.ToInt32(LBLNumber1.Text);
            }
            else if (LBLNumber2.Text != "")
            {
                LBLNumber2.Text += "9";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
            else
            {
                LBLNumber2.Text = "9";
                Number2 = Convert.ToInt32(LBLNumber2.Text);
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "+";
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "-";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "*";
        }

        private void BtnDivisor_Click(object sender, EventArgs e)
        {
            LblOperator.Text = "/";
        }

        private void BtnDelet_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (LblOperator.Text != "" && LBLNumber1.Text != "" && LBLNumber2.Text != "")
            {
                if (LblOperator.Text == "+")
                {
                    Result = Number1 + Number2;
                    LblResult.Text = Result.ToString();
                }
                else if (LblOperator.Text == "-")
                {
                    Result = Number1 - Number2;
                    LblResult.Text = Result.ToString();
                }
                else if (LblOperator.Text == "*")
                {
                    Result = Number1 * Number2;
                    LblResult.Text = Result.ToString();
                }
                else if (LblOperator.Text == "/")
                {
                    Result = Number1 / Number2;
                    LblResult.Text = Result.ToString();
                }
            }
            else
                MessageBox.Show("por favor efetue uma operação");
        }


        private void ClearAll()
        {
            LBLNumber1.Text = "";
            LBLNumber2.Text = "";
            LblOperator.Text = "";
            LblResult.Text = "";
        }
    }
}
