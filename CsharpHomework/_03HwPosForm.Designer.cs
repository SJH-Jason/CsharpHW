namespace  CsharpHomework
{
    partial class _03HwPosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_03HwPosForm));
            this.labmenu = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.labTatle = new System.Windows.Forms.Label();
            this.labPay = new System.Windows.Forms.Label();
            this.labdis = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnG = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labmenu
            // 
            this.labmenu.BackColor = System.Drawing.Color.Lime;
            this.labmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labmenu.Location = new System.Drawing.Point(30, 53);
            this.labmenu.Name = "labmenu";
            this.labmenu.Size = new System.Drawing.Size(240, 280);
            this.labmenu.TabIndex = 0;
            this.labmenu.Text = "Memu";
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.Yellow;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Location = new System.Drawing.Point(522, 53);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(240, 280);
            this.labList.TabIndex = 1;
            this.labList.Text = "購買清單";
            // 
            // labTatle
            // 
            this.labTatle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labTatle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTatle.Location = new System.Drawing.Point(276, 53);
            this.labTatle.Name = "labTatle";
            this.labTatle.Size = new System.Drawing.Size(240, 120);
            this.labTatle.TabIndex = 2;
            this.labTatle.Text = "總金額";
            // 
            // labPay
            // 
            this.labPay.BackColor = System.Drawing.Color.Cyan;
            this.labPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPay.Location = new System.Drawing.Point(276, 213);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(240, 120);
            this.labPay.TabIndex = 3;
            this.labPay.Text = "付款方式";
            // 
            // labdis
            // 
            this.labdis.AutoSize = true;
            this.labdis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labdis.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labdis.Location = new System.Drawing.Point(412, 300);
            this.labdis.Name = "labdis";
            this.labdis.Size = new System.Drawing.Size(94, 23);
            this.labdis.TabIndex = 8;
            this.labdis.Text = "信用卡9折!";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Location = new System.Drawing.Point(299, 240);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(79, 44);
            this.btnCash.TabIndex = 9;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.Black;
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.ForeColor = System.Drawing.Color.White;
            this.btnCard.Location = new System.Drawing.Point(412, 240);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(81, 44);
            this.btnCard.TabIndex = 10;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(671, 279);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(81, 44);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "清除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtList
            // 
            this.txtList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtList.ForeColor = System.Drawing.Color.Maroon;
            this.txtList.Location = new System.Drawing.Point(536, 78);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.Size = new System.Drawing.Size(215, 188);
            this.txtList.TabIndex = 12;
            this.txtList.Text = "尚未選購";
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.Black;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(281, 91);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(225, 33);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Text = "NT$0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.White;
            this.btnG.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnG.ForeColor = System.Drawing.Color.Black;
            this.btnG.Image = ((System.Drawing.Image)(resources.GetObject("btnG.Image")));
            this.btnG.Location = new System.Drawing.Point(46, 91);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(100, 100);
            this.btnG.TabIndex = 14;
            this.btnG.Text = "妙蛙種子\r\n價格\r\n990";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.White;
            this.btnR.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnR.Image = ((System.Drawing.Image)(resources.GetObject("btnR.Image")));
            this.btnR.Location = new System.Drawing.Point(153, 91);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(100, 100);
            this.btnR.TabIndex = 15;
            this.btnR.Text = "小火龍\r\n價格\r\n1990";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.Location = new System.Drawing.Point(46, 213);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(100, 100);
            this.btnB.TabIndex = 16;
            this.btnB.Text = "傑尼龜\r\n價格\r\n880";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.White;
            this.btnY.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnY.Image = ((System.Drawing.Image)(resources.GetObject("btnY.Image")));
            this.btnY.Location = new System.Drawing.Point(153, 213);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(100, 100);
            this.btnY.TabIndex = 17;
            this.btnY.Text = "皮卡丘\r\n價格\r\n2990";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labdis);
            this.Controls.Add(this.labPay);
            this.Controls.Add(this.labTatle);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.labmenu);
            this.Name = "PosForm";
            this.Text = "POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labmenu;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Label labTatle;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.Label labdis;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnY;
    }
}