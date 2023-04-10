using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CsharpHomework
{
    public partial class _12HwNotepad : Form
    {
        public _12HwNotepad()
        {
            InitializeComponent();
        }

        private void _12HwNotepad_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //labTime.Text = DateTime.Now.ToString();
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("HH:mm:ss");
            toolTime.Text = timeString;
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.Paste();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            txtword.Clear();
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void 開啟OToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtword.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtword.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog.FileName, txtword.Text, Encoding.Default);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtword.Text);
            }
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此版本為家航C#作業1.0版本請安心使用!");
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            txtword.Clear();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtword.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtword.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(openFileDialog.FileName, txtword.Text, Encoding.Default);
            }
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            txtword.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            txtword.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            txtword.Paste();
        }

        private void 結束XToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.SelectAll();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此版本為家航C#作業1.0版本請安心使用!");
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 將所選顏色設定給Button的ForeColor屬性
                txtword.ForeColor = colorDialog.Color;
            }
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtword.Font = fontDialog.Font;
            }
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtword.WordWrap == true)
            {
                txtword.WordWrap = false;
            }
            else
            {
                txtword.WordWrap = true;
            }
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.ForeColor = Color.Red;
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.ForeColor = Color.Blue;
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.ForeColor = Color.Black;
        }
        private void 紫色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtword.ForeColor = Color.Purple;
        }

        private void toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = txtword.SelectedText;
            txtword.SelectedText = selectedText.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = txtword.SelectedText;
            txtword.SelectedText = selectedText.ToLower();
        }
    }
}
