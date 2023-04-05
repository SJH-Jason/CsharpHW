namespace CsharpHomework
{
    partial class _16HwAlarm
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
            this.labTime = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.nummin = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.labh = new System.Windows.Forms.Label();
            this.labM = new System.Windows.Forms.Label();
            this.labS = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.SuspendLayout();
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTime.Location = new System.Drawing.Point(37, 64);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(95, 42);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "Time";
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(40, 160);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(43, 23);
            this.numHour.TabIndex = 1;
            // 
            // nummin
            // 
            this.nummin.Location = new System.Drawing.Point(120, 160);
            this.nummin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nummin.Name = "nummin";
            this.nummin.Size = new System.Drawing.Size(43, 23);
            this.nummin.TabIndex = 2;
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(200, 160);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(43, 23);
            this.numSec.TabIndex = 3;
            // 
            // labh
            // 
            this.labh.AutoSize = true;
            this.labh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labh.Location = new System.Drawing.Point(90, 160);
            this.labh.Name = "labh";
            this.labh.Size = new System.Drawing.Size(26, 21);
            this.labh.TabIndex = 4;
            this.labh.Text = "時";
            // 
            // labM
            // 
            this.labM.AutoSize = true;
            this.labM.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labM.Location = new System.Drawing.Point(170, 160);
            this.labM.Name = "labM";
            this.labM.Size = new System.Drawing.Size(26, 21);
            this.labM.TabIndex = 5;
            this.labM.Text = "分";
            // 
            // labS
            // 
            this.labS.AutoSize = true;
            this.labS.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labS.Location = new System.Drawing.Point(250, 160);
            this.labS.Name = "labS";
            this.labS.Size = new System.Drawing.Size(26, 21);
            this.labS.TabIndex = 6;
            this.labS.Text = "秒";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(42, 222);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(82, 57);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "設置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(161, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 57);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labSet
            // 
            this.labSet.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSet.Location = new System.Drawing.Point(295, 48);
            this.labSet.Name = "labSet";
            this.labSet.Size = new System.Drawing.Size(165, 231);
            this.labSet.TabIndex = 9;
            this.labSet.Text = "鬧鐘時間：";
            // 
            // _16HwAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.labSet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.labS);
            this.Controls.Add(this.labM);
            this.Controls.Add(this.labh);
            this.Controls.Add(this.numSec);
            this.Controls.Add(this.nummin);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.labTime);
            this.Name = "_16HwAlarm";
            this.Text = "_16HwAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labTime;
        private NumericUpDown numHour;
        private NumericUpDown nummin;
        private NumericUpDown numSec;
        private Label labh;
        private Label labM;
        private Label labS;
        private Button btnSet;
        private Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private Label labSet;
    }
}