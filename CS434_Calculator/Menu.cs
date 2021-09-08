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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGiaiPTB1_Click(object sender, EventArgs e)
        {
            GiaiPTB1 ptb1 = new GiaiPTB1();
            ptb1.Show();
        }

        private void btnGiaiPTB2_Click(object sender, EventArgs e)
        {
            GiaiPTB2 ptb2 = new GiaiPTB2();
            ptb2.Show();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }
    }
}
