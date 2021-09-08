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
    public partial class GiaiPTB1 : Form
    {
        public GiaiPTB1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PT1_Load(object sender, EventArgs e)
        {

        }
        private String Process(double a, double b)

        {

            String result = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    result = "phuong trinh vo so nghiem";
                }
                else
                {
                    result = "phuong trinh vo nghiem";
                }
            }
            else
            {
                result = -b / a + "";

            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(A.Text);
            Double b = Convert.ToDouble(B.Text);
            String c = Process(a, b);
            RS.Text = c;



        }
    }
}
