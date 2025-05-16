namespace üdev
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkodBK = new System.Windows.Forms.TextBox();
            this.txtadBK = new System.Windows.Forms.TextBox();
            this.txtbirimBK = new System.Windows.Forms.TextBox();
            this.txtaciklamaBK = new System.Windows.Forms.TextBox();
            this.btnekleBK = new System.Windows.Forms.Button();
            this.btnsilBK = new System.Windows.Forms.Button();
            this.btngnclBK = new System.Windows.Forms.Button();
            this.btntemizleBK = new System.Windows.Forms.Button();
            this.lstvrlBK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lstvrlBK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kod";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama";
            // 
            // txtkodBK
            // 
            this.txtkodBK.Location = new System.Drawing.Point(165, 15);
            this.txtkodBK.Name = "txtkodBK";
            this.txtkodBK.Size = new System.Drawing.Size(169, 20);
            this.txtkodBK.TabIndex = 4;
            // 
            // txtadBK
            // 
            this.txtadBK.Location = new System.Drawing.Point(165, 53);
            this.txtadBK.Name = "txtadBK";
            this.txtadBK.Size = new System.Drawing.Size(205, 20);
            this.txtadBK.TabIndex = 5;
            // 
            // txtbirimBK
            // 
            this.txtbirimBK.Location = new System.Drawing.Point(165, 96);
            this.txtbirimBK.Name = "txtbirimBK";
            this.txtbirimBK.Size = new System.Drawing.Size(205, 20);
            this.txtbirimBK.TabIndex = 6;
            // 
            // txtaciklamaBK
            // 
            this.txtaciklamaBK.Location = new System.Drawing.Point(165, 134);
            this.txtaciklamaBK.Name = "txtaciklamaBK";
            this.txtaciklamaBK.Size = new System.Drawing.Size(247, 20);
            this.txtaciklamaBK.TabIndex = 7;
            // 
            // btnekleBK
            // 
            this.btnekleBK.Location = new System.Drawing.Point(185, 196);
            this.btnekleBK.Name = "btnekleBK";
            this.btnekleBK.Size = new System.Drawing.Size(92, 23);
            this.btnekleBK.TabIndex = 8;
            this.btnekleBK.Text = "Kayıt Ekle";
            this.btnekleBK.UseVisualStyleBackColor = true;
            this.btnekleBK.Click += new System.EventHandler(this.btnekleBK_Click);
            // 
            // btnsilBK
            // 
            this.btnsilBK.Location = new System.Drawing.Point(299, 196);
            this.btnsilBK.Name = "btnsilBK";
            this.btnsilBK.Size = new System.Drawing.Size(90, 23);
            this.btnsilBK.TabIndex = 9;
            this.btnsilBK.Text = "Kayıt Sil";
            this.btnsilBK.UseVisualStyleBackColor = true;
            this.btnsilBK.Click += new System.EventHandler(this.button2_Click);
            // 
            // btngnclBK
            // 
            this.btngnclBK.Location = new System.Drawing.Point(413, 196);
            this.btngnclBK.Name = "btngnclBK";
            this.btngnclBK.Size = new System.Drawing.Size(90, 23);
            this.btngnclBK.TabIndex = 11;
            this.btngnclBK.Text = "Kaydı Güncelle";
            this.btngnclBK.UseVisualStyleBackColor = true;
            this.btngnclBK.Click += new System.EventHandler(this.btngnclBK_Click);
            // 
            // btntemizleBK
            // 
            this.btntemizleBK.Location = new System.Drawing.Point(65, 196);
            this.btntemizleBK.Name = "btntemizleBK";
            this.btntemizleBK.Size = new System.Drawing.Size(97, 23);
            this.btntemizleBK.TabIndex = 13;
            this.btntemizleBK.Text = "Verileri Temizle";
            this.btntemizleBK.UseVisualStyleBackColor = true;
            this.btntemizleBK.Click += new System.EventHandler(this.btntemizleBK_Click);
            // 
            // lstvrlBK
            // 
            this.lstvrlBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstvrlBK.Location = new System.Drawing.Point(12, 225);
            this.lstvrlBK.Name = "lstvrlBK";
            this.lstvrlBK.Size = new System.Drawing.Size(776, 213);
            this.lstvrlBK.TabIndex = 15;
            this.lstvrlBK.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstvrlBK_RowEnter);
            this.lstvrlBK.DoubleClick += new System.EventHandler(this.lstvrlBK_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvrlBK);
            this.Controls.Add(this.btntemizleBK);
            this.Controls.Add(this.btngnclBK);
            this.Controls.Add(this.btnsilBK);
            this.Controls.Add(this.btnekleBK);
            this.Controls.Add(this.txtaciklamaBK);
            this.Controls.Add(this.txtbirimBK);
            this.Controls.Add(this.txtadBK);
            this.Controls.Add(this.txtkodBK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstvrlBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkodBK;
        private System.Windows.Forms.TextBox txtadBK;
        private System.Windows.Forms.TextBox txtbirimBK;
        private System.Windows.Forms.TextBox txtaciklamaBK;
        private System.Windows.Forms.Button btnekleBK;
        private System.Windows.Forms.Button btnsilBK;
        private System.Windows.Forms.Button btngnclBK;
        private System.Windows.Forms.Button btntemizleBK;
        private System.Windows.Forms.DataGridView lstvrlBK;
    }
}

