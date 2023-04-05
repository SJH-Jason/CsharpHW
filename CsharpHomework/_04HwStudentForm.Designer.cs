namespace  CsharpHomework
{
    partial class _04HwStudentForm
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
            this.labCn = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnShowSave = new System.Windows.Forms.Button();
            this.GboxScore = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txttatle = new System.Windows.Forms.TextBox();
            this.txtMaxmin = new System.Windows.Forms.TextBox();
            this.btnMaxmin = new System.Windows.Forms.Button();
            this.GboxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(41, 45);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labCn
            // 
            this.labCn.AutoSize = true;
            this.labCn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCn.Location = new System.Drawing.Point(41, 91);
            this.labCn.Name = "labCn";
            this.labCn.Size = new System.Drawing.Size(67, 24);
            this.labCn.TabIndex = 1;
            this.labCn.Text = "國文：";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(41, 141);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(67, 24);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(41, 188);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(45, 241);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(89, 41);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "儲存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnShowSave
            // 
            this.btnShowSave.Location = new System.Drawing.Point(153, 241);
            this.btnShowSave.Name = "btnShowSave";
            this.btnShowSave.Size = new System.Drawing.Size(90, 41);
            this.btnShowSave.TabIndex = 5;
            this.btnShowSave.Text = "顯示儲存內容";
            this.btnShowSave.UseVisualStyleBackColor = true;
            this.btnShowSave.Click += new System.EventHandler(this.btnShowSave_Click);
            // 
            // GboxScore
            // 
            this.GboxScore.Controls.Add(this.txtMaxmin);
            this.GboxScore.Controls.Add(this.txttatle);
            this.GboxScore.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GboxScore.Location = new System.Drawing.Point(332, 45);
            this.GboxScore.Name = "GboxScore";
            this.GboxScore.Size = new System.Drawing.Size(247, 250);
            this.GboxScore.TabIndex = 6;
            this.GboxScore.TabStop = false;
            this.GboxScore.Text = "成績";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtCn
            // 
            this.txtCn.Location = new System.Drawing.Point(125, 91);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(93, 22);
            this.txtCn.TabIndex = 8;
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(125, 141);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(93, 22);
            this.txtEn.TabIndex = 9;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(125, 188);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(93, 22);
            this.txtMath.TabIndex = 10;
            // 
            // txttatle
            // 
            this.txttatle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttatle.Location = new System.Drawing.Point(6, 25);
            this.txttatle.Multiline = true;
            this.txttatle.Name = "txttatle";
            this.txttatle.ReadOnly = true;
            this.txttatle.Size = new System.Drawing.Size(235, 128);
            this.txttatle.TabIndex = 11;
            // 
            // txtMaxmin
            // 
            this.txtMaxmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMaxmin.Location = new System.Drawing.Point(6, 159);
            this.txtMaxmin.Multiline = true;
            this.txtMaxmin.Name = "txtMaxmin";
            this.txtMaxmin.ReadOnly = true;
            this.txtMaxmin.Size = new System.Drawing.Size(235, 74);
            this.txtMaxmin.TabIndex = 12;
            // 
            // btnMaxmin
            // 
            this.btnMaxmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxmin.Location = new System.Drawing.Point(391, 301);
            this.btnMaxmin.Name = "btnMaxmin";
            this.btnMaxmin.Size = new System.Drawing.Size(169, 55);
            this.btnMaxmin.TabIndex = 11;
            this.btnMaxmin.Text = "最高分與最低分科目";
            this.btnMaxmin.UseVisualStyleBackColor = true;
            this.btnMaxmin.Click += new System.EventHandler(this.btnMaxmin_Click);
            // 
            // Student1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.btnMaxmin);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEn);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.GboxScore);
            this.Controls.Add(this.btnShowSave);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labCn);
            this.Controls.Add(this.labName);
            this.Name = "Student1";
            this.Text = "Student1";
            this.GboxScore.ResumeLayout(false);
            this.GboxScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCn;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnShowSave;
        private System.Windows.Forms.GroupBox GboxScore;
        private System.Windows.Forms.TextBox txtMaxmin;
        private System.Windows.Forms.TextBox txttatle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCn;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnMaxmin;
    }
}