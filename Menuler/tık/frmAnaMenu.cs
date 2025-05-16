using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tık
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnnufus_Click(object sender, EventArgs e)
        {
            frmNufus FormNufus = new frmNufus();
        FormNufus.ShowDialog();
        }

        private void derslerbtn_Click(object sender, EventArgs e)
        {
            frmDersler FormDersler = new frmDersler();
            FormDersler.Show();
        }

        private void nÜFUSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNufus FormNufus = new frmNufus();
            FormNufus.ShowDialog();
        }

        private void dERSLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersler FormDersler = new frmDersler();
            FormDersler.Show();
        }

        private void btngndr_Click(object sender, EventArgs e)
        {
            string secilenler = "Secilen Diller\n";
            if (chbjava.Checked == true)
                secilenler += "Java\n";
            if (chbcp.Checked == true)
                secilenler += "C++\n";
            if (chbcs.Checked == true)
                secilenler += "C#\n";
            MessageBox.Show(secilenler);
        }

        private void btngonder2_Click(object sender, EventArgs e)
        {
            string secilen = "Cinsiyet\n";
            if (rdbbay.Checked == true) secilen += "Bay";
            if (rdbbayan.Checked == true) secilen += "Bayan";
            MessageBox.Show(secilen);
        }
    }
}
