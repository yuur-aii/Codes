using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            labelveri.Text = TxtAdSoyad.Text;
            numlbl.Text = telnotxt.Text;
            MessageBox.Show("Veriniz Kaydedildi " + TxtAdSoyad.Text);
            TxtAdSoyad.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "çık")
            {
                MessageBox.Show("Çıkış Komutu Verildi");
            }
        }

        private void TxtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape) MessageBox.Show("Kaydedildi.");
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kaydı Sil", "İptal",
                MessageBoxButtons.OKCancel);
            if
                (sonuc == DialogResult.OK)
            {
                labelveri.Text = "-";
                numlbl.Text = "-";

                MessageBox.Show("Veriniz Silinmiştir.");

            }
        }
    }
}