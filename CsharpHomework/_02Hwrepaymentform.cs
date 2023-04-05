using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace  CsharpHomework
{
    public partial class _02Hwrepaymentform : Form
    {
        public _02Hwrepaymentform()
        {
            InitializeComponent();

        }

        public void monthpay_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(LoanamountBox.Text); //總金額
            double b = Convert.ToDouble(YearBox.Text); //總年
            double c = Convert.ToDouble(interestrateBox.Text) / 100; //利率
            double d = Convert.ToDouble(downpaymentBox.Text); //頭期款
            /*
            每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額
            月利率=c/12
            月數=b*12
            每月應付本息金額之平均攤還率 = (Math.Pow((1+c/12),b*12)*(c/12))/(Math.Pow((1+c/12),b*12)-1)
            每月應付利息金額＝本金餘額×月利率
            每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
            */

            double tal = (a - d) * (Math.Pow((1 + c / 12), b * 12) * (c / 12)) / (Math.Pow((1 + c / 12), b * 12) - 1);
            MessageBox.Show("月付" + Math.Round(tal) + "元!");
        }

        public void totalpay_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(LoanamountBox.Text); //總金額
            double b = Convert.ToDouble(YearBox.Text); //總年
            double c = Convert.ToDouble(interestrateBox.Text) / 100; //利率
            double d = Convert.ToDouble(downpaymentBox.Text); //頭期款
            /*
            每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額
            月利率=c/12
            月數=b*12
            每月應付本息金額之平均攤還率 = (Math.Pow((1+c/12),b*12)*(c/12))/(Math.Pow((1+c/12),b*12)-1)
            每月應付利息金額＝本金餘額×月利率
            每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
            */
            double tal = (a - d) * (Math.Pow((1 + c / 12), b * 12) * (c / 12)) / (Math.Pow((1 + c / 12), b * 12) - 1);
            MessageBox.Show("總額" + Math.Round(tal) * b * 12 + "元!");
        }

        private void showinf_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(LoanamountBox.Text); //總金額
            double b = Convert.ToDouble(YearBox.Text); //總年
            double c = Convert.ToDouble(interestrateBox.Text) / 100; //利率
            double d = Convert.ToDouble(downpaymentBox.Text); //頭期款
            /*
            每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額
            月利率=c/12
            月數=b*12
            每月應付本息金額之平均攤還率 = (Math.Pow((1+c/12),b*12)*(c/12))/(Math.Pow((1+c/12),b*12)-1)
            每月應付利息金額＝本金餘額×月利率
            每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
            */

            double tal = (a - d) * (Math.Pow((1 + c / 12), b * 12) * (c / 12)) / (Math.Pow((1 + c / 12), b * 12) - 1);
            double tal2 = Math.Round(tal) * b*12;
            string strtal= Math.Round(tal).ToString();
            string strtal2 = tal2.ToString();
            _02Hwrepaymentshow formB = new _02Hwrepaymentshow(LoanamountBox.Text, YearBox.Text,interestrateBox.Text,strtal,strtal2);
            formB.Show();
        }
    }
 }

