using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CsharpHomework
{
    public partial class _08Hwcalculate : Form
    {
        public _08Hwcalculate()
        {
            InitializeComponent();
        }
     
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            double ans;
            if (double.TryParse(txtnum1.Text, out double n1) && double.TryParse(txtnum2.Text, out double n2))
            {
                ans = n1 + n2;
                txtans.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字!");
            }
        }

        private void btnsubtraction_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1.Text, out double n1) && double.TryParse(txtnum2.Text, out double n2))
            {
                double ans = n1 - n2;
                txtans.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字!");
            }
        }

        private void btnmultiplication_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1.Text, out double n1) && double.TryParse(txtnum2.Text, out double n2))
            {
                double ans = n1 * n2;
                txtans.Text = ans.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字!");
            }
        }

        private void btndivision_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1.Text, out double n1) && double.TryParse(txtnum2.Text, out double n2))
            {
                if (n2 != 0)
                {
                    double ans = n1 / n2;
                    txtans.Text = ans.ToString("G5");
                }
                else
                {
                    MessageBox.Show("除數不能為0!");
                }
            }
            else
            {
                MessageBox.Show("請輸入數字!");
            }
        }
    }
}
