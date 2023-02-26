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
            txtPassResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkIncludeUpper = new CheckBox();
            txtLength = new TextBox();
            chkIncludeNumbers = new CheckBox();
            chkIncludeLower = new CheckBox();
            chkSymbols = new CheckBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // txtPassResult
            // 
            txtPassResult.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassResult.Location = new Point(194, 100);
            txtPassResult.Multiline = true;
            txtPassResult.Name = "txtPassResult";
            txtPassResult.Size = new Size(730, 168);
            txtPassResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.1194019F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(383, 39);
            label1.Name = "label1";
            label1.Size = new Size(352, 35);
            label1.TabIndex = 1;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(564, 335);
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
            chkIncludeUpper.Location = new Point(746, 391);
            chkIncludeUpper.Name = "chkIncludeUpper";
            chkIncludeUpper.Size = new Size(178, 27);
            chkIncludeUpper.TabIndex = 3;
            chkIncludeUpper.Text = "Include Uppercase";
            chkIncludeUpper.TextAlign = ContentAlignment.MiddleRight;
            chkIncludeUpper.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(784, 335);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(140, 30);
            txtLength.TabIndex = 4;
            txtLength.KeyPress += txtLength_KeyPress;
            // 
            // chkIncludeNumbers
            // 
            chkIncludeNumbers.AutoSize = true;
            chkIncludeNumbers.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeNumbers.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            chkIncludeNumbers.Location = new Point(756, 507);
            chkIncludeNumbers.Name = "chkIncludeNumbers";
            chkIncludeNumbers.Size = new Size(168, 27);
            chkIncludeNumbers.TabIndex = 5;
            chkIncludeNumbers.Text = "Include Numbers";
            chkIncludeNumbers.TextAlign = ContentAlignment.MiddleRight;
            chkIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // chkIncludeLower
            // 
            chkIncludeLower.AutoSize = true;
            chkIncludeLower.CheckAlign = ContentAlignment.MiddleRight;
            chkIncludeLower.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            chkIncludeLower.Location = new Point(747, 448);
            chkIncludeLower.Name = "chkIncludeLower";
            chkIncludeLower.Size = new Size(177, 27);
            chkIncludeLower.TabIndex = 6;
            chkIncludeLower.Text = "Include Lowercase";
            chkIncludeLower.TextAlign = ContentAlignment.MiddleRight;
            chkIncludeLower.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            chkSymbols.AutoSize = true;
            chkSymbols.CheckAlign = ContentAlignment.MiddleRight;
            chkSymbols.Font = new Font("Segoe UI", 9.134328F, FontStyle.Bold, GraphicsUnit.Point);
            chkSymbols.ImageAlign = ContentAlignment.MiddleRight;
            chkSymbols.Location = new Point(761, 566);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(163, 27);
            chkSymbols.TabIndex = 7;
            chkSymbols.Text = "Include Symbols";
            chkSymbols.TextAlign = ContentAlignment.MiddleRight;
            chkSymbols.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate.Location = new Point(482, 662);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(155, 47);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1155, 731);
            Controls.Add(btnGenerate);
            Controls.Add(chkSymbols);
            Controls.Add(chkIncludeLower);
            Controls.Add(chkIncludeNumbers);
            Controls.Add(txtLength);
            Controls.Add(chkIncludeUpper);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassResult);
            Name = "Form1";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassResult;
        private Label label1;
        private Label label2;
        private CheckBox chkIncludeUpper;
        private TextBox txtLength;
        private CheckBox chkIncludeNumbers;
        private CheckBox chkIncludeLower;
        private CheckBox chkSymbols;
        private Button btnGenerate;
    }
}