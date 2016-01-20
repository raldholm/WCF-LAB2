﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgeWebClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new AgeCalculatorServiceClient();
            
            var birthdate = DateTime.Parse(TextBox1.Text);
            var daysOld = client.CalculateAgedays(birthdate);
            var even1KDays = client.CalculateEvenBirthday(birthdate);

            Label1.Text = daysOld.ToString();
            TextBox2.Text = even1KDays;


        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}