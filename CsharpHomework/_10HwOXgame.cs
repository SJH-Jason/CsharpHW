using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  CsharpHomework
{
    public partial class _10HwOXgame : Form
    {
        public _10HwOXgame()
        {
            InitializeComponent();
        }
        bool count = false;
        int countNo = 0;

        private void btn01_Click(object sender, EventArgs e)
        {
          if (count==false)
            {
                btn01.Text = "X";
                count = true;
            }
          else
            {
                btn01.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn01.Enabled = false;
            // 使按鈕在禁用時保持原有顏色
            btn01.UseVisualStyleBackColor = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn02.Text = "X";
                count = true;
            }
            else
            {
                btn02.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn02.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn03.Text = "X";
                count = true;
            }
            else
            {
                btn03.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn03.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn04.Text = "X";
                count = true;
            }
            else
            {
                btn04.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn04.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn05.Text = "X";
                count = true;
            }
            else
            {
                btn05.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn05.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn06.Text = "X";
                count = true;
            }
            else
            {
                btn06.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn06.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn07.Text = "X";
                count = true;
            }
            else
            {
                btn07.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn07.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn08.Text = "X";
                count = true;
            }
            else
            {
                btn08.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn08.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            if (count == false)
            {
                btn09.Text = "X";
                count = true;
            }
            else
            {
                btn09.Text = "O";
                count = false;
            }
            // 禁用按鈕，使其無法再次點擊
            btn09.Enabled = false;
            countNo++;
            WinWin();
            GameOver();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Restar();
        }
        void Restar()
        {
            count = false;
            btn01.Text = "";
            btn01.Enabled = true;
            btn02.Text = "";
            btn02.Enabled = true;
            btn03.Text = "";
            btn03.Enabled = true;
            btn04.Text = "";
            btn04.Enabled = true;
            btn05.Text = "";
            btn05.Enabled = true;
            btn06.Text = "";
            btn06.Enabled = true;
            btn07.Text = "";
            btn07.Enabled = true;
            btn08.Text = "";
            btn08.Enabled = true;
            btn09.Text = "";
            btn09.Enabled = true;
            countNo = 0;
        }
         void GameOver()
        {
           if(countNo == 9)
            {
                MessageBox.Show("和局，遊戲結束!");
                Restar();
            }
         }

         void  WinWin()
            {

            bool win1 = btn01.Text == btn02.Text && btn02.Text == btn03.Text && btn03.Text == "O";
            bool win2 = btn04.Text == btn05.Text && btn05.Text == btn06.Text && btn06.Text == "O";
            bool win3 = btn07.Text == btn08.Text && btn08.Text == btn09.Text && btn09.Text == "O";
            bool win4 = btn01.Text == btn04.Text && btn04.Text == btn07.Text && btn07.Text == "O";
            bool win5 = btn02.Text == btn05.Text && btn05.Text == btn08.Text && btn08.Text == "O";
            bool win6 = btn03.Text == btn06.Text && btn06.Text == btn09.Text && btn09.Text == "O";
            bool win7 = btn01.Text == btn05.Text && btn05.Text == btn09.Text && btn09.Text == "O";
            bool win8 = btn03.Text == btn05.Text && btn05.Text == btn07.Text && btn07.Text == "O";
            bool win9 = btn01.Text == btn02.Text && btn02.Text == btn03.Text && btn03.Text == "X";
            bool win10 = btn04.Text == btn05.Text && btn05.Text == btn06.Text && btn06.Text == "X";
            bool win11 = btn07.Text == btn08.Text && btn08.Text == btn09.Text && btn09.Text == "X";
            bool win12 = btn01.Text == btn04.Text && btn04.Text == btn07.Text && btn07.Text == "X";
            bool win13 = btn02.Text == btn05.Text && btn05.Text == btn08.Text && btn08.Text == "X";
            bool win14 = btn03.Text == btn06.Text && btn06.Text == btn09.Text && btn09.Text == "X";
            bool win15 = btn01.Text == btn05.Text && btn05.Text == btn09.Text && btn09.Text == "X";
            bool win16 = btn03.Text == btn05.Text && btn05.Text == btn07.Text && btn07.Text == "X";

            if (win1==true)
            {
                MessageBox.Show($"恭喜{btn01.Text}方獲得勝利","完局", MessageBoxButtons.OK);
                Restar();
            }
            else if(win2==true) 
            {
                MessageBox.Show($"恭喜{btn04.Text}方獲得勝利","完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win3 == true)
            {
                MessageBox.Show($"恭喜{btn07.Text}方獲得勝利","完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win4 == true)
            {
                MessageBox.Show($"恭喜{btn01.Text}方獲得勝利","完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win5 == true)
            {
                MessageBox.Show($"恭喜{btn02.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win6 == true)
            {
                MessageBox.Show($"恭喜{btn03.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win7 == true)
            {

                MessageBox.Show($"恭喜{btn01.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();

            }
            else if (win8 == true)
            {
                MessageBox.Show($"恭喜{btn03.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win9 == true)
            {
                MessageBox.Show($"恭喜{btn01.Text}方獲得勝利","完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win10 == true)
            {
                MessageBox.Show($"恭喜{btn04.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();

            }
            else if (win11 == true)
            {
                MessageBox.Show($"恭喜{btn07.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win12 == true)
            {
                MessageBox.Show($"恭喜{btn01.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win13 == true)
            {
                MessageBox.Show($"恭喜{btn02.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win14 == true)
            {
                MessageBox.Show($"恭喜{btn03.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
            else if (win15 == true)
            {

                MessageBox.Show($"恭喜{btn01.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();

            }
            else if (win16 == true)
            {
                MessageBox.Show($"恭喜{btn03.Text}方獲得勝利", "完局", MessageBoxButtons.OK);
                Restar();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
 }
