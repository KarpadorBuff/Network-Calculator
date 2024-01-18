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
            LBinOct2 = new Label();
            LBinOct3 = new Label();
            LBinOct4 = new Label();
            TBnetmask = new TextBox();
            netmask4 = new Label();
            netmask3 = new Label();
            netmask2 = new Label();
            netmask1 = new Label();
            Subnet4 = new TextBox();
            Subnet2 = new TextBox();
            Subnet3 = new TextBox();
            Subnet1 = new TextBox();
            label1 = new Label();
            hostamount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            netmask_I1 = new Label();
            netmask_I2 = new Label();
            netmask_I3 = new Label();
            netmask_I4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // TDecOct1
            // 
            TDecOct1.Location = new Point(12, 20);
            TDecOct1.MaxLength = 3;
            TDecOct1.Name = "TDecOct1";
            TDecOct1.Size = new Size(26, 23);
            TDecOct1.TabIndex = 1;
            TDecOct1.TextAlign = HorizontalAlignment.Center;
            TDecOct1.TextChanged += Decimal_Text_Changed;
            // 
            // LBinOct1
            // 
            LBinOct1.AutoSize = true;
            LBinOct1.Location = new Point(106, 17);
            LBinOct1.Name = "LBinOct1";
            LBinOct1.Size = new Size(55, 15);
            LBinOct1.TabIndex = 2;
            LBinOct1.Text = "00000000";
            LBinOct1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TDecOct3
            // 
            TDecOct3.Location = new Point(66, 20);
            TDecOct3.MaxLength = 3;
            TDecOct3.Name = "TDecOct3";
            TDecOct3.Size = new Size(26, 23);
            TDecOct3.TabIndex = 3;
            TDecOct3.TextAlign = HorizontalAlignment.Center;
            TDecOct3.TextChanged += Decimal_Text_Changed;
            // 
            // TDecOct2
            // 
            TDecOct2.Location = new Point(39, 20);
            TDecOct2.MaxLength = 3;
            TDecOct2.Name = "TDecOct2";
            TDecOct2.Size = new Size(26, 23);
            TDecOct2.TabIndex = 2;
            TDecOct2.TextAlign = HorizontalAlignment.Center;
            TDecOct2.TextChanged += Decimal_Text_Changed;
            // 
            // TDecOct4
            // 
            TDecOct4.Location = new Point(93, 20);
            TDecOct4.MaxLength = 3;
            TDecOct4.Name = "TDecOct4";
            TDecOct4.Size = new Size(26, 23);
            TDecOct4.TabIndex = 4;
            TDecOct4.TextAlign = HorizontalAlignment.Center;
            TDecOct4.TextChanged += Decimal_Text_Changed;
            // 
            // LBinOct2
            // 
            LBinOct2.AutoSize = true;
            LBinOct2.Location = new Point(166, 17);
            LBinOct2.Name = "LBinOct2";
            LBinOct2.Size = new Size(55, 15);
            LBinOct2.TabIndex = 6;
            LBinOct2.Text = "00000000";
            LBinOct2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBinOct3
            // 
            LBinOct3.AutoSize = true;
            LBinOct3.Location = new Point(226, 17);
            LBinOct3.Name = "LBinOct3";
            LBinOct3.Size = new Size(55, 15);
            LBinOct3.TabIndex = 7;
            LBinOct3.Text = "00000000";
            LBinOct3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LBinOct4
            // 
            LBinOct4.AutoSize = true;
            LBinOct4.Location = new Point(286, 17);
            LBinOct4.Name = "LBinOct4";
            LBinOct4.Size = new Size(55, 15);
            LBinOct4.TabIndex = 8;
            LBinOct4.Text = "00000000";
            LBinOct4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBnetmask
            // 
            TBnetmask.Location = new Point(161, 20);
            TBnetmask.MaxLength = 3;
            TBnetmask.Name = "TBnetmask";
            TBnetmask.Size = new Size(26, 23);
            TBnetmask.TabIndex = 9;
            TBnetmask.Text = "16";
            TBnetmask.TextAlign = HorizontalAlignment.Center;
            TBnetmask.TextChanged += netmaskDecimalChanged;
            // 
            // netmask4
            // 
            netmask4.AutoSize = true;
            netmask4.Location = new Point(286, 32);
            netmask4.Name = "netmask4";
            netmask4.Size = new Size(55, 15);
            netmask4.TabIndex = 13;
            netmask4.Text = "00000000";
            netmask4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netmask3
            // 
            netmask3.AutoSize = true;
            netmask3.Location = new Point(226, 32);
            netmask3.Name = "netmask3";
            netmask3.Size = new Size(55, 15);
            netmask3.TabIndex = 12;
            netmask3.Text = "00000000";
            netmask3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netmask2
            // 
            netmask2.AutoSize = true;
            netmask2.Location = new Point(166, 32);
            netmask2.Name = "netmask2";
            netmask2.Size = new Size(55, 15);
            netmask2.TabIndex = 11;
            netmask2.Text = "00000000";
            netmask2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netmask1
            // 
            netmask1.AutoSize = true;
            netmask1.Location = new Point(106, 32);
            netmask1.Name = "netmask1";
            netmask1.Size = new Size(55, 15);
            netmask1.TabIndex = 10;
            netmask1.Text = "00000000";
            netmask1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Subnet4
            // 
            Subnet4.Location = new Point(108, 20);
            Subnet4.MaxLength = 3;
            Subnet4.Name = "Subnet4";
            Subnet4.Size = new Size(26, 23);
            Subnet4.TabIndex = 8;
            Subnet4.Text = "0";
            Subnet4.TextAlign = HorizontalAlignment.Center;
            Subnet4.TextChanged += Any_text_changed;
            // 
            // Subnet2
            // 
            Subnet2.Location = new Point(44, 20);
            Subnet2.MaxLength = 3;
            Subnet2.Name = "Subnet2";
            Subnet2.Size = new Size(26, 23);
            Subnet2.TabIndex = 6;
            Subnet2.Text = "255";
            Subnet2.TextAlign = HorizontalAlignment.Center;
            Subnet2.TextChanged += Any_text_changed;
            // 
            // Subnet3
            // 
            Subnet3.Location = new Point(76, 20);
            Subnet3.MaxLength = 3;
            Subnet3.Name = "Subnet3";
            Subnet3.Size = new Size(26, 23);
            Subnet3.TabIndex = 7;
            Subnet3.Text = "0";
            Subnet3.TextAlign = HorizontalAlignment.Center;
            Subnet3.TextChanged += Any_text_changed;
            // 
            // Subnet1
            // 
            Subnet1.Location = new Point(12, 20);
            Subnet1.MaxLength = 3;
            Subnet1.Name = "Subnet1";
            Subnet1.Size = new Size(26, 23);
            Subnet1.TabIndex = 5;
            Subnet1.Text = "255";
            Subnet1.TextAlign = HorizontalAlignment.Center;
            Subnet1.TextChanged += Any_text_changed;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 22);
            label1.Name = "label1";
            label1.Size = new Size(14, 17);
            label1.TabIndex = 18;
            label1.Text = "/";
            // 
            // hostamount
            // 
            hostamount.Location = new Point(12, 20);
            hostamount.MaxLength = 3;
            hostamount.Name = "hostamount";
            hostamount.Size = new Size(122, 23);
            hostamount.TabIndex = 19;
            hostamount.Text = "Na/N";
            hostamount.TextAlign = HorizontalAlignment.Center;
            hostamount.TextChanged += Any_text_changed;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 20;
            label2.Text = "Subnetz Maske";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 21;
            label3.Text = "IP - Dezimal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 22;
            label4.Text = "Anzahl Hosts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 23;
            label5.Text = "IP - Binär";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TDecOct1);
            panel1.Controls.Add(TDecOct3);
            panel1.Controls.Add(TDecOct2);
            panel1.Controls.Add(TDecOct4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 98);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Subnet1);
            panel2.Controls.Add(Subnet3);
            panel2.Controls.Add(Subnet2);
            panel2.Controls.Add(Subnet4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(TBnetmask);
            panel2.Location = new Point(12, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 49);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(hostamount);
            panel3.Location = new Point(12, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 49);
            panel3.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(netmask_I1);
            panel4.Controls.Add(netmask_I2);
            panel4.Controls.Add(netmask_I3);
            panel4.Controls.Add(netmask_I4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(netmask1);
            panel4.Controls.Add(netmask2);
            panel4.Controls.Add(netmask3);
            panel4.Controls.Add(netmask4);
            panel4.Controls.Add(LBinOct4);
            panel4.Controls.Add(LBinOct1);
            panel4.Controls.Add(LBinOct3);
            panel4.Controls.Add(LBinOct2);
            panel4.Location = new Point(12, 214);
            panel4.Name = "panel4";
            panel4.Size = new Size(355, 73);
            panel4.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 47);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 30;
            label8.Text = "Wildcard";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 32);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 29;
            label7.Text = "Subnetz Maske";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 17);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 28;
            label6.Text = "IP:";
            // 
            // netmask_I1
            // 
            netmask_I1.AutoSize = true;
            netmask_I1.Location = new Point(106, 47);
            netmask_I1.Name = "netmask_I1";
            netmask_I1.Size = new Size(55, 15);
            netmask_I1.TabIndex = 24;
            netmask_I1.Text = "00000000";
            netmask_I1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netmask_I2
            // 
            netmask_I2.AutoSize = true;
            netmask_I2.Location = new Point(166, 47);
            netmask_I2.Name = "netmask_I2";
            netmask_I2.Size = new Size(55, 15);
            netmask_I2.TabIndex = 25;
            netmask_I2.Text = "00000000";
            netmask_I2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netmask_I3
            // 
            netmask_I3.AutoSize = true;
            netmask_I3.Location = new Point(226, 47);
            netmask_I3.Name = "netmask_I3";
            netmask_I3.Size = new Size(55, 15);
            netmask_I3.TabIndex = 26;
            netmask_I3.Text = "00000000";
            netmask_I3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netmask_I4
            // 
            netmask_I4.AutoSize = true;
            netmask_I4.Location = new Point(286, 47);
            netmask_I4.Name = "netmask_I4";
            netmask_I4.Size = new Size(55, 15);
            netmask_I4.TabIndex = 27;
            netmask_I4.Text = "00000000";
            netmask_I4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 433);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Netzrechner";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TDecOct1;
        private Label LBinOct1;
        private TextBox TDecOct3;
        private TextBox TDecOct2;
        private TextBox TDecOct4;
        private Label LBinOct2;
        private Label LBinOct3;
        private Label LBinOct4;
        private TextBox TBnetmask;
        private Label netmask4;
        private Label netmask3;
        private Label netmask2;
        private TextBox Subnet4;
        private TextBox Subnet2;
        private TextBox Subnet3;
        private TextBox Subnet1;
        private Label label1;
        private TextBox hostamount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label netmask_I1;
        private Label netmask_I2;
        private Label netmask_I3;
        private Label netmask_I4;
        public Label netmask1;
    }
}