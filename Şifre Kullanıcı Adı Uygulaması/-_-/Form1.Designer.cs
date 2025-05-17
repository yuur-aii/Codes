namespace ___
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
            this.klncadlbl_si = new System.Windows.Forms.Label();
            this.sifrelbl_si = new System.Windows.Forms.Label();
            this.klncadtxt_si = new System.Windows.Forms.TextBox();
            this.sifretxt_si = new System.Windows.Forms.TextBox();
            this.gndrbtn_si = new System.Windows.Forms.Button();
            this.ynhspbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // klncadlbl_si
            // 
            this.klncadlbl_si.AutoSize = true;
            this.klncadlbl_si.Location = new System.Drawing.Point(66, 74);
            this.klncadlbl_si.Name = "klncadlbl_si";
            this.klncadlbl_si.Size = new System.Drawing.Size(64, 13);
            this.klncadlbl_si.TabIndex = 0;
            this.klncadlbl_si.Text = "Kullanıcı Adı";
            // 
            // sifrelbl_si
            // 
            this.sifrelbl_si.AutoSize = true;
            this.sifrelbl_si.Location = new System.Drawing.Point(71, 138);
            this.sifrelbl_si.Name = "sifrelbl_si";
            this.sifrelbl_si.Size = new System.Drawing.Size(28, 13);
            this.sifrelbl_si.TabIndex = 1;
            this.sifrelbl_si.Text = "Şifre";
            // 
            // klncadtxt_si
            // 
            this.klncadtxt_si.Location = new System.Drawing.Point(188, 74);
            this.klncadtxt_si.Name = "klncadtxt_si";
            this.klncadtxt_si.Size = new System.Drawing.Size(152, 20);
            this.klncadtxt_si.TabIndex = 2;
            // 
            // sifretxt_si
            // 
            this.sifretxt_si.Location = new System.Drawing.Point(188, 138);
            this.sifretxt_si.Name = "sifretxt_si";
            this.sifretxt_si.Size = new System.Drawing.Size(152, 20);
            this.sifretxt_si.TabIndex = 3;
            // 
            // gndrbtn_si
            // 
            this.gndrbtn_si.Location = new System.Drawing.Point(187, 221);
            this.gndrbtn_si.Name = "gndrbtn_si";
            this.gndrbtn_si.Size = new System.Drawing.Size(138, 29);
            this.gndrbtn_si.TabIndex = 4;
            this.gndrbtn_si.Text = "Gönder";
            this.gndrbtn_si.UseVisualStyleBackColor = true;
            this.gndrbtn_si.Click += new System.EventHandler(this.gndrbtn_si_Click);
            // 
            // ynhspbtn
            // 
            this.ynhspbtn.Location = new System.Drawing.Point(398, 270);
            this.ynhspbtn.Name = "ynhspbtn";
            this.ynhspbtn.Size = new System.Drawing.Size(72, 21);
            this.ynhspbtn.TabIndex = 5;
            this.ynhspbtn.Text = "Yeni Hesap";
            this.ynhspbtn.UseVisualStyleBackColor = true;
            this.ynhspbtn.Click += new System.EventHandler(this.ynhspbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(499, 323);
            this.Controls.Add(this.ynhspbtn);
            this.Controls.Add(this.gndrbtn_si);
            this.Controls.Add(this.sifretxt_si);
            this.Controls.Add(this.klncadtxt_si);
            this.Controls.Add(this.sifrelbl_si);
            this.Controls.Add(this.klncadlbl_si);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label klncadlbl_si;
        private System.Windows.Forms.Label sifrelbl_si;
        private System.Windows.Forms.TextBox klncadtxt_si;
        private System.Windows.Forms.TextBox sifretxt_si;
        private System.Windows.Forms.Button gndrbtn_si;
        private System.Windows.Forms.Button ynhspbtn;
    }
}

