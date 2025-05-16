using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_2_BK
{
    public partial class kisiselbilgiler_bk : Form
    {
        public kisiselbilgiler_bk()
        {
            InitializeComponent();
        }

        private void btnkaydetbk_Click(object sender, EventArgs e)
        {
         
            string secilenlerbk = "Seçilen Diller:";
            string secilenbk = "Cinsiyetiniz:";
            
            if (cbtrbk.Checked) secilenlerbk += "Türkçe\n";
            if (cbrubk.Checked) secilenlerbk += "Rusça\n";
            if (cbspbk.Checked) secilenlerbk += "İspanyolca\n";
            if (cbprbk.Checked) secilenlerbk += "Portekizce\n";
            if (cbabbk.Checked) secilenlerbk += "Arapça\n";
            if (cbfrbk.Checked) secilenlerbk += "Fransızca\n";
            if (cbchbk.Checked) secilenlerbk += "Çince\n";
            if (cbdebk.Checked) secilenlerbk += "Almanca\n";
            if (cbenbk.Checked) secilenlerbk += "İngilizce\n";

            if (erkekradbk.Checked == true) secilenbk = "Erkek";
            if (kadınradbk.Checked == true) secilenbk = "Kadın";
            MessageBox.Show("Hoşgeldiniz" + adtxtbk.Text + soyadtxtbk.Text+ "\n"+secilenlerbk+secilenbk);

        }
    }
}
