using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 *  Author Name: Mathew Lowson
 *  Creation Date:24/3/2017
 *  Version Control: 2.0
 **/
namespace project
{
    public partial class Form1 : Form
    {


        //define variables
        string a, b = "";
        double da = 0.0, db = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        //click button for numbers
        private void btnNumbers_Click(object sender, EventArgs e)
        {
            //makes buttons equals there number
            Button but = (Button)sender;
            if (lbSign.Text == "Sign" || lbSign.Text == "\u00B1" || lbSign.Text == "\u221A" ||  lbSign.Text == "\u221B")
            {
                a = but.Text;
                //if it equals .0 remove 0 then add numbers
                if (lbA.Text.Contains(".0"))
                {
                    lbA.Text = lbA.Text.Substring(0, lbA.Text.Length - 1);
                }
                if (lbA.Text == "A")
                {
                    lbA.Text = a;
                }
                else
                {
                    lbA.Text += a;

                } 
            }
            else
            {
                b = but.Text;
                //if it equals .0 remove 0 then add numbers
                if (lbB.Text.Contains(".0"))
                {
                    lbB.Text = lbB.Text.Substring(0, lbB.Text.Length - 1);
                }

                if (lbB.Text == "B")
                {
                    lbB.Text = b;
                }
                else
                {
                    lbB.Text += b;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            a = "";
            b = "";
            lbA.Text = "A";
            lbB.Text = "B";
            tbResult.Text = "Result";
            lbSign.Text = "Sign";
        }

        private void SignClicked(object sender, EventArgs e)
        {

            //make sign text = arithmic symbol
            Button b = (Button)sender;
            lbSign.Text = b.Text;
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbA.Text, out da) == false)
            { return; }
            lbSign.Text = "\u221A";
            tbResult.Text = Maths.Algebraic.SqrRt(da).ToString();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbA.Text, out da) == false)
            { return; }

            lbSign.Text = "\u00B1";
            if (tbResult.Text == "Result")
            {

            }
            else if (tbResult.Text != a)
            {
                a = tbResult.Text;
            }

          a = Maths.Algebraic.Inverse(da).ToString();
            tbResult.Text = a;
            lbA.Text = a;
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbA.Text, out da) == false)
            { return; }
          
            tbResult.Text = Maths.Trigonometric.Sine(da).ToString();
        }

        private void BntCosine_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbA.Text, out da) == false)
            { return; }
            tbResult.Text = Maths.Trigonometric.Cosine(da).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbA.Text, out da) == false)
            { return; }
            //da = Convert.ToDouble(lbA.Text);
            if (da == 90)
            {
                tbResult.Text = "Invalid";
            }
            else
            {
                tbResult.Text = Maths.Trigonometric.Tan(da).ToString();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

            if (double.TryParse(lbA.Text, out da) == false)
            { return; }
            if (double.TryParse(lbB.Text, out db) == false)
            { return; }
            switch (lbSign.Text)
            {
                case "+":
                    tbResult.Text = Maths.Arithmitic.Add(da, db).ToString();
                    break;

                case "-":
                    tbResult.Text = Maths.Arithmitic.Sub(da, db).ToString();
                    break;

                case "/":
                    tbResult.Text = Maths.Arithmitic.Div(da, db).ToString();
                    break;

                case "*":
                    tbResult.Text = Maths.Arithmitic.Mult(da, db).ToString();
                    break;
            }
        }
        private void btnCubeRT_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbA.Text, out da) == false)
            { return; }
          
            lbSign.Text = "\u221B";
            tbResult.Text = Maths.Algebraic.CubRt(da).ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {

            if (lbSign.Text == "Sign")
            {
                if (!a.Contains("."))
                {
                    a = ".0";
                    lbA.Text += a;
                }
            }
            else
            {
                if (!b.Contains("."))
                {
                    b = ".0";
                    lbB.Text += b;
                }
            }
        }
    }
}
