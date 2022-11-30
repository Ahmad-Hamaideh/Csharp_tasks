using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace calculator
{
    public partial class WebForm : System.Web.UI.Page
    {
        double vr = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnF_Click(object sender, EventArgs e)
        {
            Button mybtn = sender as Button;
                   txt .Text = txt.Text + mybtn.Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            Button myf = sender as Button;
            hidd2.Text = myf.Text;
            hidd.Text = txt.Text;
            txt.Text = string.Empty;
        }

        protected void sum_Click(object sender, EventArgs e)
        {
            switch (hidd2.Text)
            {
                case "+":
                    double rus = Convert.ToDouble(hidd.Text) + Convert.ToDouble(txt.Text);
                    txt.Text = rus.ToString();
                    break;
                case "-":
                    double rus2 = Convert.ToDouble(hidd.Text) - Convert.ToDouble(txt.Text);
                    txt.Text = rus2.ToString();
                    break;
                case "*":
                    double rus3 = Convert.ToDouble(hidd.Text) * Convert.ToDouble(txt.Text);
                    txt.Text = rus3.ToString();
                    break;
                case "/":
                    double rus4 = Convert.ToDouble(hidd.Text) / Convert.ToDouble(txt.Text);
                    txt.Text = rus4.ToString();
                    break;
            }
         
        }
    }
}