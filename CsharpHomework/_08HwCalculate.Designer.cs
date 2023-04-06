namespace CsharpHomework
{
    partial class _08Hwcalculate
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
            this.labnum1 = new System.Windows.Forms.Label();
            this.labnum2 = new System.Windows.Forms.Label();
            this.labsymbol = new System.Windows.Forms.Label();
            this.labanswer = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtans = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnmultiplication = new System.Windows.Forms.Button();
            this.btnsubtraction = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labnum1
            // 
            this.labnum1.AutoSize = true;
            this.labnum1.Location = new System.Drawing.Point(62, 82);
            this.labnum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnum1.Name = "labnum1";
            this.labnum1.Size = new System.Drawing.Size(39, 15);
            this.labnum1.TabIndex = 0;
            this.labnum1.Text = "num1";
            // 
            // labnum2
            // 
            this.labnum2.AutoSize = true;
            this.labnum2.Location = new System.Drawing.Point(62, 134);
            this.labnum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnum2.Name = "labnum2";
            this.labnum2.Size = new System.Drawing.Size(39, 15);
            this.labnum2.TabIndex = 1;
            this.labnum2.Text = "num2";
            // 
            // labsymbol
            // 
            this.labsymbol.AutoSize = true;
            this.labsymbol.Location = new System.Drawing.Point(62, 184);
            this.labsymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labsymbol.Name = "labsymbol";
            this.labsymbol.Size = new System.Drawing.Size(244, 15);
            this.labsymbol.TabIndex = 2;
            this.labsymbol.Text = "= = = = = = = = = = = = = = = = = = = =";
            // 
            // labanswer
            // 
            this.labanswer.AutoSize = true;
            this.labanswer.Location = new System.Drawing.Point(62, 231);
            this.labanswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labanswer.Name = "labanswer";
            this.labanswer.Size = new System.Drawing.Size(46, 15);
            this.labanswer.TabIndex = 3;
            this.labanswer.Text = "answer";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(166, 79);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(78, 23);
            this.txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(166, 130);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(78, 23);
            this.txtnum2.TabIndex = 5;
            // 
            // txtans
            // 
            this.txtans.Enabled = false;
            this.txtans.Location = new System.Drawing.Point(166, 231);
            this.txtans.Margin = new System.Windows.Forms.Padding(4);
            this.txtans.Name = "txtans";
            this.txtans.ReadOnly = true;
            this.txtans.Size = new System.Drawing.Size(78, 23);
            this.txtans.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(314, 60);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(46, 46);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnmultiplication
            // 
            this.btnmultiplication.Location = new System.Drawing.Point(314, 200);
            this.btnmultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnmultiplication.Name = "btnmultiplication";
            this.btnmultiplication.Size = new System.Drawing.Size(46, 46);
            this.btnmultiplication.TabIndex = 8;
            this.btnmultiplication.Text = "*";
            this.btnmultiplication.UseVisualStyleBackColor = true;
            this.btnmultiplication.Click += new System.EventHandler(this.btnmultiplication_Click_1);
            // 
            // btnsubtraction
            // 
            this.btnsubtraction.Location = new System.Drawing.Point(314, 130);
            this.btnsubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubtraction.Name = "btnsubtraction";
            this.btnsubtraction.Size = new System.Drawing.Size(46, 46);
            this.btnsubtraction.TabIndex = 9;
            this.btnsubtraction.Text = "-";
            this.btnsubtraction.UseVisualStyleBackColor = true;
            this.btnsubtraction.Click += new System.EventHandler(this.btnsubtraction_Click_1);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(314, 270);
            this.btndivision.Margin = new System.Windows.Forms.Padding(4);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(46, 46);
            this.btndivision.TabIndex = 10;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click_1);
            // 
            // _08Hwcalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnsubtraction);
            this.Controls.Add(this.btnmultiplication);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtans);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.labanswer);
            this.Controls.Add(this.labsymbol);
            this.Controls.Add(this.labnum2);
            this.Controls.Add(this.labnum1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_08Hwcalculate";
            this.Text = "calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labnum1;
        private System.Windows.Forms.Label labnum2;
        private System.Windows.Forms.Label labsymbol;
        private System.Windows.Forms.Label labanswer;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtans;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmultiplication;
        private System.Windows.Forms.Button btnsubtraction;
        private System.Windows.Forms.Button btndivision;
    }
}