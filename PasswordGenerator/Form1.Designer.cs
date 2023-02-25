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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
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
            chkIncludeUpper.TextAlign = ContentAlignment.MiddleRight;
            chkIncludeUpper.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(488, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 30);
            textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(250, 521);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 27);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Include Uppercase";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(250, 462);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(178, 27);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Include Uppercase";
            checkBox2.TextAlign = ContentAlignment.MiddleRight;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1036, 721);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}