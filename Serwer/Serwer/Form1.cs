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

        private int sprawdzCzyMoznaZbudowacTrojkat(int []dlugosciBokow) 
        {
            Array.Sort(dlugosciBokow);
            if(dlugosciBokow[0]+dlugosciBokow[1]>dlugosciBokow[2]){
                return 1;
            }else{
                return 0;
            }
        }

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
                //MessageBox.Show("Wystapił błąd z adrem IP");
                //listBox1.Text = String.Empty;
                return;
            }
            serwer = new TcpListener(adresIP, porcik);
            serwer.Start();
            
            while (true)
            {
                //listBox1.Items.Add("przed accept");
                //listBox1.Refresh();
                klient = serwer.AcceptTcpClient();
                //listBox1.Items.Add("przed watkiem");
                //listBox1.Refresh();
                new Thread(() => this.wymianaDanych(klient)).Start();
            }

        }
        //*************************************************
        /*private void wyswietlenieTekstu(ListBox listBox)
        {
            listBox.Items.Add(tekst);
        }
        public delegate void pobranieTekstu(String tekst);*/
        //*************************************************

        private void wymianaDanych(TcpClient klient)
        {
            try
            {
               
                // It's on a different thread, so use Invoke.
                //SetTextCallback d = new SetTextCallback(SetText);
                //listBox1.Invoke(new pobranieTekstu(this.wyswietlenieTekstu), new object[] { "nawiazano polaczenie" });
                //listBox1.Items.Add("nawiazano polaczenie");
                //this.Invoke (d, new object[] { "Nawiazanie połączenie"  });

                //listBox1.Refresh();
            }

            catch (Exception ex)
            {
                //listBox1.Items.Add("Błąd połączenia");
                //MessageBox.Show(ex.ToString(), "Blad połączenia");
            } 
            int[] tab = new int[3];
            for (int i = 0; i < 3; i++)
            {
                BinaryReader read = new BinaryReader(klient.GetStream());
                //BinaryWriter write = new BinaryWriter(stream); to bedzie potrzebna do odp
                string dlugoscBoku = read.ReadString();
                //listBox1.Items.Add(i + 1 + " Wiadmość od klienta...... " + dlugoscBoku);
                Console.Write(i + 1 + " Wiadmość od klienta...... " + dlugoscBoku);

                tab[i] = System.Convert.ToInt16(dlugoscBoku);
               


                //listBox1.Refresh();
            }
            if (sprawdzCzyMoznaZbudowacTrojkat(tab) == 1)
            {
                Console.Write("Mozna zbudowac trojkat");
            }
            else
            {
                Console.Write("nie mozna zbudowac trujkata");
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            serwer.Stop();
            klient.Close();

            //listBox1.Items.Add("Serwer zakończył prace....");
            uruchom.Enabled = true;
            stop.Enabled = false;
        }
    }
}
