using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;      
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyayolu = @"C:\Deneme\Stok.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            lstverilerbk.View = View.Details;
            lstverilerbk.GridLines = true;
            lstverilerbk.FullRowSelect = true;
            lstverilerbk.Columns.Add("Birim", 70);
            lstverilerbk.Columns.Add("Stok Kod", 70);
            lstverilerbk.Columns.Add("Stok Ad", 100);
            lstverilerbk.Columns.Add("Açıklama", 100);
            verilerilistele();
        }
        void verilerilistele()
        {
            string satir = "";
            string sonuc = "H";

            
           
            lstverilerbk.Items.Clear();
           
            StreamReader sr = new StreamReader(dosyayolu);
            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    if (sonuc == "H")
                    
                        MessageBox.Show("Kayıt Bulunamadı");
                        break;
                    }
                
                string[] veriler = satir.Split(',');
                if (veriler[0]==txtbirimbk.Text)
                { sonuc = "E";
                 txtstokkodbk.Text= veriler[1];
                   txtstokadbk.Text=veriler[2];
                    txtacıklamabk.Text= veriler[3];
                }
                string[] row = { veriler[0], veriler[1], veriler[2], veriler[3] };
                var satir1 = new ListViewItem(row);
                lstverilerbk.Items.Add(satir1);
            }
            sr.Close();
         }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] row = {txtbirimbk.Text, txtstokkodbk.Text, txtstokadbk.Text, txtacıklamabk.Text };
            var satir = new ListViewItem(row);
            lstverilerbk.Items.Add(satir);
            string veri = txtbirimbk.Text + "," + txtstokkodbk.Text + "," + txtstokadbk.Text + "," + txtacıklamabk.Text;    
            StreamWriter FileAdd = File.AppendText(dosyayolu);
            FileAdd.WriteLine(veri);
            FileAdd.Close();
        }

        private void btnkytsil_Click(object sender, EventArgs e)
        {
            int secili = lstverilerbk.SelectedItems[0].Index;
            lstverilerbk.Items.RemoveAt(secili);
            var file = new List<string>(System.IO.File.ReadAllLines(dosyayolu));
            file.RemoveAt(secili);
            File.WriteAllLines(dosyayolu,file.ToArray());
        }

        private void lstveriler_DoubleClick(object sender, EventArgs e)
        {
            int secili = lstverilerbk.SelectedItems[0].Index;
            txtbirimbk.Text = lstverilerbk.Items[secili].SubItems[0].Text;
            txtstokkodbk.Text = lstverilerbk.Items[secili].SubItems[1].Text;
            txtstokadbk.Text = lstverilerbk.Items[secili].SubItems[2].Text;
            txtacıklamabk.Text = lstverilerbk.Items[secili].SubItems[3].Text;
           
            
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            string bıdı = "";
            txtbirimbk.Text = bıdı;
            txtstokkodbk.Text = bıdı;
            txtstokadbk.Text = bıdı;
            txtacıklamabk.Text = bıdı;
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstverilerbk.SelectedItems[0];
            item.SubItems[0].Text = txtbirimbk.Text;
            item.SubItems[1].Text = txtstokkodbk.Text;
            item.SubItems[2].Text =  txtstokadbk.Text;
            item.SubItems[3].Text = txtacıklamabk.Text;
        }

        private void getirbtnbk_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines(dosyayolu);
            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split(',');
                if (parcalar[1] == txtstokkodbk.Text)
                {
                    txtstokadbk.Text = parcalar[0];
                    txtbirimbk.Text = parcalar[2];
                    txtacıklamabk.Text = parcalar[3];
                    return;
                }


            }

        }
    }
}
