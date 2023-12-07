namespace Der_BBW_Netzrechner
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
            TDecOct1 = new TextBox();
            LBinOct1 = new Label();
            TDecOct3 = new TextBox();
            TDecOct2 = new TextBox();
            TDecOct4 = new TextBox();
            SuspendLayout();
            // 
            // TDecOct1
            // 
            TDecOct1.Location = new Point(12, 12);
            TDecOct1.MaxLength = 3;
            TDecOct1.Name = "TDecOct1";
            TDecOct1.Size = new Size(26, 23);
            TDecOct1.TabIndex = 1;
            TDecOct1.Text = "255";
            TDecOct1.TextAlign = HorizontalAlignment.Center;
            TDecOct1.TextChanged += TxtInput_TextChanged;
            // 
            // LBinOct1
            // 
            LBinOct1.AutoSize = true;
            LBinOct1.Location = new Point(58, 68);
            LBinOct1.Name = "LBinOct1";
            LBinOct1.Size = new Size(25, 15);
            LBinOct1.TabIndex = 2;
            LBinOct1.Text = "asd";
            LBinOct1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TDecOct3
            // 
            TDecOct3.Location = new Point(76, 12);
            TDecOct3.MaxLength = 3;
            TDecOct3.Name = "TDecOct3";
            TDecOct3.Size = new Size(26, 23);
            TDecOct3.TabIndex = 3;
            TDecOct3.Text = "255";
            TDecOct3.TextAlign = HorizontalAlignment.Center;
            // 
            // TDecOct2
            // 
            TDecOct2.Location = new Point(44, 12);
            TDecOct2.MaxLength = 3;
            TDecOct2.Name = "TDecOct2";
            TDecOct2.Size = new Size(26, 23);
            TDecOct2.TabIndex = 4;
            TDecOct2.Text = "255";
            TDecOct2.TextAlign = HorizontalAlignment.Center;
            // 
            // TDecOct4
            // 
            TDecOct4.Location = new Point(156, 12);
            TDecOct4.MaxLength = 3;
            TDecOct4.Name = "TDecOct4";
            TDecOct4.Size = new Size(26, 23);
            TDecOct4.TabIndex = 5;
            TDecOct4.Text = "255";
            TDecOct4.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TDecOct4);
            Controls.Add(TDecOct2);
            Controls.Add(TDecOct3);
            Controls.Add(LBinOct1);
            Controls.Add(TDecOct1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TDecOct1;
        private Label LBinOct1;
        private TextBox TDecOct3;
        private TextBox TDecOct2;
        private TextBox TDecOct4;
    }
}