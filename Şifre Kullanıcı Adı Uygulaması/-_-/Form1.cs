using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            if (kullaniciadi == Hesap_Oluştur.yenikullanici && sifre == Hesap_Oluştur.yenisifre)
            {
                MessageBox.Show("Giriş Başarılı.");
                klncadtxt_si.Clear();
                sifretxt_si.Clear();
            }
            else
            {
                i++;
                int maxi = 3;
                int kalan = maxi - i;

                MessageBox.Show("Şifre ya da kullanıcı adı hatalı, " + kalan + " hakkınız kaldı.");
                klncadtxt_si.Clear();
                sifretxt_si.Clear();

                if (i == maxi)
                {
                    MessageBox.Show("Hakkınız kalmadı.");
                    Application.Exit();
                }
            }
        }



        private void ynhspbtn_Click(object sender, EventArgs e)
            {
                Hesap_Oluştur HesapForm = new Hesap_Oluştur();
                HesapForm.ShowDialog();
            }
        }
    }
