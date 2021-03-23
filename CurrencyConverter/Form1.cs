using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double getRate(string fromCurrency, string toCurrency)
        {
            var json = "";
            string rate = "";
            try
            {
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=2bd8f3878134e78c2615", fromCurrency.ToUpper(), toCurrency.ToUpper());
                string key = string.Format("{0}_{1}", fromCurrency.ToUpper(), toCurrency.ToUpper());
                
                json = new WebClient().DownloadString(url);
                dynamic stuff = JsonConvert.DeserializeObject(json);
                rate = stuff[key];
            }
            catch
            {
                rate = "0";
            }

            return double.Parse(rate);
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

                    double rate = getRate(inputBoxLabel.Text, eurRadioButton.Text);
                    double output = double.Parse(inputBox.Text) * rate;

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

                    double rate = getRate(inputBoxLabel.Text, eurRadioButton.Text);
                    double output = double.Parse(inputBox.Text) * rate;

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
