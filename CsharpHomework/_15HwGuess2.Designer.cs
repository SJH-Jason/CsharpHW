namespace CsharpHomework
{
    partial class _15HwGuess2
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
            this.labQ = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labQ
            // 
            this.labQ.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labQ.ForeColor = System.Drawing.Color.Black;
            this.labQ.Location = new System.Drawing.Point(12, 22);
            this.labQ.Name = "labQ";
            this.labQ.Size = new System.Drawing.Size(190, 83);
            this.labQ.TabIndex = 0;
            this.labQ.Text = "請輸入你要猜的數字!";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum.Location = new System.Drawing.Point(12, 108);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(206, 29);
            this.txtNum.TabIndex = 1;
            // 
            // btnE
            // 
            this.btnE.ForeColor = System.Drawing.Color.Black;
            this.btnE.Location = new System.Drawing.Point(242, 90);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(80, 47);
            this.btnE.TabIndex = 2;
            this.btnE.Text = "Enter";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnC
            // 
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Location = new System.Drawing.Point(242, 22);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(80, 47);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Cancel";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // _15HwGuess2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 162);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.labQ);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_15HwGuess2";
            this.ShowIcon = false;
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox txtNum;
        public Label labQ;
        public Button btnE;
        public Button btnC;
    }
}