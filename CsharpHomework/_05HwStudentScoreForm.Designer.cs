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
            labName = new Label();
            txtName = new TextBox();
            labCn = new Label();
            labEn = new Label();
            labMath = new Label();
            txtCn = new TextBox();
            txtEn = new TextBox();
            txtMath = new TextBox();
            btnAdd = new Button();
            btnShow = new Button();
            btnRandom = new Button();
            btnrenew = new Button();
            btnRandom20 = new Button();
            btnIns = new Button();
            btnRemove = new Button();
            btnSer = new Button();
            palList = new Panel();
            labScoreList = new Label();
            labformheader = new Label();
            palShow = new Panel();
            labShow = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            labSerCn = new Label();
            List = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            palList.SuspendLayout();
            palShow.SuspendLayout();
            SuspendLayout();
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labName.Location = new Point(10, 10);
            labName.Name = "labName";
            labName.Size = new Size(58, 21);
            labName.TabIndex = 0;
            labName.Text = "姓名：";
            // 
            // txtName
            // 
            txtName.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(80, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(62, 29);
            txtName.TabIndex = 4;
            // 
            // labCn
            // 
            labCn.AutoSize = true;
            labCn.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labCn.Location = new Point(10, 50);
            labCn.Name = "labCn";
            labCn.Size = new Size(58, 21);
            labCn.TabIndex = 8;
            labCn.Text = "國文：";
            // 
            // labEn
            // 
            labEn.AutoSize = true;
            labEn.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labEn.Location = new Point(10, 90);
            labEn.Name = "labEn";
            labEn.Size = new Size(58, 21);
            labEn.TabIndex = 9;
            labEn.Text = "英文：";
            // 
            // labMath
            // 
            labMath.AutoSize = true;
            labMath.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labMath.Location = new Point(10, 130);
            labMath.Name = "labMath";
            labMath.Size = new Size(58, 21);
            labMath.TabIndex = 10;
            labMath.Text = "數學：";
            // 
            // txtCn
            // 
            txtCn.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCn.Location = new Point(80, 47);
            txtCn.Name = "txtCn";
            txtCn.Size = new Size(62, 29);
            txtCn.TabIndex = 11;
            // 
            // txtEn
            // 
            txtEn.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEn.Location = new Point(80, 87);
            txtEn.Name = "txtEn";
            txtEn.Size = new Size(62, 29);
            txtEn.TabIndex = 12;
            // 
            // txtMath
            // 
            txtMath.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMath.Location = new Point(80, 127);
            txtMath.Name = "txtMath";
            txtMath.Size = new Size(62, 29);
            txtMath.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(22, 171);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "加入學生資料";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnShow
            // 
            btnShow.Enabled = false;
            btnShow.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShow.Location = new Point(22, 207);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(120, 30);
            btnShow.TabIndex = 15;
            btnShow.Text = "各科統計";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnRandom
            // 
            btnRandom.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandom.Location = new Point(22, 243);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(120, 30);
            btnRandom.TabIndex = 16;
            btnRandom.Text = "隨機生成資料";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnrenew
            // 
            btnrenew.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnrenew.Location = new Point(22, 279);
            btnrenew.Name = "btnrenew";
            btnrenew.Size = new Size(120, 30);
            btnrenew.TabIndex = 17;
            btnrenew.Text = "清除資料";
            btnrenew.UseVisualStyleBackColor = true;
            btnrenew.Click += btnrenew_Click;
            // 
            // btnRandom20
            // 
            btnRandom20.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRandom20.Location = new Point(22, 315);
            btnRandom20.Name = "btnRandom20";
            btnRandom20.Size = new Size(120, 30);
            btnRandom20.TabIndex = 18;
            btnRandom20.Text = "隨機生20筆";
            btnRandom20.UseVisualStyleBackColor = true;
            btnRandom20.Click += btnRandom20_Click;
            // 
            // btnIns
            // 
            btnIns.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIns.Location = new Point(22, 351);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(120, 30);
            btnIns.TabIndex = 19;
            btnIns.Text = "插入儲存資料";
            btnIns.UseVisualStyleBackColor = true;
            btnIns.Click += btnIns_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(22, 387);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 30);
            btnRemove.TabIndex = 20;
            btnRemove.Text = "移除儲存資料";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSer
            // 
            btnSer.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSer.Location = new Point(22, 423);
            btnSer.Name = "btnSer";
            btnSer.Size = new Size(120, 30);
            btnSer.TabIndex = 21;
            btnSer.Text = "搜尋";
            btnSer.UseVisualStyleBackColor = true;
            btnSer.Click += btnSer_Click;
            // 
            // palList
            // 
            palList.AutoScroll = true;
            palList.BorderStyle = BorderStyle.Fixed3D;
            palList.Controls.Add(labScoreList);
            palList.Controls.Add(labformheader);
            palList.Font = new Font("新細明體", 9F, FontStyle.Regular, GraphicsUnit.Point);
            palList.Location = new Point(730, 24);
            palList.Name = "palList";
            palList.Size = new Size(515, 316);
            palList.TabIndex = 23;
            // 
            // labScoreList
            // 
            labScoreList.AutoSize = true;
            labScoreList.BorderStyle = BorderStyle.FixedSingle;
            labScoreList.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labScoreList.Location = new Point(3, 38);
            labScoreList.Name = "labScoreList";
            labScoreList.Size = new Size(2, 18);
            labScoreList.TabIndex = 27;
            // 
            // labformheader
            // 
            labformheader.AutoSize = true;
            labformheader.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labformheader.Location = new Point(3, 6);
            labformheader.Name = "labformheader";
            labformheader.Size = new Size(506, 21);
            labformheader.TabIndex = 26;
            labformheader.Text = "   姓名     國文     英文     數學          總和        平均        最低        最高        ";
            // 
            // palShow
            // 
            palShow.AutoScroll = true;
            palShow.BorderStyle = BorderStyle.Fixed3D;
            palShow.Controls.Add(labShow);
            palShow.Location = new Point(174, 352);
            palShow.Name = "palShow";
            palShow.Size = new Size(515, 214);
            palShow.TabIndex = 25;
            // 
            // labShow
            // 
            labShow.AutoSize = true;
            labShow.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labShow.Location = new Point(3, 6);
            labShow.Name = "labShow";
            labShow.Size = new Size(0, 20);
            labShow.TabIndex = 28;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNum1.Location = new Point(22, 486);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(50, 29);
            txtNum1.TabIndex = 26;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNum2.Location = new Point(92, 486);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(50, 29);
            txtNum2.TabIndex = 27;
            // 
            // labSerCn
            // 
            labSerCn.AutoSize = true;
            labSerCn.Font = new Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labSerCn.Location = new Point(22, 462);
            labSerCn.Name = "labSerCn";
            labSerCn.Size = new Size(106, 21);
            labSerCn.TabIndex = 28;
            labSerCn.Text = "國文分數範圍";
            // 
            // List
            // 
            List.BackColor = SystemColors.Control;
            List.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            List.Location = new Point(174, 24);
            List.Name = "List";
            List.Size = new Size(515, 321);
            List.TabIndex = 29;
            List.UseCompatibleStateImageBehavior = false;
            List.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "姓名";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "國文";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "英文";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "數學";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "總和";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "平均";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "最低";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "最高";
            // 
            // _05HwStudentScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 610);
            Controls.Add(List);
            Controls.Add(labSerCn);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(palShow);
            Controls.Add(palList);
            Controls.Add(btnSer);
            Controls.Add(btnRemove);
            Controls.Add(btnIns);
            Controls.Add(btnRandom20);
            Controls.Add(btnrenew);
            Controls.Add(btnRandom);
            Controls.Add(btnShow);
            Controls.Add(btnAdd);
            Controls.Add(txtMath);
            Controls.Add(txtEn);
            Controls.Add(txtCn);
            Controls.Add(labMath);
            Controls.Add(labEn);
            Controls.Add(labCn);
            Controls.Add(txtName);
            Controls.Add(labName);
            Name = "_05HwStudentScoreForm";
            Text = "_05HwStudentScoreForm";
            palList.ResumeLayout(false);
            palList.PerformLayout();
            palShow.ResumeLayout(false);
            palShow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ListView List;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}