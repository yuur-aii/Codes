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
    public partial class DersForm_BK : Form
    {
        public DersForm_BK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ders Kodu:" + derskodtxtbk.Text+ "\n"+ "Ders Adı:"+dersadtxtbk.Text+"\n"+"Teori:"+teoribk.Text+"\n"+"Uygulama:"+ uygbk.Text+"\n"+"Kredi:"+kredibk.Text+"\n"+"AKTS:"+aktsbk.Text);
        }
    }
}
 