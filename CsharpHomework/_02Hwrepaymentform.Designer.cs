namespace CsharpHomework
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
            monthpay = new Button();
            totalpay = new Button();
            showinf = new Button();
            Loanamount = new Label();
            Year = new Label();
            interestrate = new Label();
            downpayment = new Label();
            LoanamountBox = new TextBox();
            YearBox = new TextBox();
            interestrateBox = new TextBox();
            downpaymentBox = new TextBox();
            labmonth = new Label();
            SuspendLayout();
            // 
            // monthpay
            // 
            monthpay.Location = new Point(145, 384);
            monthpay.Margin = new Padding(4, 4, 4, 4);
            monthpay.Name = "monthpay";
            monthpay.Size = new Size(102, 61);
            monthpay.TabIndex = 0;
            monthpay.Text = "月繳";
            monthpay.UseVisualStyleBackColor = true;
            monthpay.Click += monthpay_Click;
            // 
            // totalpay
            // 
            totalpay.Location = new Point(343, 384);
            totalpay.Margin = new Padding(4, 4, 4, 4);
            totalpay.Name = "totalpay";
            totalpay.Size = new Size(102, 61);
            totalpay.TabIndex = 1;
            totalpay.Text = "總付額";
            totalpay.UseVisualStyleBackColor = true;
            totalpay.Click += totalpay_Click;
            // 
            // showinf
            // 
            showinf.Location = new Point(540, 384);
            showinf.Margin = new Padding(4, 4, 4, 4);
            showinf.Name = "showinf";
            showinf.Size = new Size(102, 61);
            showinf.TabIndex = 2;
            showinf.Text = "顯示內容";
            showinf.UseVisualStyleBackColor = true;
            showinf.Click += showinf_Click;
            // 
            // Loanamount
            // 
            Loanamount.AutoSize = true;
            Loanamount.BackColor = Color.Transparent;
            Loanamount.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Loanamount.Location = new Point(85, 90);
            Loanamount.Margin = new Padding(4, 0, 4, 0);
            Loanamount.Name = "Loanamount";
            Loanamount.Size = new Size(74, 21);
            Loanamount.TabIndex = 3;
            Loanamount.Text = "貸款金額";
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.BackColor = Color.Transparent;
            Year.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Year.Location = new Point(85, 150);
            Year.Margin = new Padding(4, 0, 4, 0);
            Year.Name = "Year";
            Year.Size = new Size(70, 21);
            Year.TabIndex = 4;
            Year.Text = "期限(年)";
            Year.TextAlign = ContentAlignment.BottomCenter;
            // 
            // interestrate
            // 
            interestrate.AutoSize = true;
            interestrate.BackColor = Color.Transparent;
            interestrate.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            interestrate.Location = new Point(85, 204);
            interestrate.Margin = new Padding(4, 0, 4, 0);
            interestrate.Name = "interestrate";
            interestrate.Size = new Size(42, 21);
            interestrate.TabIndex = 5;
            interestrate.Text = "利率";
            interestrate.TextAlign = ContentAlignment.BottomCenter;
            // 
            // downpayment
            // 
            downpayment.AutoSize = true;
            downpayment.BackColor = Color.Transparent;
            downpayment.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            downpayment.Location = new Point(85, 265);
            downpayment.Margin = new Padding(4, 0, 4, 0);
            downpayment.Name = "downpayment";
            downpayment.Size = new Size(58, 21);
            downpayment.TabIndex = 6;
            downpayment.Text = "頭期款";
            downpayment.TextAlign = ContentAlignment.BottomCenter;
            // 
            // LoanamountBox
            // 
            LoanamountBox.Location = new Point(220, 90);
            LoanamountBox.Margin = new Padding(4, 4, 4, 4);
            LoanamountBox.Name = "LoanamountBox";
            LoanamountBox.ShortcutsEnabled = false;
            LoanamountBox.Size = new Size(142, 23);
            LoanamountBox.TabIndex = 7;
            LoanamountBox.Text = "100000";
            // 
            // YearBox
            // 
            YearBox.Location = new Point(220, 149);
            YearBox.Margin = new Padding(4, 4, 4, 4);
            YearBox.Name = "YearBox";
            YearBox.ShortcutsEnabled = false;
            YearBox.Size = new Size(142, 23);
            YearBox.TabIndex = 8;
            YearBox.Text = "2";
            // 
            // interestrateBox
            // 
            interestrateBox.Location = new Point(220, 204);
            interestrateBox.Margin = new Padding(4, 4, 4, 4);
            interestrateBox.Name = "interestrateBox";
            interestrateBox.ShortcutsEnabled = false;
            interestrateBox.Size = new Size(142, 23);
            interestrateBox.TabIndex = 9;
            interestrateBox.Text = "5";
            // 
            // downpaymentBox
            // 
            downpaymentBox.Location = new Point(220, 264);
            downpaymentBox.Margin = new Padding(4, 4, 4, 4);
            downpaymentBox.Name = "downpaymentBox";
            downpaymentBox.ShortcutsEnabled = false;
            downpaymentBox.Size = new Size(142, 23);
            downpaymentBox.TabIndex = 10;
            downpaymentBox.Text = "0";
            // 
            // labmonth
            // 
            labmonth.AutoSize = true;
            labmonth.BackColor = Color.Transparent;
            labmonth.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labmonth.ForeColor = Color.Transparent;
            labmonth.Location = new Point(160, 466);
            labmonth.Margin = new Padding(4, 0, 4, 0);
            labmonth.Name = "labmonth";
            labmonth.Size = new Size(0, 21);
            labmonth.TabIndex = 11;
            labmonth.TextAlign = ContentAlignment.BottomCenter;
            // 
            // _02Hwrepaymentform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(742, 502);
            Controls.Add(labmonth);
            Controls.Add(downpaymentBox);
            Controls.Add(interestrateBox);
            Controls.Add(YearBox);
            Controls.Add(LoanamountBox);
            Controls.Add(downpayment);
            Controls.Add(interestrate);
            Controls.Add(Year);
            Controls.Add(Loanamount);
            Controls.Add(showinf);
            Controls.Add(totalpay);
            Controls.Add(monthpay);
            Margin = new Padding(4, 4, 4, 4);
            Name = "_02Hwrepaymentform";
            Text = "還款試算表";
            ResumeLayout(false);
            PerformLayout();
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