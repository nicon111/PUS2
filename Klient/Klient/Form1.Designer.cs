namespace Klient
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
            this.adres = new System.Windows.Forms.Label();
            this.adresBox1 = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.portBox2 = new System.Windows.Forms.TextBox();
            this.butonPolacz = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.wiadomoscBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rozlacz = new System.Windows.Forms.Button();
            this.wyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Location = new System.Drawing.Point(13, 9);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(34, 13);
            this.adres.TabIndex = 0;
            this.adres.Text = "Adres";
            // 
            // adresBox1
            // 
            this.adresBox1.Location = new System.Drawing.Point(16, 25);
            this.adresBox1.Name = "adresBox1";
            this.adresBox1.Size = new System.Drawing.Size(134, 20);
            this.adresBox1.TabIndex = 1;
            this.adresBox1.Text = "127.0.0.1";
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(13, 48);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(26, 13);
            this.port.TabIndex = 2;
            this.port.Text = "Port";
            // 
            // portBox2
            // 
            this.portBox2.Location = new System.Drawing.Point(16, 64);
            this.portBox2.Name = "portBox2";
            this.portBox2.Size = new System.Drawing.Size(134, 20);
            this.portBox2.TabIndex = 3;
            this.portBox2.Text = "27";
            // 
            // butonPolacz
            // 
            this.butonPolacz.Location = new System.Drawing.Point(173, 25);
            this.butonPolacz.Name = "butonPolacz";
            this.butonPolacz.Size = new System.Drawing.Size(75, 23);
            this.butonPolacz.TabIndex = 4;
            this.butonPolacz.Text = "Połącz";
            this.butonPolacz.UseVisualStyleBackColor = true;
            this.butonPolacz.Click += new System.EventHandler(this.buttonPolacz_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(13, 149);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(25, 13);
            this.info.TabIndex = 5;
            this.info.Text = "Info";
            this.info.Click += new System.EventHandler(this.buttonPolacz_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 95);
            this.listBox1.TabIndex = 6;
            // 
            // wiadomoscBox1
            // 
            this.wiadomoscBox1.Location = new System.Drawing.Point(16, 114);
            this.wiadomoscBox1.Name = "wiadomoscBox1";
            this.wiadomoscBox1.Size = new System.Drawing.Size(133, 20);
            this.wiadomoscBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wiadomość do wysłania";
            // 
            // rozlacz
            // 
            this.rozlacz.Location = new System.Drawing.Point(173, 64);
            this.rozlacz.Name = "rozlacz";
            this.rozlacz.Size = new System.Drawing.Size(75, 23);
            this.rozlacz.TabIndex = 9;
            this.rozlacz.Text = "Rozłącz";
            this.rozlacz.UseVisualStyleBackColor = true;
            this.rozlacz.Click += new System.EventHandler(this.rozlacz_Click);
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(173, 110);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(75, 23);
            this.wyslij.TabIndex = 10;
            this.wyslij.Text = "Wyślij";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 272);
            this.Controls.Add(this.wyslij);
            this.Controls.Add(this.rozlacz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wiadomoscBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.butonPolacz);
            this.Controls.Add(this.portBox2);
            this.Controls.Add(this.port);
            this.Controls.Add(this.adresBox1);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.TextBox adresBox1;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox portBox2;
        private System.Windows.Forms.Button butonPolacz;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox wiadomoscBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rozlacz;
        private System.Windows.Forms.Button wyslij;
    }
}

