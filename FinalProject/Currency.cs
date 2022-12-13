using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class Currency : Form
    {
        double Euro = 0.965431;
        double Pound = 0.829393;
        double Rupee = 81.753894;
        double Australian = 1.497290;
        double Canadian = 1.345306;
        double Singapore = 1.377857;
        double Swiss = 0.946459;
        double Malaysian = 4.480309;
        double Yen = 138.301976;
        double Yuan = 7.210870;
        public Currency()
        {
            InitializeComponent();
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            CurrencyComboBox.Text = "Choose One...";
            CurrencyComboBox.Items.Add("Euro");
            CurrencyComboBox.Items.Add("British Pound");
            CurrencyComboBox.Items.Add("Indian Rupee");
            CurrencyComboBox.Items.Add("Australian Dollar");
            CurrencyComboBox.Items.Add("Canadian Dollar");
            CurrencyComboBox.Items.Add("Singapore Dollar");
            CurrencyComboBox.Items.Add("Swiss Franc");
            CurrencyComboBox.Items.Add("Malaysian Ringgit");
            CurrencyComboBox.Items.Add("Japanese Yen");
            CurrencyComboBox.Items.Add("Chinese Yuan Renminbi");
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Double AmericanDollar = Double.Parse(inputTextBox.Text);
                if (CurrencyComboBox.Text == "Euro")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Euro));
                }
                if (CurrencyComboBox.Text == "British Pound")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Pound));
                }
                if (CurrencyComboBox.Text == "Indian Rupee")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Rupee));
                }
                if (CurrencyComboBox.Text == "Australian Dollar")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Australian));
                }
                if (CurrencyComboBox.Text == "Canadian Dollar")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Canadian));
                }
                if (CurrencyComboBox.Text == "Singapore Dollar")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Singapore));
                }
                if (CurrencyComboBox.Text == "Swiss Franc")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Swiss));
                }
                if (CurrencyComboBox.Text == "Malaysian Ringgit")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Malaysian));
                }
                if (CurrencyComboBox.Text == "Japanese Yen")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Yen));
                }
                if (CurrencyComboBox.Text == "Chinese Yuan Renminbi")
                {
                    outputTextBox.Text = System.Convert.ToString((AmericanDollar * Yuan));
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Check your inputs please");
            }
           
        }
    }
}
