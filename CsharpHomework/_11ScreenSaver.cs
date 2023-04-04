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
    public partial class _11ScreenSaver : Form
    {

        public _11ScreenSaver()
        {
            InitializeComponent();
        }
        private void _11ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer2.Enabled == false)
            {
                Application.Exit();
            }
        }

        private void _11ScreenSaver_MouseDown(object sender, MouseEventArgs e)
        {
           
            //Application.Exit();
        }

        private int dx = 8;
        private int dy = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {         
            
           // labTime.Text = DateTime.Now.ToString();
            labTime.Left -= 10;
            labTime.Top -= 5;
            if(labTime.Right< 0) 
            {
                labTime.Left=this.ClientSize.Width;
            }

            if(labTime.Top<0)
            {
                labTime.Top = this.ClientSize.Height;
            }
            int x = picpoke249.Location.X;
            int y = picpoke249.Location.Y;

            // 判斷是否到達右邊邊界，如果是，改變移動方向
            if (x + picpoke249.Width >= ClientSize.Width)
            {
                x = ClientSize.Width - picpoke249.Width;
                dx = -dx;
                picpoke249.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            }
            // 判斷是否到達左邊邊界，如果是，改變移動方向
            else if (x <= 0)
            {
                x = 0;
                dx = -dx;
                picpoke249.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            }

            // 判斷是否到達下邊邊界，如果是，改變移動方向


            if (y + picpoke249.Height >= ClientSize.Height)
            {
                y = ClientSize.Height - picpoke249.Height;
                dy = -dy;
            }
            // 判斷是否到達上邊邊界，如果是，改變移動方向
            else if (y <= 0)
            {
                y = 0;
                dy = -dy;
            }

            x += dx; // 每秒移動5個像素
            y += dy; // 每秒移動5個像素

            picpoke249.Location = new Point(x, y);
        }

        private void _11ScreenSaver_Load(object sender, EventArgs e)
        {
            picpoke249.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void _11ScreenSaver_MouseUp(object sender, MouseEventArgs e)
        {
            if (timer2.Enabled == true)
            {
                timer2.Enabled = false;
            }
        }


    }
}

