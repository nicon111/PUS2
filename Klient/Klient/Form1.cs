using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rozlacz.Enabled = false;
        }

        private TcpClient tcpClient;

        private void buttonPolacz_Click(object sender, EventArgs e)
        {
            try
            {
                String adresik = adresBox1.Text;
                String portPolaczenia = portBox2.Text;
                int porcik = System.Convert.ToInt16(portPolaczenia);

                rozlacz.Enabled = true;
                butonPolacz.Enabled = false;

                tcpClient = new TcpClient(adresik, porcik);
                
                listBox1.Items.Add("Nawiazywanie polaczenia z " + adresik + " na porcie " + porcik);
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Wystapil blad podczas polaczenia " + ex);
            }
        }

        private void rozlacz_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
            rozlacz.Enabled = false;
            butonPolacz.Enabled = true;
            listBox1.Items.Add("Klient zakonczył prace....");

        }

        private void wyslij_Click(object sender, EventArgs e)
        {
            NetworkStream strumien = tcpClient.GetStream();
            BinaryWriter pisz = new BinaryWriter(strumien);
            pisz.Flush();
            pisz.Write(wiadomoscBox1.Text);
            listBox1.Items.Add("Wiadmość została wysłania");
        }
    }
}
