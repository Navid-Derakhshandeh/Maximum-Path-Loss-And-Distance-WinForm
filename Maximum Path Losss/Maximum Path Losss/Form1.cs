using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maximum_Path_Losss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MPL2_Click(object sender, EventArgs e)
        {
            double tp = Double.Parse(TP.Text);
            double rs = Double.Parse(RS.Text);
            double ra = Double.Parse(RA.Text);
            double tag = Double.Parse(TAG.Text);
            double fm = Double.Parse(FM.Text);
            double g = ra + tag;
            double mpl = tp - rs + g - fm;
            MPL.Text = (mpl).ToString();
           
        }

        private void D1_Click(object sender, EventArgs e)
        {
            double mpl3 = Double.Parse(MPL1.Text);
            double f = Double.Parse(F.Text);
            double X = (mpl3 - 32.44 - Math.Log(f)) / 20;
            double Y = Math.Pow(10, X);
            D.Text = (Y).ToString();
        }
    }
}
