using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ___
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void gndrbtn_si_Click(object sender, EventArgs e)
        {
            string kullaniciadi = klncadtxt_si.Text;
            string sifre = sifretxt_si.Text;
            if (kullaniciadi == "Aymes" && sifre == "12345")
            {
                MessageBox.Show("Giriş Başarılı."); klncadtxt_si.Clear(); sifretxt_si.Clear();
            }
            else
            {

                i = i + 1;
                int maxi = 3;
                int kalan;
                kalan = maxi - i;

                MessageBox.Show("Şifre ya da kullanıcı adı hatalı, " + kalan + " hakkınız kaldı."); klncadtxt_si.Clear(); sifretxt_si.Clear();
                if (i == maxi)
                {
                    MessageBox.Show("Hakkınız Kalmadı."); Application.Exit();
                }
            }
        }
    }
}