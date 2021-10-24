using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace Pacjenci
{
    public partial class Form1 : Form
    {
//-----------------------Deklaracja zmiennych dla kolejki
        int poczatek = -1;
        int koniec = -1;
        int wielkosc = 50;
        string[,] kolejka = new string[50,3];
        int wyswietlanie_zmienna = 0;
//-----------------------ścieżki i nazwy pliku txt
        string kolejka_txt = @"C:\Users\Public\Downloads\kolejka.txt";

//-----------------------Deklaracja struktury pacjenta
        struct Struktura
        {
            public string imie;
            public string badania;
            public string data;
        }
        Struktura Pacjenci = new Struktura();


//----------------------Funkcja usuń usuwająca dane z kolejki
        void usun()
        {
            if(poczatek == -1|| poczatek > koniec)
            {
                System.Windows.Forms.MessageBox.Show("Kolejka jest przeciążona");
                return;
            }
            else
            {
                wyswietlanie_zmienna++;
                poczatek++;
            }
        }

//-----------------------Funkcja zawierająca wszystkie funkcje dotyczące wyświetlania
        void wyswietlanie()
        {
            if (poczatek == - 1)
            {
                System.Windows.Forms.MessageBox.Show("Mamy za mało wartosci");
                return;
            }
            else
            {
//-----------------------Wyświetlanie głównych wartości
                wyswietl_txt_imie.Text = kolejka[wyswietlanie_zmienna, 0];
                wyswietl_txt_badanie.Text = kolejka[wyswietlanie_zmienna, 1];
                wyswietl_txt_data.Text = kolejka[wyswietlanie_zmienna, 2];
//-----------------------Wyświetlanie poprzednich wartości
                if (wyswietlanie_zmienna > poczatek) 
                {
                    wyswietl_txt_pop_imie.Text = kolejka[wyswietlanie_zmienna - 1, 0];
                    wyswietl_txt_pop_badanie.Text = kolejka[wyswietlanie_zmienna - 1, 1];
                    wyswietl_txt_pop_data.Text = kolejka[wyswietlanie_zmienna-1,2];
                }
                else
                {
                    wyswietl_txt_pop_imie.Text = " ";
                    wyswietl_txt_pop_badanie.Text = " ";
                    wyswietl_txt_pop_data.Text = " ";
                }
//-----------------------Wyświetlanie następnych wartości
                if (wyswietlanie_zmienna != koniec)
                {
                    wyswietl_txt_nast_imie.Text = kolejka[wyswietlanie_zmienna + 1, 0];
                    wyswietl_txt_nast_badanie.Text = kolejka[wyswietlanie_zmienna + 1, 1];
                    wyswietl_txt_nast_data.Text = kolejka[wyswietlanie_zmienna + 1, 2];
                }
                else
                {
                    wyswietl_txt_nast_imie.Text = " ";
                    wyswietl_txt_nast_badanie.Text = " ";
                    wyswietl_txt_nast_data.Text = " ";
                }
            }
//-----------------------Zmiana kolorów dni
            if (wyswietl_txt_data.Text.Contains("Dni:0") == true)
            {
                wyswietl_txt_data.ForeColor = Color.Red;
            }
            else if(wyswietl_txt_data.Text.Contains("-") == true)
            {
                wyswietl_txt_data.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Italic);
                wyswietl_txt_data.ForeColor = Color.Black;
            
            }
            else
            {
                wyswietl_txt_data.ForeColor = Color.Black;
                wyswietl_txt_data.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Regular);
            }
            if (wyswietl_txt_nast_data.Text.Contains("Dni:0") == true)
            {
                wyswietl_txt_nast_data.ForeColor = Color.Red;
            }
            else if (wyswietl_txt_nast_data.Text.Contains("-") == true)
            {
                wyswietl_txt_nast_data.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Italic);
                wyswietl_txt_nast_data.ForeColor = Color.Black;

            }
            else
            {
                wyswietl_txt_nast_data.ForeColor = Color.Black;
                wyswietl_txt_nast_data.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Regular);
            }
            if (wyswietl_txt_pop_data.Text.Contains("Dni:0") == true)
            {
                wyswietl_txt_pop_data.ForeColor = Color.Red;
            }
            else if (wyswietl_txt_pop_data.Text.Contains("-") == true)
            {
                wyswietl_txt_pop_data.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Italic);
                wyswietl_txt_pop_data.ForeColor = Color.Black;

            }
            else
            {
                wyswietl_txt_pop_data.ForeColor = Color.Black;
                wyswietl_txt_pop_data.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Regular);
            }


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
//-----------------------Funkcje odświerzające się w timerze
        private void timer1_Tick(object sender, EventArgs e)
        {
            dtp_data.Format = DateTimePickerFormat.Custom;
            dtp_data.CustomFormat = "dd-MM-yyyy";
            wyswietl_txt_imie.Font = new Font(wyswietl_txt_imie.Font, FontStyle.Bold);
            DateTime godzina = DateTime.Now;
            this.godzina.Text = godzina.ToString("HH:mm");
            this.data.Text = godzina.ToShortDateString();
        }
