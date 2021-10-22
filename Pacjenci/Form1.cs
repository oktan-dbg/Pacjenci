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
        int poczatek = 0;
        string koniec = "";
        int wielkosc = 0;
        string[] kolejka = new string[5];
        int wyswietlanie_zmienna = 0;
        //TextBox wyswietl = new TextBox();
        string wszystko = "";

        struct Struktura
        {
            public string imie;
            public string badania;
            public DateTime data;
        }
        Struktura Pacjenci = new Struktura();

        void usun()
        {
            if (wielkosc <= 1)
            {
                System.Windows.Forms.MessageBox.Show("Nie mamy czego usunac");
                return;


            }
            else {
                for (int i = 1; i < wielkosc; i++)
                {
                    kolejka[i - 1] = kolejka[i];
                }

                wielkosc--;
            }
        }
        void wyswietlanie()
        {
            if (wielkosc < 0)
            {
                System.Windows.Forms.MessageBox.Show("Mamy za mało wartosci");
                return;
            }
            else
            {
                string zwracana_wartosc = kolejka[wyswietlanie_zmienna];
                wyswietl_txt.Text=zwracana_wartosc;
                wyswietl_txt_nast.Text = kolejka[wyswietlanie_zmienna + 1];
                if (wyswietlanie_zmienna > 0) 
                {
                    wyswietl_txt_pop.Text = kolejka[wyswietlanie_zmienna - 1];
                }
                else
                {
                    wyswietl_txt_pop.Text = " ";
                }
            }

            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wyswietlanie();
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
            if(wyswietlanie_zmienna==0)
            {
                wyswietl_txt.Font = new Font(wyswietl_txt.Font, FontStyle.Bold);
            }
            else
            {
                wyswietl_txt.Font = new Font(wyswietl_txt.Font, FontStyle.Regular);
            }
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

        private void wyswietl_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_btn_Click_1(object sender, EventArgs e)
        {
            if (wyswietlanie_zmienna >= 4)
            {
                System.Windows.Forms.MessageBox.Show("Dobiłeś do Maksa");
                return;
            }
            else
            {
                wyswietlanie_zmienna++;
                string zwracana_wartosc2 = kolejka[wyswietlanie_zmienna];

                wyswietl_txt.Text = zwracana_wartosc2;
            }
            wyswietlanie();
        }

        private void minus_btn_Click_1(object sender, EventArgs e)
        {
            if (wyswietlanie_zmienna <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Dobiłeś do minimum");
                return;
            }
            else
            {
                wyswietlanie_zmienna--;
                string zwracana_wartosc3 = kolejka[wyswietlanie_zmienna];
                wyswietl_txt.Text = zwracana_wartosc3;
            }
            wyswietlanie();
        }

        private void btn_zapisz_Click_1(object sender, EventArgs e)
        {
            Pacjenci.imie = inpt_imie.Text.ToString();
            Pacjenci.badania = inpt_badanie.Text.ToString();
            Pacjenci.data = dtp_data.Value;
            wszystko = Pacjenci.imie + " " + Pacjenci.badania + " " + Pacjenci.data;

            if (wielkosc > 4)
            {
                System.Windows.Forms.MessageBox.Show("Kolejka jest pełna");
                return;
            }


            kolejka[wielkosc] = wszystko;
            wielkosc++;
            poczatek++;
            koniec = kolejka[0];
            wyswietlanie();
        }

        private void wyswietl_btn_Click_1(object sender, EventArgs e)
        {
            wyswietlanie();
        }

        private void usun_btn_Click_1(object sender, EventArgs e)
        {
            usun();
        }
    }
}
