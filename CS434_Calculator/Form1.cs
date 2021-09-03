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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text == "")
                txtKQ.Clear();
            Button b = (Button)sender;
            txtKQ.Text = txtKQ.Text + b.Text;
        }


        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(txtKQ.Text);
                    txtKQ.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(txtKQ.Text);
                    txtKQ.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtKQ.Text);
                    txtKQ.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtKQ.Text);
                    txtKQ.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(txtKQ.Text);
                    txtKQ.Text = ans.ToString();
                    break;
                case 6:
                    ans = 1;
                    int i = 1;
                    if (num == 0)
                        ans = 1;
                    else 
                    {
                        while (i < num)
                        {
                            ans = ans * (i + 1);
                            i++;
                        }
                    }                  
                    txtKQ.Text = ans.ToString();
                    break;
                case 7:
                    ans = 1 / num;
                    txtKQ.Text = ans.ToString();
                    break;
                case 8:
                    ans = Math.Abs(num);
                    txtKQ.Text = ans.ToString();
                    break;
                case 9:
                    ans = num * -1;
                    txtKQ.Text = ans.ToString();
                    break;
                case 10:
                    ans = num;
                    int n = int.Parse(txtKQ.Text);                                    
                    if (n == 0)
                        ans = num;
                    else
                    {
                        for (int j = 1; j < n; j++)
                            ans = ans * num;                       
                    }
                    txtKQ.Text = ans.ToString();
                    break;
                case 11:
                    ans = num * num;                   
                    txtKQ.Text = ans.ToString();
                    break;
                case 12:
                    ans = (float)Math.Sqrt(num);
                    txtKQ.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if(txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 1;
                lblNhap.Text = num.ToString() + "+";
            }
            else
            {
                txtKQ.Focus();
            }
            
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if(txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 2;
                lblNhap.Text = num.ToString() + "-";
            }          
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 3;
                lblNhap.Text = num.ToString() + "*";
            }
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 4;
                lblNhap.Text = num.ToString() + "/";
            }
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnChiaDu_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 5;
                lblNhap.Text = num.ToString() + "%";
            }
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnGiaThua_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 6;
                lblNhap.Text = num.ToString() + "!";
            }
            else
            {
                txtKQ.Focus();
            }
            
        }

        private void btnPhanSo_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 7;
                lblNhap.Text = "1/" + num.ToString();
            }
            else
            {
                txtKQ.Focus();
            }
            
        }

        private void btnTriTuyetDoi_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 8;
                lblNhap.Text = "|" + num.ToString() + "|";
            }
            else
            {
                txtKQ.Focus();
            }
            
        }

        private void btnAmDuong_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 9;
                lblNhap.Text = "-1 * " + num.ToString();
            }
            else
            {
                txtKQ.Focus();
            }
            
        }

        private void btnMuN_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 10;
                lblNhap.Text = num.ToString() + " lũy thừa ";
            }
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnMu2_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 11;
                lblNhap.Text = num.ToString() + " lũy thừa 2";
            }
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnCanBac2_Click(object sender, EventArgs e)
        {
            if (txtKQ.Text != "")
            {
                num = float.Parse(txtKQ.Text);
                txtKQ.Clear();
                txtKQ.Focus();
                count = 12;
                lblNhap.Text = "căn bậc 2 của" + num.ToString();
            }
            else
            {
                txtKQ.Focus();
            }
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            compute();
            lblNhap.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int length = txtKQ.TextLength - 1;
            string txt = txtKQ.Text;
            txtKQ.Clear();
            for (int i = 0; i < length; i++)
                txtKQ.Text = txtKQ.Text + txt[i];
        }
    }
}
