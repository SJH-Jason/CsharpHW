namespace CsharpHomework
{
    partial class _05HwStudentScoreForm
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labCn = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnrenew = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSer = new System.Windows.Forms.Button();
            this.palList = new System.Windows.Forms.Panel();
            this.labScoreList = new System.Windows.Forms.Label();
            this.labformheader = new System.Windows.Forms.Label();
            this.palShow = new System.Windows.Forms.Panel();
            this.labShow = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labSerCn = new System.Windows.Forms.Label();
            this.palList.SuspendLayout();
            this.palShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labName.Location = new System.Drawing.Point(10, 10);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(58, 21);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(80, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(62, 29);
            this.txtName.TabIndex = 4;
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCn.Location = new System.Drawing.Point(10, 50);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(58, 21);
            this.labCn.TabIndex = 8;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labEn.Location = new System.Drawing.Point(10, 90);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(58, 21);
            this.labEn.TabIndex = 9;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labMath.Location = new System.Drawing.Point(10, 130);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(58, 21);
            this.labMath.TabIndex = 10;
            this.labMath.Text = "數學：";
            // 
            // txtCn
            // 
            this.txtCn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCn.Location = new System.Drawing.Point(80, 47);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(62, 29);
            this.txtCn.TabIndex = 11;
            // 
            // txtEn
            // 
            this.txtEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEn.Location = new System.Drawing.Point(80, 87);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(62, 29);
            this.txtEn.TabIndex = 12;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMath.Location = new System.Drawing.Point(80, 127);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(62, 29);
            this.txtMath.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(22, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShow.Location = new System.Drawing.Point(22, 207);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 30);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "各科統計";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandom.Location = new System.Drawing.Point(22, 243);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(120, 30);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "隨機生成資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnrenew
            // 
            this.btnrenew.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrenew.Location = new System.Drawing.Point(22, 279);
            this.btnrenew.Name = "btnrenew";
            this.btnrenew.Size = new System.Drawing.Size(120, 30);
            this.btnrenew.TabIndex = 17;
            this.btnrenew.Text = "清除資料";
            this.btnrenew.UseVisualStyleBackColor = true;
            this.btnrenew.Click += new System.EventHandler(this.btnrenew_Click);
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandom20.Location = new System.Drawing.Point(22, 315);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(120, 30);
            this.btnRandom20.TabIndex = 18;
            this.btnRandom20.Text = "隨機生20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // btnIns
            // 
            this.btnIns.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIns.Location = new System.Drawing.Point(22, 351);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(120, 30);
            this.btnIns.TabIndex = 19;
            this.btnIns.Text = "插入儲存資料";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(22, 387);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 30);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "移除儲存資料";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSer
            // 
            this.btnSer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSer.Location = new System.Drawing.Point(22, 423);
            this.btnSer.Name = "btnSer";
            this.btnSer.Size = new System.Drawing.Size(120, 30);
            this.btnSer.TabIndex = 21;
            this.btnSer.Text = "搜尋";
            this.btnSer.UseVisualStyleBackColor = true;
            this.btnSer.Click += new System.EventHandler(this.btnSer_Click);
            // 
            // palList
            // 
            this.palList.AutoScroll = true;
            this.palList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palList.Controls.Add(this.labScoreList);
            this.palList.Controls.Add(this.labformheader);
            this.palList.Location = new System.Drawing.Point(174, 7);
            this.palList.Name = "palList";
            this.palList.Size = new System.Drawing.Size(515, 316);
            this.palList.TabIndex = 23;
            // 
            // labScoreList
            // 
            this.labScoreList.AutoSize = true;
            this.labScoreList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labScoreList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labScoreList.Location = new System.Drawing.Point(3, 38);
            this.labScoreList.Name = "labScoreList";
            this.labScoreList.Size = new System.Drawing.Size(2, 22);
            this.labScoreList.TabIndex = 27;
            // 
            // labformheader
            // 
            this.labformheader.AutoSize = true;
            this.labformheader.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labformheader.Location = new System.Drawing.Point(3, 6);
            this.labformheader.Name = "labformheader";
            this.labformheader.Size = new System.Drawing.Size(506, 21);
            this.labformheader.TabIndex = 26;
            this.labformheader.Text = "   姓名     國文     英文     數學          總和        平均        最低        最高        ";
            // 
            // palShow
            // 
            this.palShow.AutoScroll = true;
            this.palShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palShow.Controls.Add(this.labShow);
            this.palShow.Location = new System.Drawing.Point(174, 352);
            this.palShow.Name = "palShow";
            this.palShow.Size = new System.Drawing.Size(515, 214);
            this.palShow.TabIndex = 25;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labShow.Location = new System.Drawing.Point(3, 6);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(0, 20);
            this.labShow.TabIndex = 28;
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.Location = new System.Drawing.Point(22, 486);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(50, 29);
            this.txtNum1.TabIndex = 26;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.Location = new System.Drawing.Point(92, 486);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(50, 29);
            this.txtNum2.TabIndex = 27;
            // 
            // labSerCn
            // 
            this.labSerCn.AutoSize = true;
            this.labSerCn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSerCn.Location = new System.Drawing.Point(22, 462);
            this.labSerCn.Name = "labSerCn";
            this.labSerCn.Size = new System.Drawing.Size(106, 21);
            this.labSerCn.TabIndex = 28;
            this.labSerCn.Text = "國文分數範圍";
            // 
            // _05HwStudentScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 610);
            this.Controls.Add(this.labSerCn);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.palShow);
            this.Controls.Add(this.palList);
            this.Controls.Add(this.btnSer);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnrenew);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "_05HwStudentScoreForm";
            this.Text = "_05HwStudentScoreForm";
            this.palList.ResumeLayout(false);
            this.palList.PerformLayout();
            this.palShow.ResumeLayout(false);
            this.palShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labName;
        private TextBox txtName;
        private Label labCn;
        private Label labEn;
        private Label labMath;
        private TextBox txtCn;
        private TextBox txtEn;
        private TextBox txtMath;
        private Button btnAdd;
        private Button btnShow;
        private Button btnRandom;
        private Button btnrenew;
        private Button btnRandom20;
        private Button btnIns;
        private Button btnRemove;
        private Button btnSer;
        private Panel palList;
        private Label labformheader;
        private Panel palShow;
        private Label labScoreList;
        private Label labShow;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label labSerCn;
    }
}