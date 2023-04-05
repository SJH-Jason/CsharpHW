namespace CsharpHomework
{
    partial class _15HwGuessNumber
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
            this.btnG = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.labQ = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labQ2 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btnE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(296, 139);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(200, 200);
            this.btnG.TabIndex = 0;
            this.btnG.Text = "猜數字";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(31, 239);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(200, 100);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "投降區";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // labQ
            // 
            this.labQ.AutoSize = true;
            this.labQ.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labQ.Location = new System.Drawing.Point(31, 32);
            this.labQ.Name = "labQ";
            this.labQ.Size = new System.Drawing.Size(202, 84);
            this.labQ.TabIndex = 2;
            this.labQ.Text = "猜數字遊戲：\r\n請輸入１～１００的數字！\r\n將會提示數字範圍！\r\n直到猜中數字為獲勝！";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labQ2);
            this.panel1.Controls.Add(this.txtAns);
            this.panel1.Controls.Add(this.btnE);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Location = new System.Drawing.Point(571, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 129);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // labQ2
            // 
            this.labQ2.AutoSize = true;
            this.labQ2.Location = new System.Drawing.Point(14, 19);
            this.labQ2.Name = "labQ2";
            this.labQ2.Size = new System.Drawing.Size(67, 15);
            this.labQ2.TabIndex = 3;
            this.labQ2.Text = "請輸入數字";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(11, 72);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(78, 23);
            this.txtAns.TabIndex = 2;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(118, 78);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(72, 32);
            this.btnE.TabIndex = 1;
            this.btnE.Text = "Enter";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(118, 40);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(72, 32);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "Cancel";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // _15HwGuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labQ);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnG);
            this.Name = "_15HwGuessNumber";
            this.Text = "_15HwGuessNumber";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button btnG;
        public Button btnA;
        public Label labQ;
        private Panel panel1;
        private Button btnC;
        private Label labQ2;
        private TextBox txtAns;
        private Button btnE;
    }
}