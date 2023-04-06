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
    public partial class _08Hwcalculateform : Form
    {
        public _08Hwcalculateform()
        {
            InitializeComponent();
        }

        public void Nums()
        {
            int n1 = Convert.ToInt32(txtnum1.Text);
            int n2 = Convert.ToInt32(txtnum2.Text);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnum1.Text);
            int n2 = Convert.ToInt32(txtnum2.Text);
            int ans = n1 + n2;
            txtans.Text = ans.ToString();
        }

        private void btnsubtraction_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnum1.Text);
            int n2 = Convert.ToInt32(txtnum2.Text);
            int ans = n1 - n2;
            txtans.Text = ans.ToString();
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnum1.Text);
            int n2 = Convert.ToInt32(txtnum2.Text);
            int ans = n1 * n2;
            txtans.Text = ans.ToString();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtnum1.Text);
            int n2 = Convert.ToInt32(txtnum2.Text);
            int ans = n1 / n2;
            txtans.Text = ans.ToString();
        }
    }
}
