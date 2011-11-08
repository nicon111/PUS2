namespace Serwer
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
            this.adres2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.port2 = new System.Windows.Forms.TextBox();
            this.uruchom = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Location = new System.Drawing.Point(13, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(34, 13);
            this.adres.TabIndex = 0;
            this.adres.Text = "Adres";
            // 
            // adres2
            // 
            this.adres2.Location = new System.Drawing.Point(16, 30);
            this.adres2.Name = "adres2";
            this.adres2.Size = new System.Drawing.Size(100, 20);
            this.adres2.TabIndex = 1;
            this.adres2.Text = "127.0.0.1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 95);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(16, 74);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(100, 20);
            this.port2.TabIndex = 5;
            this.port2.Text = "27";
            // 
            // uruchom
            // 
            this.uruchom.Location = new System.Drawing.Point(145, 27);
            this.uruchom.Name = "uruchom";
            this.uruchom.Size = new System.Drawing.Size(75, 23);
            this.uruchom.TabIndex = 6;
            this.uruchom.Text = "Uruchom";
            this.uruchom.UseVisualStyleBackColor = true;
            this.uruchom.Click += new System.EventHandler(this.uruchom_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(145, 71);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.uruchom);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adres2);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.TextBox adres2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.Button uruchom;
        private System.Windows.Forms.Button stop;
    }
}

