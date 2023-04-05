using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CsharpHomework._15HwGuess2;
using static System.Windows.Forms.DataFormats;

namespace CsharpHomework
{
    public partial class _15HwGuessNumber : Form
    {
        int ans;
        int Max=100;
        int min = 1;
        int txtans;
        public _15HwGuessNumber()
        {
            InitializeComponent();
            Random R= new Random();
            ans = R.Next(1, 101);

        //委派?
            _15HwGuess2 G2 = new _15HwGuess2();
            G2.GuessResultEvent += GuessResultEventHandler;
        }
        //委派?
        private void GuessResultEventHandler(string result)
        {
            labQ.Text = result;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
          //  panel1.Visible = true;
            _15HwGuess2 G2= new _15HwGuess2();
            G2.ansX = ans;
            G2.GuessResultEvent += GuessResultEventHandler;
            G2.ShowDialog();

        }
          private void btnA_Click(object sender, EventArgs e)
        {
           MessageBox.Show($"幸運數字是 {Convert.ToString(ans)} ");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAns.Text, out txtans))
            {
                if (txtans >0 && txtans <= 100)
                {
                    if (txtans == ans)
                    {
                        MessageBox.Show($"恭喜答對，幸運數字為{ans}遊戲結束!");
                        Random R = new Random();
                        ans = R.Next(1, 101);
                        panel1.Visible = false;
                        return;
                    }
                    else if (txtans > ans)
                    {
                        if (txtans < Max)
                        {
                            labQ.Text = $"猜大了，請猜{min}到{txtans}";
                            Max = txtans;
                        }
                        else 
                        {
                            labQ.Text = $"超出猜測範圍，請猜{min}到{Max}";
                        }
                    }
                    else if (txtans < ans)
                    {
                        if (txtans > min)
                        {
                            labQ.Text = $"猜小了，請猜{txtans}到{Max}";
                            min = txtans;
                        }
                        else
                        {
                            labQ.Text = $"超出猜測範圍，請猜{min}到{Max}";
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"請輸入1~100數字");
                    return;
                }
            }
            else
            {
                MessageBox.Show($"請輸入數字");
                return;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

    }
}
