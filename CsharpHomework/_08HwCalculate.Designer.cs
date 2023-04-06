namespace CsharpHomework
{
    partial class _08Hwcalculateform
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
            labnum1 = new Label();
            labnum2 = new Label();
            labsymbol = new Label();
            labanswer = new Label();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            txtans = new TextBox();
            btnadd = new Button();
            btnmultiplication = new Button();
            btnsubtraction = new Button();
            btndivision = new Button();
            SuspendLayout();
            // 
            // labnum1
            // 
            labnum1.AutoSize = true;
            labnum1.Location = new Point(62, 82);
            labnum1.Margin = new Padding(4, 0, 4, 0);
            labnum1.Name = "labnum1";
            labnum1.Size = new Size(39, 15);
            labnum1.TabIndex = 0;
            labnum1.Text = "num1";
            // 
            // labnum2
            // 
            labnum2.AutoSize = true;
            labnum2.Location = new Point(62, 134);
            labnum2.Margin = new Padding(4, 0, 4, 0);
            labnum2.Name = "labnum2";
            labnum2.Size = new Size(39, 15);
            labnum2.TabIndex = 1;
            labnum2.Text = "num2";
            // 
            // labsymbol
            // 
            labsymbol.AutoSize = true;
            labsymbol.Location = new Point(62, 184);
            labsymbol.Margin = new Padding(4, 0, 4, 0);
            labsymbol.Name = "labsymbol";
            labsymbol.Size = new Size(244, 15);
            labsymbol.TabIndex = 2;
            labsymbol.Text = "= = = = = = = = = = = = = = = = = = = =";
            // 
            // labanswer
            // 
            labanswer.AutoSize = true;
            labanswer.Location = new Point(62, 231);
            labanswer.Margin = new Padding(4, 0, 4, 0);
            labanswer.Name = "labanswer";
            labanswer.Size = new Size(46, 15);
            labanswer.TabIndex = 3;
            labanswer.Text = "answer";
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(166, 79);
            txtnum1.Margin = new Padding(4);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(78, 23);
            txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(166, 130);
            txtnum2.Margin = new Padding(4);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(78, 23);
            txtnum2.TabIndex = 5;
            // 
            // txtans
            // 
            txtans.Enabled = false;
            txtans.Location = new Point(166, 228);
            txtans.Margin = new Padding(4);
            txtans.Name = "txtans";
            txtans.ReadOnly = true;
            txtans.Size = new Size(78, 23);
            txtans.TabIndex = 6;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(314, 60);
            btnadd.Margin = new Padding(4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(46, 46);
            btnadd.TabIndex = 7;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnmultiplication
            // 
            btnmultiplication.Location = new Point(314, 200);
            btnmultiplication.Margin = new Padding(4);
            btnmultiplication.Name = "btnmultiplication";
            btnmultiplication.Size = new Size(46, 46);
            btnmultiplication.TabIndex = 8;
            btnmultiplication.Text = "*";
            btnmultiplication.UseVisualStyleBackColor = true;
            btnmultiplication.Click += btnmultiplication_Click;
            // 
            // btnsubtraction
            // 
            btnsubtraction.Location = new Point(314, 130);
            btnsubtraction.Margin = new Padding(4);
            btnsubtraction.Name = "btnsubtraction";
            btnsubtraction.Size = new Size(46, 46);
            btnsubtraction.TabIndex = 9;
            btnsubtraction.Text = "-";
            btnsubtraction.UseVisualStyleBackColor = true;
            btnsubtraction.Click += btnsubtraction_Click;
            // 
            // btndivision
            // 
            btndivision.Location = new Point(314, 270);
            btndivision.Margin = new Padding(4);
            btndivision.Name = "btndivision";
            btndivision.Size = new Size(46, 46);
            btndivision.TabIndex = 10;
            btndivision.Text = "/";
            btndivision.UseVisualStyleBackColor = true;
            btndivision.Click += btndivision_Click;
            // 
            // _08Hwcalculateform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 348);
            Controls.Add(btndivision);
            Controls.Add(btnsubtraction);
            Controls.Add(btnmultiplication);
            Controls.Add(btnadd);
            Controls.Add(txtans);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(labanswer);
            Controls.Add(labsymbol);
            Controls.Add(labnum2);
            Controls.Add(labnum1);
            Margin = new Padding(4);
            Name = "_08Hwcalculateform";
            Text = "calculate";
            ResumeLayout(false);
            PerformLayout();
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