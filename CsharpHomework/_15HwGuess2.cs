using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class _15HwGuess2 : Form
    {

        public _15HwGuess2()
        {
            InitializeComponent();

        }
        public int ansX;
        public int txtans;
        int Max = 100;
        int min=0;
        int error = 0;
        public string BackG1;

        //宣告委派
        public delegate void GuessResultEventHandler(string result);
        public event GuessResultEventHandler GuessResultEvent;
        private void btnE_Click(object sender, EventArgs e)
        {
          
            //if (int.TryParse(txtNum.Text, out txtans))
            //{
            //    if (txtans > 0 && txtans <= 100)
            //    {
            //        if (txtans == ansX)
            //        {
            //            MessageBox.Show($"恭喜答對，幸運數字為{ansX}遊戲結束!");
            //            return;
            //        }
            //        else if (txtans > ansX)
            //        {
            //            if (txtans < Max)
            //            {
            //                labQ.Text = $"猜大了，請猜{min}到{txtans}";
            //                Max = txtans;
            //            }
            //            else
            //            {
            //                labQ.Text = $"超出猜測範圍，請猜{min}到{Max}";
            //                error++;
            //                Method();
            //            }
            //        }
            //        else if (txtans < ansX)
            //        {
            //            if (txtans > min)
            //            {
            //                labQ.Text = $"猜小了，請猜{txtans}到{Max}";
            //                min = txtans;
            //            }
            //            else
            //            {
            //                labQ.Text = $"超出猜測範圍，請猜{min}到{Max}";
            //                error++;
            //                Method();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show($"請輸入1~100數字");

            //            return;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show($"請輸入數字");
            //        return;
            //    }
            //}
            if (int.TryParse(txtNum.Text, out txtans))
            {
                if (txtans > 0 && txtans <= 100)
                {
                    if (txtans == ansX)
                    {
                        MessageBox.Show($"恭喜答對，幸運數字為{ansX}遊戲結束!");
                        Random RR= new Random();
                        ansX=RR.Next(1,101);
                        return;
                    }
                    else if (txtans > ansX)
                    {
                        if (txtans < Max)
                        {
                            BackG1= $"猜大了，請猜{min}到{txtans}";
                            Max = txtans;
                        
                        }
                        else
                        {
                            BackG1 = $"超出猜測範圍，請猜{min}到{Max}";
                            error++;
                            Method();
                    
                        }
                    }
                    else if (txtans < ansX)
                    {
                        if (txtans > min)
                        {
                            BackG1 = $"猜小了，請猜{txtans}到{Max}";
                            min = txtans;
                    
                        }
                        else
                        {
                            BackG1 = $"超出猜測範圍，請猜{min}到{Max}";
                            error++;
                            Method();
                    
                        }
                    }
                    else
                    {
                        BackG1=$"請輸入1~100數字";
                        error++;
                        return;
                    }
                }
                else
                {
                    BackG1=$"請輸入數字";
                    error++;
                    return;
                }
            }
            GuessResultEvent?.Invoke(BackG1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void Method()
        {
            if (error > 3)
            {
                MessageBox.Show("你白癡喔!!!猜數字都不會玩!");
                error = 0;
            }
        }
        //void Method2()
        //{
        //    MessageBox.Show("有動嗎?");
        //    _15HwGuessNumber G1 = new _15HwGuessNumber();
        //    G1.Method3();
        //}
  }
}
