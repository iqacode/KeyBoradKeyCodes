namespace KeyBoradKeyCodes
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
            label1 = new Label();
            lblAscii = new Label();
            lblDec = new Label();
            label3 = new Label();
            lblHex = new Label();
            label5 = new Label();
            lblModKey = new Label();
            label7 = new Label();
            lblMod = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 62);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 0;
            label1.Text = "ASCII NUMBER";
            // 
            // lblAscii
            // 
            lblAscii.AutoSize = true;
            lblAscii.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAscii.Location = new Point(378, 62);
            lblAscii.Name = "lblAscii";
            lblAscii.Size = new Size(25, 30);
            lblAscii.TabIndex = 1;
            lblAscii.Text = "0";
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDec.Location = new Point(378, 130);
            lblDec.Name = "lblDec";
            lblDec.Size = new Size(25, 30);
            lblDec.TabIndex = 3;
            lblDec.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 130);
            label3.Name = "label3";
            label3.Size = new Size(187, 30);
            label3.TabIndex = 2;
            label3.Text = "Decimal NUMBER";
            // 
            // lblHex
            // 
            lblHex.AutoSize = true;
            lblHex.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHex.Location = new Point(378, 198);
            lblHex.Name = "lblHex";
            lblHex.Size = new Size(25, 30);
            lblHex.TabIndex = 5;
            lblHex.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 198);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 4;
            label5.Text = "HEX  NUMBER";
            // 
            // lblModKey
            // 
            lblModKey.AutoSize = true;
            lblModKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblModKey.Location = new Point(378, 320);
            lblModKey.Name = "lblModKey";
            lblModKey.Size = new Size(25, 30);
            lblModKey.TabIndex = 7;
            lblModKey.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(53, 320);
            label7.Name = "label7";
            label7.Size = new Size(164, 30);
            label7.TabIndex = 6;
            label7.Text = "Modifier && Key";
            // 
            // lblMod
            // 
            lblMod.AutoSize = true;
            lblMod.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMod.Location = new Point(378, 257);
            lblMod.Name = "lblMod";
            lblMod.Size = new Size(25, 30);
            lblMod.TabIndex = 9;
            lblMod.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(53, 257);
            label9.Name = "label9";
            label9.Size = new Size(167, 30);
            label9.TabIndex = 8;
            label9.Text = "Modifier NAME";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 465);
            Controls.Add(lblMod);
            Controls.Add(label9);
            Controls.Add(lblModKey);
            Controls.Add(label7);
            Controls.Add(lblHex);
            Controls.Add(label5);
            Controls.Add(lblDec);
            Controls.Add(label3);
            Controls.Add(lblAscii);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAscii;
        private Label lblDec;
        private Label label3;
        private Label lblHex;
        private Label label5;
        private Label lblModKey;
        private Label label7;
        private Label lblMod;
        private Label label9;
    }
}