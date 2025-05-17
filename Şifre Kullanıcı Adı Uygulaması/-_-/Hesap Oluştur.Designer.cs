namespace ___
{
    partial class Hesap_Oluştur
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
            this.yeniklncadtxt = new System.Windows.Forms.TextBox();
            this.ynsfrtxt = new System.Windows.Forms.TextBox();
            this.sfryndntxt = new System.Windows.Forms.TextBox();
            this.gndrbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifreniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Yeniden";
            // 
            // yeniklncadtxt
            // 
            this.yeniklncadtxt.Location = new System.Drawing.Point(145, 68);
            this.yeniklncadtxt.Name = "yeniklncadtxt";
            this.yeniklncadtxt.Size = new System.Drawing.Size(147, 20);
            this.yeniklncadtxt.TabIndex = 3;
            // 
            // ynsfrtxt
            // 
            this.ynsfrtxt.Location = new System.Drawing.Point(145, 129);
            this.ynsfrtxt.Name = "ynsfrtxt";
            this.ynsfrtxt.Size = new System.Drawing.Size(147, 20);
            this.ynsfrtxt.TabIndex = 4;
            // 
            // sfryndntxt
            // 
            this.sfryndntxt.Location = new System.Drawing.Point(145, 198);
            this.sfryndntxt.Name = "sfryndntxt";
            this.sfryndntxt.Size = new System.Drawing.Size(147, 20);
            this.sfryndntxt.TabIndex = 5;
            // 
            // gndrbtn
            // 
            this.gndrbtn.Location = new System.Drawing.Point(128, 254);
            this.gndrbtn.Name = "gndrbtn";
            this.gndrbtn.Size = new System.Drawing.Size(89, 28);
            this.gndrbtn.TabIndex = 6;
            this.gndrbtn.Text = "Gönder";
            this.gndrbtn.UseVisualStyleBackColor = true;
            this.gndrbtn.Click += new System.EventHandler(this.gndrbtn_Click);
            // 
            // Hesap_Oluştur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(373, 313);
            this.Controls.Add(this.gndrbtn);
            this.Controls.Add(this.sfryndntxt);
            this.Controls.Add(this.ynsfrtxt);
            this.Controls.Add(this.yeniklncadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hesap_Oluştur";
            this.Text = "Hesap_Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yeniklncadtxt;
        private System.Windows.Forms.TextBox ynsfrtxt;
        private System.Windows.Forms.TextBox sfryndntxt;
        private System.Windows.Forms.Button gndrbtn;
    }
}