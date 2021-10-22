using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacjenci
{
    public partial class Form1 : Form
    {
        int poczatek=0;
        string koniec = "";
        int wielkosc=0;
        string[] kolejka=new string[5];   

        void usun()
        {
            if (wielkosc < 1)
            {
                System.Windows.Forms.MessageBox.Show("Nie mamy czego usunac");
                return;

                
            }
            for (int i = 1; i < wielkosc; i++)
            {
               kolejka[i - 1] = kolejka[i];
            }

            wielkosc--;
        }
        void wyswietlanie()
        {
            if (wielkosc < 1)
            {
                
                return;
            }

            string zwracana_wartosc = kolejka[0];

            for (int i = 1; i < wielkosc; i++)
            {
                kolejka[i - 1] = kolejka[i];
            }

            wielkosc--;

            this.wyswietl_txt.Text=zwracana_wartosc;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void imie_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime godzina = DateTime.Now;
            this.godzina.Text = godzina.ToString("HH:mm");
            this.data.Text = godzina.ToShortDateString();
        }

        private void data_Click(object sender, EventArgs e)
        {

        }

        private void godzina_Click(object sender, EventArgs e)
        {

        }
        int zmienna=0;
        string wszystko="";

        private void btn_zapisz_Click(object sender, EventArgs e)
        {
            zmienna++;
            var Imie = inpt_imie.Text.ToString();
            var Nazwisko = inpt_badanie.Text.ToString();
            var Data = dtp_data.Value.ToString();
            wszystko = Imie +" "+ Nazwisko +" "+ Data;

            if (wielkosc > 5)
            {
                System.Windows.Forms.MessageBox.Show("Kolejka jest pełna");
                return;
            }


            kolejka[wielkosc] = wszystko;
            wielkosc++;
            poczatek++;
            koniec = kolejka[0];

        }

        private void wyswietl_btn_Click(object sender, EventArgs e)
        {
            wyswietlanie();
            //this.wyswietl_txt.Text = wszystko;
        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            //int liczba = Int32.Parse(usun_txt.Text);
            usun();
        }
    }
}
