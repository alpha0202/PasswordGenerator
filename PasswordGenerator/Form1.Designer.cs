namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkIncludeUpper = new CheckBox();
            textBox2 = new TextBox();
            chkIncludeNumers = new CheckBox();
            chkIncludeLower = new CheckBox();
            ckhSymbols = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(730, 168);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.1194019F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 39);
            label1.Name = "label1";
            label1.Size = new Size(352, 35);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(218, 322);
            label2.Name = "label2";
            label2.Size = new Size(180, 30);
            label2.TabIndex = 2;
            label2.Text = "Password Lenght";
            // 
            // chkIncludeUpper
            // 
            chkIncludeUpper.AutoSize = true;
            chkIncludeUpper.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeUpper.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            chkIncludeUpper.Location = new Point(250, 405);
            chkIncludeUpper.Name = "chkIncludeUpper";
            chkIncludeUpper.Size = new Size(178, 27);
            chkIncludeUpper.TabIndex = 3;
            chkIncludeUpper.Text = "Include Uppercase";
            chkIncludeUpper.TextAlign = ContentAlignment.MiddleCenter;
            chkIncludeUpper.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(488, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 30);
            textBox2.TabIndex = 4;
            // 
            // chkIncludeNumers
            // 
            chkIncludeNumers.AutoSize = true;
            chkIncludeNumers.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeNumers.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            chkIncludeNumers.Location = new Point(250, 521);
            chkIncludeNumers.Name = "chkIncludeNumers";
            chkIncludeNumers.Size = new Size(168, 27);
            chkIncludeNumers.TabIndex = 5;
            chkIncludeNumers.Text = "Include Numbers";
            chkIncludeNumers.TextAlign = ContentAlignment.MiddleRight;
            chkIncludeNumers.UseVisualStyleBackColor = true;
            // 
            // chkIncludeLower
            // 
            chkIncludeLower.AutoSize = true;
            chkIncludeLower.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeLower.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            chkIncludeLower.Location = new Point(250, 462);
            chkIncludeLower.Name = "chkIncludeLower";
            chkIncludeLower.Size = new Size(177, 27);
            chkIncludeLower.TabIndex = 6;
            chkIncludeLower.Text = "Include Lowercase";
            chkIncludeLower.TextAlign = ContentAlignment.MiddleRight;
            chkIncludeLower.UseVisualStyleBackColor = true;
            // 
            // ckhSymbols
            // 
            ckhSymbols.AutoSize = true;
            ckhSymbols.CheckAlign = ContentAlignment.MiddleRight;
            ckhSymbols.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            ckhSymbols.ImageAlign = ContentAlignment.MiddleRight;
            ckhSymbols.Location = new Point(250, 580);
            ckhSymbols.Name = "ckhSymbols";
            ckhSymbols.Size = new Size(163, 27);
            ckhSymbols.TabIndex = 7;
            ckhSymbols.Text = "Include Symbols";
            ckhSymbols.TextAlign = ContentAlignment.MiddleRight;
            ckhSymbols.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1036, 721);
            Controls.Add(ckhSymbols);
            Controls.Add(chkIncludeLower);
            Controls.Add(chkIncludeNumers);
            Controls.Add(textBox2);
            Controls.Add(chkIncludeUpper);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private CheckBox chkIncludeUpper;
        private TextBox textBox2;
        private CheckBox chkIncludeNumers;
        private CheckBox chkIncludeLower;
        private CheckBox ckhSymbols;
    }
}