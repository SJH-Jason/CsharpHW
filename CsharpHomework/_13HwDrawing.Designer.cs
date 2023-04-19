namespace CsharpHomework
{
    partial class _13HwDrawing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnColor = new Button();
            colorDialog1 = new ColorDialog();
            labColor = new Label();
            trbPen = new TrackBar();
            labPen = new Label();
            ptbwhite = new PictureBox();
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開新檔案ToolStripMenuItem = new ToolStripMenuItem();
            開啟舊檔ToolStripMenuItem = new ToolStripMenuItem();
            另存新檔ToolStripMenuItem = new ToolStripMenuItem();
            結束ToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)trbPen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbwhite).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnColor.Location = new Point(717, 40);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(65, 39);
            btnColor.TabIndex = 0;
            btnColor.Text = "顏色";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // labColor
            // 
            labColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labColor.BackColor = Color.Black;
            labColor.Location = new Point(717, 99);
            labColor.Name = "labColor";
            labColor.Size = new Size(65, 24);
            labColor.TabIndex = 1;
            // 
            // trbPen
            // 
            trbPen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trbPen.Location = new Point(737, 137);
            trbPen.Maximum = 100;
            trbPen.Minimum = 1;
            trbPen.Name = "trbPen";
            trbPen.Orientation = Orientation.Vertical;
            trbPen.Size = new Size(45, 180);
            trbPen.TabIndex = 3;
            trbPen.TickFrequency = 10;
            trbPen.Value = 1;
            trbPen.Scroll += trbPen_Scroll;
            // 
            // labPen
            // 
            labPen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labPen.AutoSize = true;
            labPen.Location = new Point(737, 320);
            labPen.Name = "labPen";
            labPen.Size = new Size(14, 15);
            labPen.TabIndex = 4;
            labPen.Text = "1";
            // 
            // ptbwhite
            // 
            ptbwhite.Location = new Point(0, 24);
            ptbwhite.Name = "ptbwhite";
            ptbwhite.Size = new Size(800, 426);
            ptbwhite.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbwhite.TabIndex = 5;
            ptbwhite.TabStop = false;
            ptbwhite.MouseDown += ptbwhite_MouseDown;
            ptbwhite.MouseMove += ptbwhite_MouseMove;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開新檔案ToolStripMenuItem, 開啟舊檔ToolStripMenuItem, 另存新檔ToolStripMenuItem, 結束ToolStripMenuItem });
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(43, 20);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開新檔案ToolStripMenuItem
            // 
            開新檔案ToolStripMenuItem.Name = "開新檔案ToolStripMenuItem";
            開新檔案ToolStripMenuItem.Size = new Size(122, 22);
            開新檔案ToolStripMenuItem.Text = "開新檔案";
            開新檔案ToolStripMenuItem.Click += 開新檔案ToolStripMenuItem_Click;
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            開啟舊檔ToolStripMenuItem.Size = new Size(122, 22);
            開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
            開啟舊檔ToolStripMenuItem.Click += 開啟舊檔ToolStripMenuItem_Click;
            // 
            // 另存新檔ToolStripMenuItem
            // 
            另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            另存新檔ToolStripMenuItem.Size = new Size(122, 22);
            另存新檔ToolStripMenuItem.Text = "另存新檔";
            另存新檔ToolStripMenuItem.Click += 另存新檔ToolStripMenuItem_Click;
            // 
            // 結束ToolStripMenuItem
            // 
            結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            結束ToolStripMenuItem.Size = new Size(122, 22);
            結束ToolStripMenuItem.Text = "結束";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // _13HwDrawing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labPen);
            Controls.Add(trbPen);
            Controls.Add(labColor);
            Controls.Add(btnColor);
            Controls.Add(ptbwhite);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Cross;
            MainMenuStrip = menuStrip1;
            Name = "_13HwDrawing";
            Text = "_13HwDrawing";
            Load += _13HwDrawing_Load;
            ((System.ComponentModel.ISupportInitialize)trbPen).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbwhite).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnColor;
        private ColorDialog colorDialog1;
        private Label labColor;
        private TrackBar trbPen;
        private Label labPen;
        private PictureBox ptbwhite;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開新檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟舊檔ToolStripMenuItem;
        private ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private ToolStripMenuItem 結束ToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}