namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblveri = new System.Windows.Forms.Label();
            this.labelveri = new System.Windows.Forms.Label();
            this.silbtn = new System.Windows.Forms.Button();
            this.telnotxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbladsoyad.Location = new System.Drawing.Point(88, 34);
            this.lbladsoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(61, 13);
            this.lbladsoyad.TabIndex = 0;
            this.lbladsoyad.Text = "Ad Soyad";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.BackColor = System.Drawing.Color.DarkGray;
            this.TxtAdSoyad.Location = new System.Drawing.Point(49, 80);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(241, 20);
            this.TxtAdSoyad.TabIndex = 1;
            this.TxtAdSoyad.TextChanged += new System.EventHandler(this.TxtAdSoyad_TextChanged);
            this.TxtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAdSoyad_KeyPress);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(58, 212);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(218, 44);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(55, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaydedilen Ad Soyad";
            // 
            // lblveri
            // 
            this.lblveri.AutoSize = true;
            this.lblveri.Location = new System.Drawing.Point(41, 309);
            this.lblveri.Name = "lblveri";
            this.lblveri.Size = new System.Drawing.Size(0, 13);
            this.lblveri.TabIndex = 4;
            // 
            // labelveri
            // 
            this.labelveri.AutoSize = true;
            this.labelveri.BackColor = System.Drawing.Color.LightCoral;
            this.labelveri.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelveri.Location = new System.Drawing.Point(46, 307);
            this.labelveri.Name = "labelveri";
            this.labelveri.Size = new System.Drawing.Size(11, 13);
            this.labelveri.TabIndex = 5;
            this.labelveri.Text = "-";
            // 
            // silbtn
            // 
            this.silbtn.ForeColor = System.Drawing.Color.Firebrick;
            this.silbtn.Image = ((System.Drawing.Image)(resources.GetObject("silbtn.Image")));
            this.silbtn.Location = new System.Drawing.Point(12, 337);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(78, 29);
            this.silbtn.TabIndex = 6;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // telnotxt
            // 
            this.telnotxt.BackColor = System.Drawing.Color.DarkGray;
            this.telnotxt.Location = new System.Drawing.Point(49, 162);
            this.telnotxt.Mask = "(999)-000-0000";
            this.telnotxt.Name = "telnotxt";
            this.telnotxt.PasswordChar = '*';
            this.telnotxt.Size = new System.Drawing.Size(241, 20);
            this.telnotxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(88, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(220, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tel No";
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.BackColor = System.Drawing.Color.RosyBrown;
            this.numlbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numlbl.Location = new System.Drawing.Point(207, 307);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(11, 13);
            this.numlbl.TabIndex = 10;
            this.numlbl.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(331, 378);
            this.Controls.Add(this.numlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telnotxt);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.labelveri);
            this.Controls.Add(this.lblveri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.lbladsoyad);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblveri;
        private System.Windows.Forms.Label labelveri;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.MaskedTextBox telnotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numlbl;
    }
}

