using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if(usdRadioButton.Checked == true)
            {
                radioButtonLabel.Text = "Option";
                radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "IDR - Please fill this field.";
                    inputBoxLabel.ForeColor = Color.Red;
                } else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double output = double.Parse(inputBox.Text) * 0.000069;

                    outputBox.Text = output.ToString();
                    outputBoxLabel.Text = usdRadioButton.Text;
                }
            }
            else if (eurRadioButton.Checked == true)
            {
                radioButtonLabel.Text = "Option";
                radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "IDR - Please fill this field.";
                    inputBoxLabel.ForeColor = Color.Red;
                }
                else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double output = double.Parse(inputBox.Text) * 0.000058;

                    outputBox.Text = output.ToString();
                    outputBoxLabel.Text = eurRadioButton.Text;
                }
            }
            else
            {
                radioButtonLabel.Text = "Option - Please select currency.";
                radioButtonLabel.ForeColor = Color.Red;
            }
        }
    }
}
