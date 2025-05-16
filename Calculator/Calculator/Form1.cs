using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class panel : Form
    {
        private char ekrann;
        private char _islem;
        private bool _ekrantemizligi;
        private int _ilksayi;

        public panel()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "2";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "1";

        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "4";
        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "5";
        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "6";
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "7";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "8";
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "9";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizligi == true) ekran.Text = "";
            _ekrantemizligi = false;
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void Sonuc_Click(object sender, EventArgs e)
        {
           
        }

        private void sonuc_Click_1(object sender, EventArgs e)
        {
            int _ikincisayi = Convert.ToInt32(ekran.Text);
            int sonucc;
            switch (_islem)
            {
                case '+':
                    sonucc = _ilksayi + _ikincisayi;
                    break;
                case '-':

                    sonucc = _ilksayi - _ikincisayi;

                    break;
                case 'x':
                    sonucc = _ilksayi * _ikincisayi;
                    break;
                case '/':
                    sonucc = _ilksayi / _ikincisayi;
                    break;
                default:
                    sonucc = 0;
                    break;

            }
            ekran.Text = Convert.ToString(sonucc);
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekrantemizligi = true;
            _ilksayi = Convert.ToInt32(ekran.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ekran_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
    } 
