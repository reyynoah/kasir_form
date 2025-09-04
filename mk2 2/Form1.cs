namespace mk2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbbayar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbbayar.Text))
            {
                tbkembali.Clear();
                return;
            }

            int bayar, total;
            if (int.TryParse(tbbayar.Text, out bayar) && int.TryParse(tbtotal.Text, out total))
            {
                int kembali = bayar - total;
                tbkembali.Text = kembali.ToString();
            }
            else
            {
                tbkembali.Clear();
            }
        }

        private void bttutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btproses_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Kasir: " + tbnamakasir.Text +
                "\n" + cbmakanan.Text + " x " + numjumlahmakanan.Value + " = " + tbmakanan.Text +
                "\n" + cbminuman.Text + " x " + numjumlahminuman.Value + " = " + tbminuman.Text +
                "\nTotal: " + tbtotal.Text +
                "\nBayar: " + tbbayar.Text +
                "\nKembali: " + tbkembali.Text
            );

            dgvRiwayat.Rows.Add(
                tbnamakasir.Text,            
                cbmakanan.Text,              
                numjumlahmakanan.Value,      
                tbmakanan.Text,              
                cbminuman.Text,              
                numjumlahminuman.Value,      
                tbminuman.Text,              
                tbtotal.Text,                
                tbbayar.Text,                
                tbkembali.Text               
            );
        }


        private void btsebelumnya_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            cbmakanan.SelectedIndex = -1;
            cbminuman.SelectedIndex = -1;
            tbmakanan.Clear();
            tbminuman.Clear();
            tbtotal.Clear();
            tbbayar.Clear();
            tbkembali.Clear();
            tbnamakasir.Clear();
            numjumlahmakanan.Value = numjumlahmakanan.Minimum;
            numjumlahminuman.Value = numjumlahminuman.Minimum;
            tbnamakasir.Focus();
        }

        private void cbmakanan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int pilih = cbmakanan.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    tbmakanan.Text = (20000 * (int)numjumlahmakanan.Value).ToString(); break;
                case 1:
                    tbmakanan.Text = (12000 * (int)numjumlahmakanan.Value).ToString(); break;
                case 2:
                    tbmakanan.Text = (34000 * (int)numjumlahmakanan.Value).ToString(); break;
            }
            HitungTotal();
        }

        private void cbminuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih = cbminuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    tbminuman.Text = (2000 * (int)numjumlahminuman.Value).ToString(); break;
                case 1:
                    tbminuman.Text = (5000 * (int)numjumlahminuman.Value).ToString(); break;
                case 2:
                    tbminuman.Text = (12000 * (int)numjumlahminuman.Value).ToString(); break;
            }
            HitungTotal();
        }

        private void numjumlahmakanan_ValueChanged(object sender, EventArgs e)
        {
            cbmakanan_SelectedIndexChanged_1(sender, e); 
        }
        private void numjumlahminuman_ValueChanged(object sender, EventArgs e)
        {
            cbminuman_SelectedIndexChanged(sender, e); 
        }

        private void HitungTotal()
        {
            int hrgMakanan = 0, hrgMinuman = 0;
            int.TryParse(tbmakanan.Text, out hrgMakanan);
            int.TryParse(tbminuman.Text, out hrgMinuman);

            int total = hrgMakanan + hrgMinuman;
            tbtotal.Text = total.ToString();
        }
    }
}
