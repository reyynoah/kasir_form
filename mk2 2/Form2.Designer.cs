namespace mk2_2
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            btlogin = new Button();
            btclear = new Button();
            btclose = new Button();
            cbshowpassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 44);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "WARMINDO JAWARA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 166);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 211);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 111);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 3;
            label4.Text = "LOGIN KASIR";
            // 
            // tbusername
            // 
            tbusername.Location = new Point(173, 162);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(213, 23);
            tbusername.TabIndex = 4;
            
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(173, 207);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(213, 23);
            tbpassword.TabIndex = 5;
            
            // 
            // btlogin
            // 
            btlogin.Location = new Point(176, 282);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(118, 23);
            btlogin.TabIndex = 6;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // btclear
            // 
            btclear.Location = new Point(176, 325);
            btclear.Name = "btclear";
            btclear.Size = new Size(115, 23);
            btclear.TabIndex = 7;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btclear_Click;
            // 
            // btclose
            // 
            btclose.Location = new Point(176, 369);
            btclose.Name = "btclose";
            btclose.Size = new Size(115, 23);
            btclose.TabIndex = 8;
            btclose.Text = "Tutup";
            btclose.UseVisualStyleBackColor = true;
            btclose.Click += btclose_Click;
            // 
            // cbshowpassword
            // 
            cbshowpassword.AutoSize = true;
            cbshowpassword.Location = new Point(173, 236);
            cbshowpassword.Name = "cbshowpassword";
            cbshowpassword.Size = new Size(133, 19);
            cbshowpassword.TabIndex = 9;
            cbshowpassword.Text = "Tampilkan Password";
            cbshowpassword.UseVisualStyleBackColor = true;
            cbshowpassword.CheckedChanged += cbshowpassword_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(460, 404);
            Controls.Add(cbshowpassword);
            Controls.Add(btclose);
            Controls.Add(btclear);
            Controls.Add(btlogin);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Button btlogin;
        private Button btclear;
        private Button btclose;
        private CheckBox cbshowpassword;
    }
}