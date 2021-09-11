using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTbac1_2
{
    public partial class PT1 : Form
    {
        public PT1()
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
            private String TinhToan(double giaTriA, double giaTriB)

            {

                String ketQua = "";
                if (giaTriA == 0)
                {
                    if (giaTriB == 0)
                    {
                        ketQua = "phuong trinh vo so nghiem";
                    }
                    else
                    {
                        ketQua = "phuong trinh vo nghiem";
                    }
                }
                else
                {
                    ketQua = -giaTriB / giaTriA + "";

                }
                return ketQua;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                Double giaTriNhapVaoA = Convert.ToDouble(giaTriA.Text);
                Double giaTriNhapVapB = Convert.ToDouble(giaTriA.Text);
                String nghiem = TinhToan(giaTriNhapVaoA, giaTriNhapVapB);
                RS.Text = nghiem;



            }

        private void Reset_Click(object sender, EventArgs e)
        {
            giaTriA.Text = "";
            giaTriB.Text = "";
        }
    }
    }


