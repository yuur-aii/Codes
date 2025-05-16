namespace items
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
            this.illerlbl = new System.Windows.Forms.Label();
            this.illercmbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eklebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstsehirler = new System.Windows.Forms.ListBox();
            this.btnsehirekle = new System.Windows.Forms.Button();
            this.sehirtxt = new System.Windows.Forms.TextBox();
            this.silbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // illerlbl
            // 
            this.illerlbl.AutoSize = true;
            this.illerlbl.Location = new System.Drawing.Point(59, 42);
            this.illerlbl.Name = "illerlbl";
            this.illerlbl.Size = new System.Drawing.Size(23, 13);
            this.illerlbl.TabIndex = 0;
            this.illerlbl.Text = "İller";
            // 
            // illercmbx
            // 
            this.illercmbx.FormattingEnabled = true;
            this.illercmbx.Location = new System.Drawing.Point(47, 83);
            this.illercmbx.Name = "illercmbx";
            this.illercmbx.Size = new System.Drawing.Size(186, 21);
            this.illercmbx.TabIndex = 1;
            this.illercmbx.SelectedIndexChanged += new System.EventHandler(this.illercmbx_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.illercmbx);
            this.groupBox1.Controls.Add(this.illerlbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.silbtn);
            this.panel1.Controls.Add(this.sehirtxt);
            this.panel1.Controls.Add(this.btnsehirekle);
            this.panel1.Controls.Add(this.eklebtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(289, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 361);
            this.panel1.TabIndex = 3;
            // 
            // eklebtn
            // 
            this.eklebtn.Location = new System.Drawing.Point(48, 149);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(118, 27);
            this.eklebtn.TabIndex = 2;
            this.eklebtn.Text = "Diziden Ekle";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deactive";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstsehirler
            // 
            this.lstsehirler.BackColor = System.Drawing.Color.Moccasin;
            this.lstsehirler.FormattingEnabled = true;
            this.lstsehirler.Location = new System.Drawing.Point(12, 221);
            this.lstsehirler.Name = "lstsehirler";
            this.lstsehirler.Size = new System.Drawing.Size(270, 147);
            this.lstsehirler.TabIndex = 4;
            // 
            // btnsehirekle
            // 
            this.btnsehirekle.Location = new System.Drawing.Point(46, 80);
            this.btnsehirekle.Name = "btnsehirekle";
            this.btnsehirekle.Size = new System.Drawing.Size(129, 24);
            this.btnsehirekle.TabIndex = 3;
            this.btnsehirekle.Text = "Ekle";
            this.btnsehirekle.UseVisualStyleBackColor = true;
            this.btnsehirekle.Click += new System.EventHandler(this.btnsehirekle_Click);
            // 
            // sehirtxt
            // 
            this.sehirtxt.Location = new System.Drawing.Point(31, 35);
            this.sehirtxt.Name = "sehirtxt";
            this.sehirtxt.Size = new System.Drawing.Size(154, 20);
            this.sehirtxt.TabIndex = 4;
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(48, 196);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(118, 22);
            this.silbtn.TabIndex = 5;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 419);
            this.Controls.Add(this.lstsehirler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label illerlbl;
        private System.Windows.Forms.ComboBox illercmbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstsehirler;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.TextBox sehirtxt;
        private System.Windows.Forms.Button btnsehirekle;
        private System.Windows.Forms.Button silbtn;
    }
}

