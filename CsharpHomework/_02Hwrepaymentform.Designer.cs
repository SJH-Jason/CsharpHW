namespace  CsharpHomework
{
    partial class _02Hwrepaymentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_02Hwrepaymentform));
            this.monthpay = new System.Windows.Forms.Button();
            this.totalpay = new System.Windows.Forms.Button();
            this.showinf = new System.Windows.Forms.Button();
            this.Loanamount = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.interestrate = new System.Windows.Forms.Label();
            this.downpayment = new System.Windows.Forms.Label();
            this.LoanamountBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.interestrateBox = new System.Windows.Forms.TextBox();
            this.downpaymentBox = new System.Windows.Forms.TextBox();
            this.labmonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthpay
            // 
            this.monthpay.Location = new System.Drawing.Point(124, 307);
            this.monthpay.Name = "monthpay";
            this.monthpay.Size = new System.Drawing.Size(87, 49);
            this.monthpay.TabIndex = 0;
            this.monthpay.Text = "月繳";
            this.monthpay.UseVisualStyleBackColor = true;
            this.monthpay.Click += new System.EventHandler(this.monthpay_Click);
            // 
            // totalpay
            // 
            this.totalpay.Location = new System.Drawing.Point(294, 307);
            this.totalpay.Name = "totalpay";
            this.totalpay.Size = new System.Drawing.Size(87, 49);
            this.totalpay.TabIndex = 1;
            this.totalpay.Text = "總付額";
            this.totalpay.UseVisualStyleBackColor = true;
            this.totalpay.Click += new System.EventHandler(this.totalpay_Click);
            // 
            // showinf
            // 
            this.showinf.Location = new System.Drawing.Point(463, 307);
            this.showinf.Name = "showinf";
            this.showinf.Size = new System.Drawing.Size(87, 49);
            this.showinf.TabIndex = 2;
            this.showinf.Text = "顯示內容";
            this.showinf.UseVisualStyleBackColor = true;
            this.showinf.Click += new System.EventHandler(this.showinf_Click);
            // 
            // Loanamount
            // 
            this.Loanamount.AutoSize = true;
            this.Loanamount.BackColor = System.Drawing.Color.Transparent;
            this.Loanamount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Loanamount.Location = new System.Drawing.Point(73, 72);
            this.Loanamount.Name = "Loanamount";
            this.Loanamount.Size = new System.Drawing.Size(74, 21);
            this.Loanamount.TabIndex = 3;
            this.Loanamount.Text = "貸款金額";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.Color.Transparent;
            this.Year.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Year.Location = new System.Drawing.Point(73, 120);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(70, 21);
            this.Year.TabIndex = 4;
            this.Year.Text = "期限(年)";
            this.Year.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // interestrate
            // 
            this.interestrate.AutoSize = true;
            this.interestrate.BackColor = System.Drawing.Color.Transparent;
            this.interestrate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.interestrate.Location = new System.Drawing.Point(73, 163);
            this.interestrate.Name = "interestrate";
            this.interestrate.Size = new System.Drawing.Size(42, 21);
            this.interestrate.TabIndex = 5;
            this.interestrate.Text = "利率";
            this.interestrate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // downpayment
            // 
            this.downpayment.AutoSize = true;
            this.downpayment.BackColor = System.Drawing.Color.Transparent;
            this.downpayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.downpayment.Location = new System.Drawing.Point(73, 212);
            this.downpayment.Name = "downpayment";
            this.downpayment.Size = new System.Drawing.Size(58, 21);
            this.downpayment.TabIndex = 6;
            this.downpayment.Text = "頭期款";
            this.downpayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LoanamountBox
            // 
            this.LoanamountBox.Location = new System.Drawing.Point(189, 72);
            this.LoanamountBox.Name = "LoanamountBox";
            this.LoanamountBox.ShortcutsEnabled = false;
            this.LoanamountBox.Size = new System.Drawing.Size(122, 22);
            this.LoanamountBox.TabIndex = 7;
            this.LoanamountBox.Text = "100000";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(189, 119);
            this.YearBox.Name = "YearBox";
            this.YearBox.ShortcutsEnabled = false;
            this.YearBox.Size = new System.Drawing.Size(122, 22);
            this.YearBox.TabIndex = 8;
            this.YearBox.Text = "2";
            // 
            // interestrateBox
            // 
            this.interestrateBox.Location = new System.Drawing.Point(189, 163);
            this.interestrateBox.Name = "interestrateBox";
            this.interestrateBox.ShortcutsEnabled = false;
            this.interestrateBox.Size = new System.Drawing.Size(122, 22);
            this.interestrateBox.TabIndex = 9;
            this.interestrateBox.Text = "5";
            // 
            // downpaymentBox
            // 
            this.downpaymentBox.Location = new System.Drawing.Point(189, 211);
            this.downpaymentBox.Name = "downpaymentBox";
            this.downpaymentBox.ShortcutsEnabled = false;
            this.downpaymentBox.Size = new System.Drawing.Size(122, 22);
            this.downpaymentBox.TabIndex = 10;
            this.downpaymentBox.Text = "0";
            // 
            // labmonth
            // 
            this.labmonth.AutoSize = true;
            this.labmonth.BackColor = System.Drawing.Color.Transparent;
            this.labmonth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labmonth.ForeColor = System.Drawing.Color.Transparent;
            this.labmonth.Location = new System.Drawing.Point(137, 373);
            this.labmonth.Name = "labmonth";
            this.labmonth.Size = new System.Drawing.Size(0, 21);
            this.labmonth.TabIndex = 11;
            this.labmonth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // repaymentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labmonth);
            this.Controls.Add(this.downpaymentBox);
            this.Controls.Add(this.interestrateBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.LoanamountBox);
            this.Controls.Add(this.downpayment);
            this.Controls.Add(this.interestrate);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Loanamount);
            this.Controls.Add(this.showinf);
            this.Controls.Add(this.totalpay);
            this.Controls.Add(this.monthpay);
            this.Name = "repaymentform";
            this.Text = "還款試算表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthpay;
        private System.Windows.Forms.Button totalpay;
        private System.Windows.Forms.Button showinf;
        private System.Windows.Forms.Label Loanamount;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label interestrate;
        private System.Windows.Forms.Label downpayment;
        private System.Windows.Forms.TextBox LoanamountBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox interestrateBox;
        private System.Windows.Forms.TextBox downpaymentBox;
        private System.Windows.Forms.Label labmonth;
    }
}