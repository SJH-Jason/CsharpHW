namespace CsharpHomework
{
    partial class _11ScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.picpoke249 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picpoke249)).BeginInit();
            this.SuspendLayout();
            // 
            // picpoke249
            // 
            this.picpoke249.BackColor = System.Drawing.Color.Transparent;
            this.picpoke249.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picpoke249.Image = global::CsharpHomework.Properties.Resources._2491;
            this.picpoke249.Location = new System.Drawing.Point(0, 0);
            this.picpoke249.Name = "picpoke249";
            this.picpoke249.Size = new System.Drawing.Size(400, 300);
            this.picpoke249.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpoke249.TabIndex = 0;
            this.picpoke249.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTime.ForeColor = System.Drawing.Color.Yellow;
            this.labTime.Location = new System.Drawing.Point(12, 360);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(375, 81);
            this.labTime.TabIndex = 1;
            this.labTime.Text = "C#保護程式";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            // 
            // _11ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.picpoke249);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_11ScreenSaver";
            this.Text = "_11ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._11ScreenSaver_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._11ScreenSaver_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._11ScreenSaver_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._11ScreenSaver_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picpoke249)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picpoke249;
        private System.Windows.Forms.Timer timer1;
        private Label labTime;
        private System.Windows.Forms.Timer timer2;
    }
}