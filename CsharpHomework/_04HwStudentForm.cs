using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  CsharpHomework
{
    public partial class _04HwStudentForm : Form
    {
        public _04HwStudentForm()
        {
            InitializeComponent();
        }
        int cnscore;
        int enscore;
        int mathscore;
        string savedata;


        private void btnsave_Click(object sender, EventArgs e)
        {
            savedata = "姓名：" + txtName.Text + "\r\n" + "國文分數：" + txtCn.Text + "\r\n" + "英文分數：" + txtEn.Text + "\r\n" + "數學分數：" + txtMath.Text;
            cnscore =Convert.ToInt32(txtCn.Text);
            enscore = Convert.ToInt32(txtEn.Text);
            mathscore = Convert.ToInt32(txtMath.Text);
        }

        private void btnShowSave_Click(object sender, EventArgs e)
        {
            txttatle.Text = savedata;
        }

        private void btnMaxmin_Click(object sender, EventArgs e)
        {
            string output = "";
           int Max = Math.Max(cnscore,Math.Max (enscore, mathscore));
           int min = Math.Min(cnscore,Math.Min(enscore, mathscore));
            if (Max == cnscore)
            {
                output = "最高分為國文" + cnscore;
            }
            else if (Max == enscore)
            {
                output = "最高分為英文" + enscore;
            }
            else
            {
                output = "最高分為數學" + mathscore;
            }
            if (min == cnscore)
            {
                output += "\r\n" + "最低分為國文" + cnscore;
            }
            else if (min == enscore)
            {
                output += "\r\n" + "最低分為英文" + enscore;
            }
            else
            {
                output += "\r\n" + "最低分為數學" + mathscore;
            }

             txtMaxmin.Text = output;
        }
    }
}
