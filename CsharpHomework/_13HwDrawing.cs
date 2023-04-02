using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CsharpHomework
{
    public partial class _13HwDrawing : Form
    {
        public _13HwDrawing()
        {
            InitializeComponent();
        }

        private Pen myPen = new Pen(Color.Black, 1);
        int x0, y0;

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog1.Color;
                labColor.BackColor = colorDialog1.Color;
            }
        }

        private void trbPen_Scroll(object sender, EventArgs e)
        {
            labPen.Text = trbPen.Value.ToString();
            myPen.Width = trbPen.Value;
        }

        private void _13HwDrawing_Load(object sender, EventArgs e)
        {
            開新檔案ToolStripMenuItem_Click(sender, e);
        }

        private void 開新檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ptbwhite.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(ptbwhite.Image);
            g.Clear(Color.White);
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptbwhite.Load(openFileDialog1.FileName);
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ptbwhite.Image);
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void ptbwhite_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void ptbwhite_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(ptbwhite.Image);
                g.DrawLine(myPen, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                ptbwhite.Refresh();
            }
        }
    }
}

