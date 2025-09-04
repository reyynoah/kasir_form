namespace mk2_2
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
            cbmakanan = new ComboBox();
            groupBox1 = new GroupBox();
            numjumlahminuman = new NumericUpDown();
            numjumlahmakanan = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            cbminuman = new ComboBox();
            groupBox2 = new GroupBox();
            tbminuman = new TextBox();
            tbmakanan = new TextBox();
            tbtotal = new TextBox();
            tbbayar = new TextBox();
            tbkembali = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btsebelumnya = new Button();
            bttutup = new Button();
            btproses = new Button();
            tbnamakasir = new TextBox();
            label6 = new Label();
            btclear = new Button();
            dgvRiwayat = new DataGridView();
            NamaMakanan = new DataGridViewTextBoxColumn();
            JumlahMakanan = new DataGridViewTextBoxColumn();
            HargaMakanan = new DataGridViewTextBoxColumn();
            NamaMinuman = new DataGridViewTextBoxColumn();
            JumlahMinuman = new DataGridViewTextBoxColumn();
            HargaMinuman = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Bayar = new DataGridViewTextBoxColumn();
            Kembali = new DataGridViewTextBoxColumn();
            NamaKasir = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numjumlahminuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numjumlahmakanan).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // cbmakanan
            // 
            cbmakanan.FormattingEnabled = true;
            cbmakanan.Items.AddRange(new object[] { "Ayam Geprek", "Ayam Gepuk", "Nasi Kebuli" });
            cbmakanan.Location = new Point(120, 39);
            cbmakanan.Name = "cbmakanan";
            cbmakanan.Size = new Size(240, 23);
            cbmakanan.TabIndex = 0;
            cbmakanan.SelectedIndexChanged += cbmakanan_SelectedIndexChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numjumlahminuman);
            groupBox1.Controls.Add(numjumlahmakanan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbminuman);
            groupBox1.Controls.Add(cbmakanan);
            groupBox1.Location = new Point(19, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 136);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daftar Makanan Dan Minuman";
            // 
            // numjumlahminuman
            // 
            numjumlahminuman.Location = new Point(384, 91);
            numjumlahminuman.Name = "numjumlahminuman";
            numjumlahminuman.Size = new Size(142, 23);
            numjumlahminuman.TabIndex = 11;
            numjumlahminuman.ValueChanged += numjumlahminuman_ValueChanged;
            // 
            // numjumlahmakanan
            // 
            numjumlahmakanan.Location = new Point(384, 39);
            numjumlahmakanan.Name = "numjumlahmakanan";
            numjumlahmakanan.Size = new Size(142, 23);
            numjumlahmakanan.TabIndex = 10;
            numjumlahmakanan.ValueChanged += numjumlahmakanan_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 94);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "MINUMAN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "MAKANAN";
            // 
            // cbminuman
            // 
            cbminuman.FormattingEnabled = true;
            cbminuman.Items.AddRange(new object[] { "Es Teh", "Es Jeruk", "Milo" });
            cbminuman.Location = new Point(120, 91);
            cbminuman.Name = "cbminuman";
            cbminuman.Size = new Size(240, 23);
            cbminuman.TabIndex = 1;
            cbminuman.SelectedIndexChanged += cbminuman_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbminuman);
            groupBox2.Controls.Add(tbmakanan);
            groupBox2.Location = new Point(652, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 136);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total Harga";
            // 
            // tbminuman
            // 
            tbminuman.Location = new Point(35, 86);
            tbminuman.Name = "tbminuman";
            tbminuman.Size = new Size(184, 23);
            tbminuman.TabIndex = 1;
            // 
            // tbmakanan
            // 
            tbmakanan.Location = new Point(35, 36);
            tbmakanan.Name = "tbmakanan";
            tbmakanan.Size = new Size(184, 23);
            tbmakanan.TabIndex = 0;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(712, 188);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(184, 23);
            tbtotal.TabIndex = 2;
            // 
            // tbbayar
            // 
            tbbayar.Location = new Point(712, 229);
            tbbayar.Name = "tbbayar";
            tbbayar.Size = new Size(184, 23);
            tbbayar.TabIndex = 3;
            tbbayar.TextChanged += tbbayar_TextChanged;
            // 
            // tbkembali
            // 
            tbkembali.Location = new Point(712, 274);
            tbkembali.Name = "tbkembali";
            tbkembali.Size = new Size(184, 23);
            tbkembali.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 282);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "KEMBALI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(626, 191);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "TOTAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(626, 237);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 6;
            label5.Text = "BAYAR";
            // 
            // btsebelumnya
            // 
            btsebelumnya.Location = new Point(42, 421);
            btsebelumnya.Name = "btsebelumnya";
            btsebelumnya.Size = new Size(170, 30);
            btsebelumnya.TabIndex = 7;
            btsebelumnya.Text = "SEBELUMNYA";
            btsebelumnya.UseVisualStyleBackColor = true;
            btsebelumnya.Click += btsebelumnya_Click;
            // 
            // bttutup
            // 
            bttutup.Location = new Point(952, 26);
            bttutup.Name = "bttutup";
            bttutup.Size = new Size(110, 27);
            bttutup.TabIndex = 8;
            bttutup.Text = "TUTUP";
            bttutup.UseVisualStyleBackColor = true;
            bttutup.Click += bttutup_Click;
            // 
            // btproses
            // 
            btproses.Location = new Point(749, 368);
            btproses.Name = "btproses";
            btproses.Size = new Size(107, 30);
            btproses.TabIndex = 9;
            btproses.Text = "PROSES";
            btproses.UseVisualStyleBackColor = true;
            btproses.Click += btproses_Click;
            // 
            // tbnamakasir
            // 
            tbnamakasir.Location = new Point(712, 314);
            tbnamakasir.Name = "tbnamakasir";
            tbnamakasir.Size = new Size(184, 23);
            tbnamakasir.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(626, 317);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "NAMA KASIR ";
            // 
            // btclear
            // 
            btclear.Location = new Point(749, 421);
            btclear.Name = "btclear";
            btclear.Size = new Size(107, 30);
            btclear.TabIndex = 12;
            btclear.Text = "CLEAR";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btclear_Click;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { NamaMakanan, JumlahMakanan, HargaMakanan, NamaMinuman, JumlahMinuman, HargaMinuman, Total, Bayar, Kembali, NamaKasir });
            dgvRiwayat.Location = new Point(19, 477);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(1043, 103);
            dgvRiwayat.TabIndex = 13;
            // 
            // NamaMakanan
            // 
            NamaMakanan.HeaderText = "NamaMakanan";
            NamaMakanan.Name = "NamaMakanan";
            // 
            // JumlahMakanan
            // 
            JumlahMakanan.HeaderText = "JumlahMakanan";
            JumlahMakanan.Name = "JumlahMakanan";
            // 
            // HargaMakanan
            // 
            HargaMakanan.HeaderText = "HargaMakanan";
            HargaMakanan.Name = "HargaMakanan";
            // 
            // NamaMinuman
            // 
            NamaMinuman.HeaderText = "NamaMinuman";
            NamaMinuman.Name = "NamaMinuman";
            // 
            // JumlahMinuman
            // 
            JumlahMinuman.HeaderText = "JumlahMinuman";
            JumlahMinuman.Name = "JumlahMinuman";
            // 
            // HargaMinuman
            // 
            HargaMinuman.HeaderText = "HargaMinuman";
            HargaMinuman.Name = "HargaMinuman";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Bayar
            // 
            Bayar.HeaderText = "Bayar";
            Bayar.Name = "Bayar";
            // 
            // Kembali
            // 
            Kembali.HeaderText = "Kembali";
            Kembali.Name = "Kembali";
            // 
            // NamaKasir
            // 
            NamaKasir.HeaderText = "NamaKasir";
            NamaKasir.Name = "NamaKasir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1082, 603);
            Controls.Add(dgvRiwayat);
            Controls.Add(btclear);
            Controls.Add(label6);
            Controls.Add(tbnamakasir);
            Controls.Add(btproses);
            Controls.Add(bttutup);
            Controls.Add(btsebelumnya);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbkembali);
            Controls.Add(tbbayar);
            Controls.Add(tbtotal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numjumlahminuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)numjumlahmakanan).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbmakanan;
        private GroupBox groupBox1;
        private ComboBox cbminuman;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tbminuman;
        private TextBox tbmakanan;
        private TextBox tbtotal;
        private TextBox tbbayar;
        private TextBox tbkembali;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btsebelumnya;
        private Button bttutup;
        private Button btproses;
        private NumericUpDown numjumlahmakanan;
        private NumericUpDown numjumlahminuman;
        private TextBox tbnamakasir;
        private Label label6;
        private Button btclear;
        private DataGridView dgvRiwayat;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn JumlahMakanan;
        private DataGridViewTextBoxColumn HargaMakanan;
        private DataGridViewTextBoxColumn NamaMinuman;
        private DataGridViewTextBoxColumn JumlahMinuman;
        private DataGridViewTextBoxColumn HargaMinuman;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Bayar;
        private DataGridViewTextBoxColumn Kembali;
        private DataGridViewTextBoxColumn NamaKasir;
    }
}
