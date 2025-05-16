using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace items
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void illercmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor=Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            illercmbx.Items.Add("Hatay");
            illercmbx.Items.Add("Aydın");
            illercmbx.Items.Add("Muğla");
            illercmbx.Items.Add("İzmir");


        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            string[] dizi = { "Denizli", "Balıkesir", "Ankara", "İstanbul", "Edirne", "Kocaeli", };



            lstsehirler.Items.AddRange(dizi);
        }

        private void btnsehirekle_Click(object sender, EventArgs e)
        {
            lstsehirler.Items.Add(sehirtxt.Text);
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            lstsehirler.Items.Remove(sehirtxt.Text);
        }
    }
}
