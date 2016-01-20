﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSnusClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new SnusCalculatorClient();
            var antalDosor = double.Parse(textBox1.Text);
            var nikotin = client.CalculateNicotineAmount(antalDosor);
            textBox2.Text = nikotin.ToString();
        }
    }
}