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
    public partial class frmDersler : Form
    {
        public frmDersler()
        {
            InitializeComponent();
        }

        private void frmDersler_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Yükleniyor.");
        }
    }
}
