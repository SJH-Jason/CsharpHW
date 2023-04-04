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
    public partial class _14HwPictureViewers : Form
    {
        public _14HwPictureViewers()
        {
            InitializeComponent();
        }
        int i = 0;
        private void _14HwPictureViewers_Load(object sender, EventArgs e)
        {
            picB8.Image = imageList1.Images[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i == 0)
            {
                picB8.Image = imageList1.Images[1];
                i++;
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
            else if (i == 2)
            {
                picB8.Image = imageList1.Images[3];
                i++;
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
            else if (i == 4)
            {
                picB8.Image = imageList1.Images[5];
                i++;
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
            else if (i == 6)
            {
                picB8.Image = imageList2.Images[0];
                i++;
                timer2.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                picB8.Image = imageList1.Images[2];
                i++;
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
            else if (i == 3)
            {
                picB8.Image = imageList1.Images[4];
                i++;
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
            else if (i == 5)
            {
                picB8.Image = imageList1.Images[6];
                i++;
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
            else if (i == 7)
            {
                picB8.Image = imageList1.Images[0];
                i = 0;
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void picB0_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB0.Image;
            picform.Show();

        }

        private void picB1_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB1.Image;
            picform.Show();
        }

        private void picB2_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB2.Image;
            picform.Show();
        }
        private void picB3_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB3.Image;
            picform.Show();
        }

        private void picB4_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB4.Image;
            picform.Show();
        }

        private void picB5_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB5.Image;
            picform.Show();
        }

        private void picB6_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB6.Image;
            picform.Show();
        }

        private void picB7_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB7.Image;
            picform.Show();
        }

        private void picB8_Click(object sender, EventArgs e)
        {
            _14HwPicForm picform = new _14HwPicForm();
            picform.picShow.Image = picB8.Image;
            picform.Show();
        }
    }
}