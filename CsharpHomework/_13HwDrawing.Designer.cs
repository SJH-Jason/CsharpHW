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
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labColor = new System.Windows.Forms.Label();
            this.trbPen = new System.Windows.Forms.TrackBar();
            this.labPen = new System.Windows.Forms.Label();
            this.ptbwhite = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開新檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟舊檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trbPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbwhite)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(717, 40);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(65, 39);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // labColor
            // 
            this.labColor.BackColor = System.Drawing.Color.Black;
            this.labColor.Location = new System.Drawing.Point(717, 99);
            this.labColor.Name = "labColor";
            this.labColor.Size = new System.Drawing.Size(65, 24);
            this.labColor.TabIndex = 1;
            // 
            // trbPen
            // 
            this.trbPen.Location = new System.Drawing.Point(737, 137);
            this.trbPen.Maximum = 100;
            this.trbPen.Minimum = 1;
            this.trbPen.Name = "trbPen";
            this.trbPen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbPen.Size = new System.Drawing.Size(45, 180);
            this.trbPen.TabIndex = 3;
            this.trbPen.TickFrequency = 10;
            this.trbPen.Value = 1;
            this.trbPen.Scroll += new System.EventHandler(this.trbPen_Scroll);
            // 
            // labPen
            // 
            this.labPen.AutoSize = true;
            this.labPen.Location = new System.Drawing.Point(737, 320);
            this.labPen.Name = "labPen";
            this.labPen.Size = new System.Drawing.Size(14, 15);
            this.labPen.TabIndex = 4;
            this.labPen.Text = "1";
            // 
            // ptbwhite
            // 
            this.ptbwhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbwhite.Location = new System.Drawing.Point(0, 24);
            this.ptbwhite.Name = "ptbwhite";
            this.ptbwhite.Size = new System.Drawing.Size(800, 426);
            this.ptbwhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbwhite.TabIndex = 5;
            this.ptbwhite.TabStop = false;
            this.ptbwhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbwhite_MouseDown);
            this.ptbwhite.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbwhite_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開新檔案ToolStripMenuItem,
            this.開啟舊檔ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開新檔案ToolStripMenuItem
            // 
            this.開新檔案ToolStripMenuItem.Name = "開新檔案ToolStripMenuItem";
            this.開新檔案ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.開新檔案ToolStripMenuItem.Text = "開新檔案";
            this.開新檔案ToolStripMenuItem.Click += new System.EventHandler(this.開新檔案ToolStripMenuItem_Click);
            // 
            // 開啟舊檔ToolStripMenuItem
            // 
            this.開啟舊檔ToolStripMenuItem.Name = "開啟舊檔ToolStripMenuItem";
            this.開啟舊檔ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.開啟舊檔ToolStripMenuItem.Text = "開啟舊檔";
            this.開啟舊檔ToolStripMenuItem.Click += new System.EventHandler(this.開啟舊檔ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _13HwDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPen);
            this.Controls.Add(this.trbPen);
            this.Controls.Add(this.labColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.ptbwhite);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_13HwDrawing";
            this.Text = "_13HwDrawing";
            this.Load += new System.EventHandler(this._13HwDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbwhite)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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