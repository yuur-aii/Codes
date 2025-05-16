using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace üdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection();
        void verisil()
        {
            komut.CommandText = "DELETE FROM TBLStokBK WHERE StokKodBK='" + txtkodBK.Text + "'";
            baglan();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            veriGetir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verisil();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.ConnectionString = "Data Source =YURI;Initial Catalog= StokBK;Integrated Security=True ";
            komut.Connection = baglanti;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            veriGetir();
        }
        DataSet ds = new DataSet();
        void baglan()
        { if (baglanti.State == ConnectionState.Closed) {
                baglanti.Open();
            }
        }

        private void btnekleBK_Click(object sender, EventArgs e)
        {
            veriekle();
        }
        SqlCommand komut = new SqlCommand();
    
    void veriekle()
        {
            komut.CommandText = "INSERT INTO TBLStokBK (StokKodBK,StokAdBK,BirimBK,AçıklamaBK) VALUES ('" + txtkodBK.Text + "','" + txtadBK.Text + "','" +
                txtbirimBK.Text + "','" + txtaciklamaBK.Text + "')";
            baglan();
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGetir();
            MessageBox.Show("Kayıt Yapıldı");

        }
        void veriGetir()
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataAdapter verial = new SqlDataAdapter("Select * From TBLStokBK", baglanti);
            ds.Clear();
            verial.Fill(ds, "StokBK");
            lstvrlBK.DataSource = ds.Tables["StokBK"];
        }
        

        private void lstvrlBK_DoubleClick(object sender, EventArgs e)
        {
            txtkodBK.Text = lstvrlBK.Rows[secilisatir].Cells[0].Value.ToString();
            txtadBK.Text = lstvrlBK.Rows[secilisatir].Cells[1].Value.ToString();
            txtbirimBK.Text = lstvrlBK.Rows[secilisatir].Cells[2].Value.ToString();
            txtaciklamaBK.Text = lstvrlBK.Rows[secilisatir].Cells[3].Value.ToString();
        }
        int secilisatir;

        private void lstvrlBK_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            secilisatir = e.RowIndex;
        }

        private void btngnclBK_Click(object sender, EventArgs e)
        {
            veriGuncelle();
        }                                              
        void veriGuncelle()
        {
            komut.CommandText = "UPDATE TBLStokBK SET " +
    "StokKodBK = '" + txtkodBK.Text + "', " +
    "StokAdBK = '" + txtadBK.Text + "', " +
    "BirimBK = '" + txtbirimBK.Text + "', " +
    "AçıklamaBK = '" + txtaciklamaBK.Text + "' " +
    "WHERE StokKodBK = '" + txtkodBK.Text + "'";

            baglan();
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriGetir();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void btntemizleBK_Click(object sender, EventArgs e)
        {
            txtkodBK.Text = "";
            txtadBK.Text = "";
            txtbirimBK.Text = "";
            txtaciklamaBK.Text = "";
        }
    } }
