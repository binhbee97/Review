using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS434_Calculator
{
    public partial class GiaiPTB2 : Form
    {
        public GiaiPTB2()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PT2_Load(object sender, EventArgs e)
        {

        }
        private String Process(Double a, Double b, Double c)
        {
            String result = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        result = "Vo So Nghiem";
                    }
                    else
                    {
                        result = "Vo Nghiem";

                    }
                }
                else
                {
                    result = "x=" + Math.Round((-c / b), 2);
                }
            }
            else
            {
                Double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    Double x1, x2;
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    result = "x1=" + Math.Round(x1, 2) + " va  x2=" + Math.Round(x2, 2);
                }
                else if (delta == 0)
                {
                    result = "Nghiem kep" + Math.Round((-b / 2 * a), 2);
                }
                else
                {
                    result = "Vo Nghiem";
                }

            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(textA.Text);
            Double b = Convert.ToDouble(textB.Text);
            Double c = Convert.ToDouble(textC.Text);
            textRS.Text = Process(a, b, c);
        }
    }
}
