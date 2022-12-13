using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CalcForm : Form
    {
        float num1, ans, num2;
        int count;
        public CalcForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
        }
    
        public void compute(int count)
        {
            switch (count)
            {

                case 1:
                    ans = num1 - float.Parse(inputText.Text);
                    textBox1.Text = num1 + " - " + float.Parse(inputText.Text) + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(inputText.Text);
                    textBox1.Text = num1 + " + " + float.Parse(inputText.Text) + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(inputText.Text);
                    textBox1.Text = num1 + " x " + float.Parse(inputText.Text) + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(inputText.Text);
                    textBox1.Text = num1 + " / " + float.Parse(inputText.Text) + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();

                    break;
                case 5:
                    ans = 1 / num1;
                    textBox1.Text = 1 + " / " + num1 + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();

                    break;
                case 6:
                    ans = num1 * num1;
                    textBox1.Text = num1 + " ^2 " + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();
                    break;
                case 7:
                    if (num1 > 1)
                    {
                        ans = num1 * 1 / 100;
                    }
                    else if (num1 < 1)
                    {
                        ans = num1 * 100;
                    }
                    textBox1.Text = " '/, " + num1 + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();

                    break;
                case 8:
                    ans = num1 * -1;
                    textBox1.Text = ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();

                    break;
                case 9:
                    ans = (float)Math.Sqrt(num1);
                    textBox1.Text = " sqrt " + num1 + " = " + ans.ToString() + System.Environment.NewLine + textBox1.Text;
                    inputText.Text = ans.ToString();

                    break;
                default:
                    break;
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //history
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
        }

        #region Symbols/Operators
        private void button25_Click(object sender, EventArgs e)
        {
            //Percent Button
            inputText.Text = inputText.Text + "percent";
            inputText.Focus();
            count = 7;
            compute(count);
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            

        }

        private void bPower_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            //inputText.Text = inputText.Text + "power2";
            inputText.Focus();
            count = 6;
            compute(count);
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            //inputText.Text = inputText.Text + "power2";
            inputText.Focus();
            count = 9;
            compute(count);
        }

        private void bUnderOne_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            //inputText.Text = inputText.Text + "1/";
            inputText.Focus();
            count = 5;
            compute(count);
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            inputText.Focus();
            count = 4;
            inputText.Clear();
        }
        private void bMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            inputText.Focus();
            count = 3;
            inputText.Clear();

        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            //inputText.Text = inputText.Text + "-";
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            inputText.Focus();
            count = 1;
            inputText.Clear();
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            //inputText.Text = inputText.Text + "+";
            inputText.Focus();
            count = 2;
            inputText.Clear();

        }

        private void bPlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(inputText.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your Input Please!");
            }
            //inputText.Text = inputText.Text + "+-";
            inputText.Focus();
            count = 8;
            compute(count);
        }
        private void bDot_Click(object sender, EventArgs e)
        {
            int c = inputText.TextLength;
            int flag = 0;
            string text = inputText.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                inputText.Text = inputText.Text + ".";
            }

        }
#endregion

        #region Numbers
        private void bSeven_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 7;
        }
        private void bZero_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 0;
        }
        private void bEight_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 8;
        }

        private void bNIne_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 9;
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 4;
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 5;
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 6;
        }

        private void bOne_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 1;
        }

        private void bTwo_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 2;
        }

        private void bThree_Click(object sender, EventArgs e)
        {
            inputText.Text = inputText.Text + 3;
        }

        #endregion

        #region Compute/Clear
        private void bClearEntry_Click_1(object sender, EventArgs e)
        {
            inputText.Clear();
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void bClear_Click_1(object sender, EventArgs e)
        {
            inputText.Clear();
            textBox1.Clear();
        }

        private void bDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                inputText.Text = inputText.Text.Remove(inputText.Text.Length - 1);
            }
           
             catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("You are deleting nothing!");
            }
        }
        #endregion

    }
}
