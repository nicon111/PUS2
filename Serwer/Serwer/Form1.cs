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
using System.Threading;

namespace Serwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stop.Enabled = false;
        }

        private TcpListener serwer = null;
        private TcpClient klient = null;

        private void uruchom_Click(object sender, EventArgs e)
        {
            
            IPAddress adresIP = null;
            String port = port2.Text;
            int porcik = System.Convert.ToInt16(port);
            try
            {
                adresIP = IPAddress.Parse(adres2.Text);

                uruchom.Enabled = false;
                stop.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Wystapił błąd z adrem IP");
                listBox1.Text = String.Empty;
                return;
            }

            nawiazaniePolaczenia(porcik, adresIP);

        }

        private void nawiazaniePolaczenia(int porcik, IPAddress adresIP)
        {
            try
            {
                    serwer = new TcpListener(adresIP, porcik);
                    serwer.Start();
                    klient = serwer.AcceptTcpClient();
                    listBox1.Items.Add("Nawiazano polaczenie");
                    listBox1.Refresh();

                    listBox1.Items.Add("Klient się podłączył.....");
                    listBox1.Refresh();
                    
                    komunikatyOdKlienta(klient);
                
            }

            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd połączenia");
                MessageBox.Show(ex.ToString(), "Blad połączenia");
            }
        }

        private void komunikatyOdKlienta(TcpClient klient)
        {  
                int []tab= new int[3];
                for (int i = 0; i < 3; i++)
                {
                    BinaryReader read = new BinaryReader(klient.GetStream());
                    //BinaryWriter write = new BinaryWriter(stream); to bedzie potrzebna do odp
                    string dlugoscBoku = read.ReadString();
                    listBox1.Items.Add(i+1 + " Wiadmość od klienta...... " + dlugoscBoku);

                    tab[i] = System.Convert.ToInt16(dlugoscBoku);
                    
                    listBox1.Refresh();
                }
            
            
        }

        private void stop_Click(object sender, EventArgs e)
        {
            serwer.Stop();
            klient.Close();

            listBox1.Items.Add("Serwer zakończył prace....");
            uruchom.Enabled = true;
            stop.Enabled = false;
        }
    }
}
