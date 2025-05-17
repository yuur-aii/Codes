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

    public partial class Hesap_Oluştur : Form
    {
        public static string yenikullanici;
        public static string yenisifre;

        public Hesap_Oluştur()
        {
            InitializeComponent();
        }

        private void gndrbtn_Click(object sender, EventArgs e)
        {
            if (ynsfrtxt.Text == sfryndntxt.Text)
            {
                yenikullanici = yeniklncadtxt.Text;
                yenisifre = ynsfrtxt.Text;

                MessageBox.Show("Hesabınız Oluşturuldu");
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil");
            }
        }
    }
}
