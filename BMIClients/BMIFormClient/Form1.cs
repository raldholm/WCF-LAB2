using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new BmiCalculatorServiceClient();

            
            var weight = double.Parse(textBox_kg.Text);

            var lenght = double.Parse(textBox_cm.Text);
            var bmi = client.CalculateBmi(weight, lenght);

            label_result.Text = bmi.ToString();
            

        }
    }
}
