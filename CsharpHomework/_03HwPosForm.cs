using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace  CsharpHomework
{
    public partial class _03HwPosForm : Form
    {
        int G = 0;
        int R = 0;
        int B = 0;
        int Y = 0;
        double Tal = 0;
        double Taldiscount = 0;
        private int countG, countR, countB, countY; //點擊次數變數

        public _03HwPosForm()
        {
            InitializeComponent();

        }

        private void btnG_Click(object sender, EventArgs e)
        {
            G = G + 990;
            // MessageBox.Show(G + "元");
            Tal = G + R + B + Y;
            txtPrice.Text = ("NT$" + Tal);
            countG++;
            txtListshow();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            R = R + 1990;
            // MessageBox.Show(R + "元");
            Tal = G + R + B + Y;
            txtPrice.Text = ("NT$" + Tal);
            countR++;
            txtListshow();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            B = B + 880;
            // MessageBox.Show(B + "元");
            Tal = G + R + B + Y;
            txtPrice.Text = ("NT$" + Tal);
            countB++;
            txtListshow();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            Y = Y + 2990;
            // MessageBox.Show(Y + "元");
            Tal = G + R + B + Y;
            txtPrice.Text = ("NT$" + Tal);
            countY++;
            txtListshow();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Tal = 0;
            G = 0;
            R = 0;
            B = 0;
            Y = 0;
            txtPrice.Text = ("NT$" + Tal);
            txtList.Text = "尚未選購";
            countG = 0;
            countR = 0;
            countB = 0;
            countY = 0;
            //反正就是歸0
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (Tal == 0)
            {
                MessageBox.Show("尚未選購!!");
                return;
            }
            MessageBox.Show("總金額=NT$" + Tal, "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (Tal == 0)
            {
                MessageBox.Show("尚未選購!!");
                return;
            }
            Taldiscount = Tal * 0.9;
            MessageBox.Show("總金額=NT$" + Tal + "\n" + "折扣後=NT$" + Taldiscount, "確認付款", MessageBoxButtons.OKCancel);
        }
        private void txtListshow()
        {
            StringBuilder output = new StringBuilder();
            //StringBuilder 是C#中的一個類，屬於System.Text命名空間。它用於構建和修改字符串，特別是在需要對字符串進行大量拼接和修改操作時。與普通的字符串相比，
            //使用 StringBuilder 進行這些操作通常具有更高的性能。

            if (countG > 0)
            {
                output.AppendLine($"購買{countG}隻妙蛙種子，總共NT${G}");
                //AppendLine 是 StringBuilder 類中的一個方法，它用於將一個字符串追加到當前 StringBuilder 對象的末尾，並在追加的字符串後自動添加換行符（newline）。
            }

            if (countR > 0)
            {
                output.AppendLine($"購買{countR}隻小火龍，總共NT${R}");
            }

            if (countB > 0)
            {
                output.AppendLine($"購買{countB}隻傑尼龜，總共NT${B}");
            }

            if (countY > 0)
            {
                output.AppendLine($"購買{countY}隻皮卡丘，總共NT${Y}");
            }

            txtList.Text = output.ToString();
        }
    }
}
