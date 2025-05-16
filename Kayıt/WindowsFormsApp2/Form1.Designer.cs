namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Birim");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Kod");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Ad");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Açıklama");
            this.tcno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstokkodbk = new System.Windows.Forms.TextBox();
            this.txtstokadbk = new System.Windows.Forms.TextBox();
            this.txtacıklamabk = new System.Windows.Forms.TextBox();
            this.lstverilerbk = new System.Windows.Forms.ListView();
            this.btnKaydetbk = new System.Windows.Forms.Button();
            this.btnkytsilbk = new System.Windows.Forms.Button();
            this.btntemizlebk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbirimbk = new System.Windows.Forms.TextBox();
            this.guncellebtnbk = new System.Windows.Forms.Button();
            this.getirbtnbk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tcno
            // 
            this.tcno.AutoSize = true;
            this.tcno.Location = new System.Drawing.Point(89, 70);
            this.tcno.Name = "tcno";
            this.tcno.Size = new System.Drawing.Size(51, 13);
            this.tcno.TabIndex = 0;
            this.tcno.Text = "Stok Kod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // txtstokkodbk
            // 
            this.txtstokkodbk.Location = new System.Drawing.Point(146, 67);
            this.txtstokkodbk.Name = "txtstokkodbk";
            this.txtstokkodbk.Size = new System.Drawing.Size(176, 20);
            this.txtstokkodbk.TabIndex = 3;
            // 
            // txtstokadbk
            // 
            this.txtstokadbk.Location = new System.Drawing.Point(146, 107);
            this.txtstokadbk.Name = "txtstokadbk";
            this.txtstokadbk.Size = new System.Drawing.Size(289, 20);
            this.txtstokadbk.TabIndex = 4;
            // 
            // txtacıklamabk
            // 
            this.txtacıklamabk.Location = new System.Drawing.Point(146, 148);
            this.txtacıklamabk.Name = "txtacıklamabk";
            this.txtacıklamabk.Size = new System.Drawing.Size(289, 20);
            this.txtacıklamabk.TabIndex = 5;
            // 
            // lstverilerbk
            // 
            this.lstverilerbk.BackColor = System.Drawing.Color.Wheat;
            this.lstverilerbk.HideSelection = false;
            listViewItem1.IndentCount = 70;
            listViewItem2.IndentCount = 70;
            listViewItem3.IndentCount = 100;
            listViewItem4.IndentCount = 150;
            this.lstverilerbk.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstverilerbk.Location = new System.Drawing.Point(12, 243);
            this.lstverilerbk.Name = "lstverilerbk";
            this.lstverilerbk.Size = new System.Drawing.Size(772, 163);
            this.lstverilerbk.TabIndex = 6;
            this.lstverilerbk.UseCompatibleStateImageBehavior = false;
            this.lstverilerbk.DoubleClick += new System.EventHandler(this.lstveriler_DoubleClick);
            // 
            // btnKaydetbk
            // 
            this.btnKaydetbk.Location = new System.Drawing.Point(93, 193);
            this.btnKaydetbk.Name = "btnKaydetbk";
            this.btnKaydetbk.Size = new System.Drawing.Size(110, 32);
            this.btnKaydetbk.TabIndex = 7;
            this.btnKaydetbk.Text = "Kaydet";
            this.btnKaydetbk.UseVisualStyleBackColor = true;
            this.btnKaydetbk.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnkytsilbk
            // 
            this.btnkytsilbk.Location = new System.Drawing.Point(225, 194);
            this.btnkytsilbk.Name = "btnkytsilbk";
            this.btnkytsilbk.Size = new System.Drawing.Size(125, 31);
            this.btnkytsilbk.TabIndex = 8;
            this.btnkytsilbk.Text = "Sil";
            this.btnkytsilbk.UseVisualStyleBackColor = true;
            this.btnkytsilbk.Click += new System.EventHandler(this.btnkytsil_Click);
            // 
            // btntemizlebk
            // 
            this.btntemizlebk.Location = new System.Drawing.Point(655, 194);
            this.btntemizlebk.Name = "btntemizlebk";
            this.btntemizlebk.Size = new System.Drawing.Size(119, 31);
            this.btntemizlebk.TabIndex = 9;
            this.btntemizlebk.Text = "Temizle";
            this.btntemizlebk.UseVisualStyleBackColor = true;
            this.btntemizlebk.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Birim";
            // 
            // txtbirimbk
            // 
            this.txtbirimbk.Location = new System.Drawing.Point(146, 34);
            this.txtbirimbk.Name = "txtbirimbk";
            this.txtbirimbk.Size = new System.Drawing.Size(176, 20);
            this.txtbirimbk.TabIndex = 11;
            // 
            // guncellebtnbk
            // 
            this.guncellebtnbk.Location = new System.Drawing.Point(370, 194);
            this.guncellebtnbk.Name = "guncellebtnbk";
            this.guncellebtnbk.Size = new System.Drawing.Size(119, 31);
            this.guncellebtnbk.TabIndex = 12;
            this.guncellebtnbk.Text = "Güncelle";
            this.guncellebtnbk.UseVisualStyleBackColor = true;
            this.guncellebtnbk.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // getirbtnbk
            // 
            this.getirbtnbk.Location = new System.Drawing.Point(514, 194);
            this.getirbtnbk.Name = "getirbtnbk";
            this.getirbtnbk.Size = new System.Drawing.Size(119, 31);
            this.getirbtnbk.TabIndex = 13;
            this.getirbtnbk.Text = "Tek Veri Getir";
            this.getirbtnbk.UseVisualStyleBackColor = true;
            this.getirbtnbk.Click += new System.EventHandler(this.getirbtnbk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.getirbtnbk);
            this.Controls.Add(this.guncellebtnbk);
            this.Controls.Add(this.txtbirimbk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntemizlebk);
            this.Controls.Add(this.btnkytsilbk);
            this.Controls.Add(this.btnKaydetbk);
            this.Controls.Add(this.lstverilerbk);
            this.Controls.Add(this.txtacıklamabk);
            this.Controls.Add(this.txtstokadbk);
            this.Controls.Add(this.txtstokkodbk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tcno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstokkodbk;
        private System.Windows.Forms.TextBox txtstokadbk;
        private System.Windows.Forms.TextBox txtacıklamabk;
        private System.Windows.Forms.ListView lstverilerbk;
        private System.Windows.Forms.Button btnKaydetbk;
        private System.Windows.Forms.Button btnkytsilbk;
        private System.Windows.Forms.Button btntemizlebk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbirimbk;
        private System.Windows.Forms.Button guncellebtnbk;
        private System.Windows.Forms.Button getirbtnbk;
    }
}

