﻿
namespace Pacjenci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.godzina = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.txt_dzis = new System.Windows.Forms.Label();
            this.txt_godz = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.poprzedni_txt = new System.Windows.Forms.Label();
            this.nastepny_txt = new System.Windows.Forms.Label();
            this.wyswietl_txt_pop = new System.Windows.Forms.TextBox();
            this.wyswietl_txt_nast = new System.Windows.Forms.TextBox();
            this.minus_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.usun_txt = new System.Windows.Forms.TextBox();
            this.usun_btn = new System.Windows.Forms.Button();
            this.wyswietl_txt = new System.Windows.Forms.TextBox();
            this.wyswietl_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_zapisz = new System.Windows.Forms.Button();
            this.data_txt = new System.Windows.Forms.Label();
            this.inpt_badanie = new System.Windows.Forms.TextBox();
            this.badanie_txt = new System.Windows.Forms.Label();
            this.imie_txt = new System.Windows.Forms.Label();
            this.inpt_imie = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(620, 243);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 20);
            this.time.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // godzina
            // 
            this.godzina.AutoSize = true;
            this.godzina.Location = new System.Drawing.Point(693, 273);
            this.godzina.Name = "godzina";
            this.godzina.Size = new System.Drawing.Size(63, 20);
            this.godzina.TabIndex = 9;
            this.godzina.Text = "godzina";
            this.godzina.Click += new System.EventHandler(this.godzina_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(693, 243);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(41, 20);
            this.data.TabIndex = 10;
            this.data.Text = "Data";
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // txt_dzis
            // 
            this.txt_dzis.AutoSize = true;
            this.txt_dzis.Location = new System.Drawing.Point(620, 243);
            this.txt_dzis.Name = "txt_dzis";
            this.txt_dzis.Size = new System.Drawing.Size(67, 20);
            this.txt_dzis.TabIndex = 11;
            this.txt_dzis.Text = "Dziś jest:";
            // 
            // txt_godz
            // 
            this.txt_godz.AutoSize = true;
            this.txt_godz.Location = new System.Drawing.Point(620, 273);
            this.txt_godz.Name = "txt_godz";
            this.txt_godz.Size = new System.Drawing.Size(67, 20);
            this.txt_godz.TabIndex = 12;
            this.txt_godz.Text = "Godzina:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.poprzedni_txt);
            this.groupBox1.Controls.Add(this.nastepny_txt);
            this.groupBox1.Controls.Add(this.wyswietl_txt_pop);
            this.groupBox1.Controls.Add(this.wyswietl_txt_nast);
            this.groupBox1.Controls.Add(this.minus_btn);
            this.groupBox1.Controls.Add(this.plus_btn);
            this.groupBox1.Controls.Add(this.usun_txt);
            this.groupBox1.Controls.Add(this.usun_btn);
            this.groupBox1.Controls.Add(this.wyswietl_txt);
            this.groupBox1.Controls.Add(this.wyswietl_btn);
            this.groupBox1.Location = new System.Drawing.Point(320, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 193);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie listą:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Numer osoby w kolejce:";
            // 
            // poprzedni_txt
            // 
            this.poprzedni_txt.AutoSize = true;
            this.poprzedni_txt.Location = new System.Drawing.Point(18, 110);
            this.poprzedni_txt.Name = "poprzedni_txt";
            this.poprzedni_txt.Size = new System.Drawing.Size(78, 20);
            this.poprzedni_txt.TabIndex = 33;
            this.poprzedni_txt.Text = "Poprzedni:";
            // 
            // nastepny_txt
            // 
            this.nastepny_txt.AutoSize = true;
            this.nastepny_txt.Location = new System.Drawing.Point(18, 76);
            this.nastepny_txt.Name = "nastepny_txt";
            this.nastepny_txt.Size = new System.Drawing.Size(74, 20);
            this.nastepny_txt.TabIndex = 32;
            this.nastepny_txt.Text = "Następny:";
            // 
            // wyswietl_txt_pop
            // 
            this.wyswietl_txt_pop.Location = new System.Drawing.Point(98, 107);
            this.wyswietl_txt_pop.Name = "wyswietl_txt_pop";
            this.wyswietl_txt_pop.Size = new System.Drawing.Size(337, 27);
            this.wyswietl_txt_pop.TabIndex = 31;
            // 
            // wyswietl_txt_nast
            // 
            this.wyswietl_txt_nast.Location = new System.Drawing.Point(98, 74);
            this.wyswietl_txt_nast.Name = "wyswietl_txt_nast";
            this.wyswietl_txt_nast.Size = new System.Drawing.Size(337, 27);
            this.wyswietl_txt_nast.TabIndex = 30;
            // 
            // minus_btn
            // 
            this.minus_btn.Location = new System.Drawing.Point(18, 37);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(41, 29);
            this.minus_btn.TabIndex = 29;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(394, 39);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(41, 29);
            this.plus_btn.TabIndex = 28;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            // 
            // usun_txt
            // 
            this.usun_txt.Location = new System.Drawing.Point(284, 143);
            this.usun_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usun_txt.Name = "usun_txt";
            this.usun_txt.Size = new System.Drawing.Size(59, 27);
            this.usun_txt.TabIndex = 27;
            // 
            // usun_btn
            // 
            this.usun_btn.Location = new System.Drawing.Point(349, 141);
            this.usun_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(86, 31);
            this.usun_btn.TabIndex = 26;
            this.usun_btn.Text = "Usuń";
            this.usun_btn.UseVisualStyleBackColor = true;
            // 
            // wyswietl_txt
            // 
            this.wyswietl_txt.Location = new System.Drawing.Point(65, 39);
            this.wyswietl_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wyswietl_txt.Name = "wyswietl_txt";
            this.wyswietl_txt.Size = new System.Drawing.Size(323, 27);
            this.wyswietl_txt.TabIndex = 25;
            // 
            // wyswietl_btn
            // 
            this.wyswietl_btn.Location = new System.Drawing.Point(12, 143);
            this.wyswietl_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wyswietl_btn.Name = "wyswietl_btn";
            this.wyswietl_btn.Size = new System.Drawing.Size(93, 31);
            this.wyswietl_btn.TabIndex = 24;
            this.wyswietl_btn.Text = "WYŚWIETL";
            this.wyswietl_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.dtp_data);
            this.groupBox2.Controls.Add(this.btn_zapisz);
            this.groupBox2.Controls.Add(this.data_txt);
            this.groupBox2.Controls.Add(this.inpt_badanie);
            this.groupBox2.Controls.Add(this.badanie_txt);
            this.groupBox2.Controls.Add(this.imie_txt);
            this.groupBox2.Controls.Add(this.inpt_imie);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 236);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj do listy pacjentów:";
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(5, 158);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(263, 27);
            this.dtp_data.TabIndex = 14;
            // 
            // btn_zapisz
            // 
            this.btn_zapisz.Location = new System.Drawing.Point(174, 197);
            this.btn_zapisz.Name = "btn_zapisz";
            this.btn_zapisz.Size = new System.Drawing.Size(94, 29);
            this.btn_zapisz.TabIndex = 13;
            this.btn_zapisz.Text = "ZAPISZ";
            this.btn_zapisz.UseVisualStyleBackColor = true;
            // 
            // data_txt
            // 
            this.data_txt.AutoSize = true;
            this.data_txt.Location = new System.Drawing.Point(5, 135);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(44, 20);
            this.data_txt.TabIndex = 12;
            this.data_txt.Text = "Data:";
            // 
            // inpt_badanie
            // 
            this.inpt_badanie.Location = new System.Drawing.Point(5, 99);
            this.inpt_badanie.Name = "inpt_badanie";
            this.inpt_badanie.Size = new System.Drawing.Size(263, 27);
            this.inpt_badanie.TabIndex = 11;
            // 
            // badanie_txt
            // 
            this.badanie_txt.AutoSize = true;
            this.badanie_txt.Location = new System.Drawing.Point(5, 72);
            this.badanie_txt.Name = "badanie_txt";
            this.badanie_txt.Size = new System.Drawing.Size(115, 20);
            this.badanie_txt.TabIndex = 10;
            this.badanie_txt.Text = "Nazwa Badania:";
            // 
            // imie_txt
            // 
            this.imie_txt.AutoSize = true;
            this.imie_txt.Location = new System.Drawing.Point(5, 19);
            this.imie_txt.Name = "imie_txt";
            this.imie_txt.Size = new System.Drawing.Size(41, 20);
            this.imie_txt.TabIndex = 9;
            this.imie_txt.Text = "Imię:";
            // 
            // inpt_imie
            // 
            this.inpt_imie.Location = new System.Drawing.Point(5, 42);
            this.inpt_imie.Name = "inpt_imie";
            this.inpt_imie.Size = new System.Drawing.Size(263, 27);
            this.inpt_imie.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_godz);
            this.Controls.Add(this.txt_dzis);
            this.Controls.Add(this.data);
            this.Controls.Add(this.godzina);
            this.Controls.Add(this.time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label godzina;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label txt_dzis;
        private System.Windows.Forms.Label txt_godz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label poprzedni_txt;
        private System.Windows.Forms.Label nastepny_txt;
        private System.Windows.Forms.TextBox wyswietl_txt_pop;
        private System.Windows.Forms.TextBox wyswietl_txt_nast;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.TextBox usun_txt;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.TextBox wyswietl_txt;
        private System.Windows.Forms.Button wyswietl_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_zapisz;
        private System.Windows.Forms.Label data_txt;
        private System.Windows.Forms.TextBox inpt_badanie;
        private System.Windows.Forms.Label badanie_txt;
        private System.Windows.Forms.Label imie_txt;
        private System.Windows.Forms.TextBox inpt_imie;
    }
}

