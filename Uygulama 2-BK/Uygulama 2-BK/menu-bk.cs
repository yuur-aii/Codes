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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kisiselbilgiler_bk kisiselbilgiler = new kisiselbilgiler_bk();
            kisiselbilgiler.Show();
        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersForm_BK dersform = new DersForm_BK();
            dersform.Show();
        }
    }
}
