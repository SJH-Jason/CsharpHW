using System.Drawing;

namespace Lab_Form
{
    partial class _01HwHelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labenName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labSign = new System.Windows.Forms.Label();
            this.txtenName = new System.Windows.Forms.TextBox();
            this.btnHi = new System.Windows.Forms.Button();
            this.pit1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbSign = new System.Windows.Forms.ComboBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.SystemColors.Control;
            this.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHello.Location = new System.Drawing.Point(216, 394);
            this.btnHello.Margin = new System.Windows.Forms.Padding(4);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(180, 62);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say!Hello!";
            this.btnHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 91);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 23);
            this.txtName.TabIndex = 1;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labName.Location = new System.Drawing.Point(71, 92);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(106, 21);
            this.labName.TabIndex = 2;
            this.labName.Text = "請輸入姓名：";
            this.labName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labenName
            // 
            this.labenName.AutoSize = true;
            this.labenName.BackColor = System.Drawing.Color.Transparent;
            this.labenName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labenName.Location = new System.Drawing.Point(71, 169);
            this.labenName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labenName.Name = "labenName";
            this.labenName.Size = new System.Drawing.Size(131, 21);
            this.labenName.TabIndex = 3;
            this.labenName.Text = "English Name：";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSex.Location = new System.Drawing.Point(71, 245);
            this.labSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(106, 21);
            this.labSex.TabIndex = 4;
            this.labSex.Text = "請輸入性別：";
            // 
            // labSign
            // 
            this.labSign.AutoSize = true;
            this.labSign.BackColor = System.Drawing.Color.Transparent;
            this.labSign.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSign.Location = new System.Drawing.Point(71, 311);
            this.labSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSign.Name = "labSign";
            this.labSign.Size = new System.Drawing.Size(106, 21);
            this.labSign.TabIndex = 5;
            this.labSign.Text = "請輸入星座：";
            // 
            // txtenName
            // 
            this.txtenName.Location = new System.Drawing.Point(216, 168);
            this.txtenName.Margin = new System.Windows.Forms.Padding(4);
            this.txtenName.Name = "txtenName";
            this.txtenName.Size = new System.Drawing.Size(179, 23);
            this.txtenName.TabIndex = 6;
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.SystemColors.Control;
            this.btnHi.FlatAppearance.BorderSize = 0;
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHi.Location = new System.Drawing.Point(438, 394);
            this.btnHi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(180, 62);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say!Hi!";
            this.btnHi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHi.UseVisualStyleBackColor = false;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // pit1
            // 
            this.pit1.AccessibleName = "";
            this.pit1.BackgroundImage = global::CsharpHomework.Properties.Resources._11;
            this.pit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pit1.InitialImage = null;
            this.pit1.Location = new System.Drawing.Point(219, 396);
            this.pit1.Margin = new System.Windows.Forms.Padding(4);
            this.pit1.Name = "pit1";
            this.pit1.Size = new System.Drawing.Size(52, 56);
            this.pit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pit1.TabIndex = 10;
            this.pit1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackgroundImage = global::CsharpHomework.Properties.Resources._11;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(442, 398);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Location = new System.Drawing.Point(216, 243);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(187, 23);
            this.cmbSex.TabIndex = 12;
            this.cmbSex.Text = "性別";
            // 
            // cmbSign
            // 
            this.cmbSign.FormattingEnabled = true;
            this.cmbSign.Location = new System.Drawing.Point(216, 309);
            this.cmbSign.Name = "cmbSign";
            this.cmbSign.Size = new System.Drawing.Size(187, 23);
            this.cmbSign.TabIndex = 13;
            this.cmbSign.Text = "星座";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(438, 243);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(179, 23);
            this.txtSex.TabIndex = 14;
            // 
            // txtSign
            // 
            this.txtSign.Location = new System.Drawing.Point(438, 309);
            this.txtSign.Margin = new System.Windows.Forms.Padding(4);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(179, 23);
            this.txtSign.TabIndex = 15;
            // 
            // _01HwHelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CsharpHomework.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(713, 538);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.cmbSign);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pit1);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.txtenName);
            this.Controls.Add(this.labSign);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labenName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHello);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_01HwHelloForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hello Form";
            this.Load += new System.EventHandler(this.Homework01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labenName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labSign;
        private System.Windows.Forms.TextBox txtenName;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.PictureBox pit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComboBox cmbSex;
        private ComboBox cmbSign;
        private TextBox txtSex;
        private TextBox txtSign;
    }
}

