namespace Uygulama_2_BK
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiselBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITToolStripMenuItem,
            this.rAPORLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYITToolStripMenuItem
            // 
            this.kAYITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiselBilgilerToolStripMenuItem,
            this.derslerToolStripMenuItem});
            this.kAYITToolStripMenuItem.Name = "kAYITToolStripMenuItem";
            this.kAYITToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kAYITToolStripMenuItem.Text = "KAYIT";
            // 
            // kişiselBilgilerToolStripMenuItem
            // 
            this.kişiselBilgilerToolStripMenuItem.Name = "kişiselBilgilerToolStripMenuItem";
            this.kişiselBilgilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kişiselBilgilerToolStripMenuItem.Text = "Kişisel Bilgiler";
            this.kişiselBilgilerToolStripMenuItem.Click += new System.EventHandler(this.kişiselBilgilerToolStripMenuItem_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.derslerToolStripMenuItem.Text = "Dersler";
            this.derslerToolStripMenuItem.Click += new System.EventHandler(this.derslerToolStripMenuItem_Click);
            // 
            // rAPORLARToolStripMenuItem
            // 
            this.rAPORLARToolStripMenuItem.Name = "rAPORLARToolStripMenuItem";
            this.rAPORLARToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rAPORLARToolStripMenuItem.Text = "RAPORLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(322, 152);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiselBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORLARToolStripMenuItem;
    }
}