//-----------------------Przycisk pokazujący następny element w kolejce
        private void plus_btn_Click_1(object sender, EventArgs e)
        {
            if (wyswietlanie_zmienna >= koniec)
            {
                System.Windows.Forms.MessageBox.Show("Dobiłeś do Maksa");
                return;
            }
            else
            {
                wyswietlanie_zmienna++;
                

                wyswietl_txt_imie.Text = kolejka[wyswietlanie_zmienna, 0] ;
                wyswietl_txt_badanie.Text = kolejka[wyswietlanie_zmienna, 1];
                wyswietl_txt_data.Text = kolejka[wyswietlanie_zmienna, 2];
            }
            wyswietlanie();
        }
//-----------------------Przycisk pokazujący poprzedni element w kolejce
        private void minus_btn_Click_1(object sender, EventArgs e)
        {
            if (wyswietlanie_zmienna <= poczatek)
            {
                System.Windows.Forms.MessageBox.Show("Dobiłeś do minimum");
                return;
            }
            else
            {
                wyswietlanie_zmienna--;
                wyswietl_txt_imie.Text = kolejka[wyswietlanie_zmienna, 0];
                wyswietl_txt_badanie.Text = kolejka[wyswietlanie_zmienna, 1];
                wyswietl_txt_data.Text = kolejka[wyswietlanie_zmienna, 2];
            }
            wyswietlanie();
        }
//-----------------------Przycisk zapisujący nowy element w kolejce
        private void btn_zapisz_Click_1(object sender, EventArgs e)
        {
            wyswietl_txt_imie.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_badanie.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_data.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_nast_imie.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_nast_badanie.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_nast_data.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_pop_imie.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_pop_badanie.Font = new Font("Microsoft Sans Serif", 7.5f);
            wyswietl_txt_pop_data.Font = new Font("Microsoft Sans Serif", 7.5f);

            
            if (poczatek == wielkosc-1)
            {
                System.Windows.Forms.MessageBox.Show("Kolejka jest przeciążona");
                return;
            }
            else
            {
                if (poczatek == -1)
                poczatek = 0;
                koniec++;
                DateTime godzina = DateTime.Now;
                Pacjenci.imie = inpt_imie.Text.ToString();
                Pacjenci.badania = inpt_badanie.Text.ToString();
                TimeSpan value = dtp_data.Value.Subtract(godzina);
                Pacjenci.data =  "Dni:"+value.Days.ToString();   
                kolejka[koniec, 0] = "Imie:" + Pacjenci.imie;
                kolejka[koniec, 1] = "Badanie:" + Pacjenci.badania;
                kolejka[koniec, 2] = Pacjenci.data;
            }
            wyswietlanie();
        }
//-----------------------Przycisk wywołujący odświerzenie wyświetlania
        private void wyswietl_btn_Click_1(object sender, EventArgs e)
        {
            wyswietlanie();
        }
//-----------------------Przycisk usuwający pierwszy element w kolejce 
        private void usun_btn_Click_1(object sender, EventArgs e)
        {
            usun();
        }
//-----------------------Przycisk pobierający dane z tabeli a następnie zapisujący je w pliku txt w folderze pobrane 
        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(kolejka_txt))
            {
                using (StreamWriter writer = File.CreateText(kolejka_txt))
                {
                    int i=poczatek;
                    while (i <= koniec)
                    {
                        writer.WriteLine("-----------------------------");
                        writer.WriteLine(kolejka[i, 0].ToString());
                        writer.WriteLine(kolejka[i, 1].ToString());
                        writer.WriteLine(kolejka[i, 2].ToString());
                        writer.WriteLine("-----------------------------");
                        i++;
                    }
                    
                }
            }
        }
    }
}
