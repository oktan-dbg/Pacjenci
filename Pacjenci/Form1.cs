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
        string[,] kolejka = new string[5,3];
        int wyswietlanie_zmienna = 0;
        //TextBox wyswietl = new TextBox();
        string wszystko = "";

        struct Struktura
        {
            public string imie;
            public string badania;
            public string data;
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
                    kolejka[0,i - 1] = kolejka[0,i];
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
                string zwracana_wartosc = kolejka[wyswietlanie_zmienna,0] + kolejka[wyswietlanie_zmienna,1] + kolejka[wyswietlanie_zmienna,2];
                wyswietl_txt.Text = kolejka[wyswietlanie_zmienna, 0] + kolejka[wyswietlanie_zmienna, 1];
                wyswietl_txt_dwa.Text = kolejka[wyswietlanie_zmienna, 2];
                if (wyswietlanie_zmienna > 0) 
                {
                    wyswietl_txt_pop.Text = kolejka[wyswietlanie_zmienna-1,0] + kolejka[wyswietlanie_zmienna-1,1] + kolejka[wyswietlanie_zmienna-1,2];
                }
                else
                {
                    wyswietl_txt_pop.Text = " "; 
                }
                if (wyswietlanie_zmienna != 4)
                {
                    wyswietl_txt_nast.Text = kolejka[wyswietlanie_zmienna + 1, 0] + kolejka[wyswietlanie_zmienna + 1, 1] + kolejka[wyswietlanie_zmienna + 1, 2];
                }
                else
                {
                    wyswietl_txt_nast.Text = " ";
                }
            }
            if (wyswietl_txt.Text.Contains("Dni:0") == true)
            {
                wyswietl_txt.ForeColor = Color.Red;
                wyswietl_txt.Font = new Font(wyswietl_txt.Font, FontStyle.Italic);
            }
            else
            {
                wyswietl_txt.ForeColor = Color.Black;
                wyswietl_txt.Font = new Font(wyswietl_txt.Font, FontStyle.Bold);
            }
            if (wyswietl_txt_nast.Text.Contains("Dni:0") == true)
            {
                wyswietl_txt_nast.ForeColor = Color.Red;
                wyswietl_txt_nast.Font = new Font(wyswietl_txt.Font, FontStyle.Italic);
            }
            else
            {
                wyswietl_txt_nast.ForeColor = Color.Black;
                wyswietl_txt_nast.Font = new Font(wyswietl_txt.Font, FontStyle.Regular);
            }
            if (wyswietl_txt_pop.Text.Contains("Dni:0") == true)
            {
                wyswietl_txt_pop.ForeColor = Color.Red;
                wyswietl_txt_pop.Font = new Font(wyswietl_txt.Font, FontStyle.Italic);
            }
            else
            {
                wyswietl_txt_pop.ForeColor = Color.Black;
                wyswietl_txt_pop.Font = new Font(wyswietl_txt.Font, FontStyle.Regular);
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
            wyswietl_txt.Font = new Font(wyswietl_txt.Font, FontStyle.Bold);
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
                string zwracana_wartosc2 = kolejka[wyswietlanie_zmienna,0] + kolejka[wyswietlanie_zmienna, 1] + kolejka[wyswietlanie_zmienna, 2];

                wyswietl_txt.Text = kolejka[wyswietlanie_zmienna, 0] + kolejka[wyswietlanie_zmienna, 1];
                wyswietl_txt_dwa.Text = kolejka[wyswietlanie_zmienna, 2];
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
                string zwracana_wartosc3 = kolejka[wyswietlanie_zmienna, 0]+ kolejka[wyswietlanie_zmienna, 1]+ kolejka[wyswietlanie_zmienna, 2];
                wyswietl_txt.Text = kolejka[wyswietlanie_zmienna, 0] + kolejka[wyswietlanie_zmienna, 1];
                wyswietl_txt_dwa.Text = kolejka[wyswietlanie_zmienna, 2];
            }
            wyswietlanie();
        }

        private void btn_zapisz_Click_1(object sender, EventArgs e)
        {
            wyswietl_txt.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_nast.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_pop.Font = new Font("Microsoft Sans Serif", 7.5f);
            DateTime godzina = DateTime.Now;
            Pacjenci.imie = inpt_imie.Text.ToString();
            Pacjenci.badania = inpt_badanie.Text.ToString();
            TimeSpan value = dtp_data.Value.Subtract(godzina);
            Pacjenci.data =  "Dni:"+value.Days.ToString() + " " + "Godz:"+value.Hours.ToString()+" "+"Min:"+value.Minutes.ToString();
            wszystko = "Imie:"+Pacjenci.imie+" "+ "Badanie:" + Pacjenci.badania + " " + Pacjenci.data;

            if (wielkosc > 4)
            {
                System.Windows.Forms.MessageBox.Show("Kolejka jest pełna");
                return;
            }


            kolejka[wielkosc, 0] = "Imie:" + Pacjenci.imie;
            kolejka[wielkosc, 1] = "Badanie:" + Pacjenci.badania;
            kolejka[wielkosc, 2] = Pacjenci.data;
            wielkosc++;
            poczatek++;
            koniec = kolejka[0, 0];
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
