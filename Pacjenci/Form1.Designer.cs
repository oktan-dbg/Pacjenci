
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
            this.inpt_imie = new System.Windows.Forms.TextBox();
            this.imie_txt = new System.Windows.Forms.Label();
            this.badanie_txt = new System.Windows.Forms.Label();
            this.inpt_badanie = new System.Windows.Forms.TextBox();
            this.data_txt = new System.Windows.Forms.Label();
            this.btn_zapisz = new System.Windows.Forms.Button();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.godzina = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.txt_dzis = new System.Windows.Forms.Label();
            this.txt_godz = new System.Windows.Forms.Label();
            this.wyswietl_btn = new System.Windows.Forms.Button();
            this.wyswietl_txt = new System.Windows.Forms.TextBox();
            this.usun_btn = new System.Windows.Forms.Button();
            this.usun_txt = new System.Windows.Forms.TextBox();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inpt_imie
            // 
            this.inpt_imie.Location = new System.Drawing.Point(73, 25);
            this.inpt_imie.Name = "inpt_imie";
            this.inpt_imie.Size = new System.Drawing.Size(111, 27);
            this.inpt_imie.TabIndex = 0;
            // 
            // imie_txt
            // 
            this.imie_txt.AutoSize = true;
            this.imie_txt.Location = new System.Drawing.Point(29, 28);
            this.imie_txt.Name = "imie_txt";
            this.imie_txt.Size = new System.Drawing.Size(41, 20);
            this.imie_txt.TabIndex = 1;
            this.imie_txt.Text = "Imię:";
            this.imie_txt.Click += new System.EventHandler(this.imie_Click);
            // 
            // badanie_txt
            // 
            this.badanie_txt.AutoSize = true;
            this.badanie_txt.Location = new System.Drawing.Point(190, 28);
            this.badanie_txt.Name = "badanie_txt";
            this.badanie_txt.Size = new System.Drawing.Size(115, 20);
            this.badanie_txt.TabIndex = 2;
            this.badanie_txt.Text = "Nazwa Badania:";
            // 
            // inpt_badanie
            // 
            this.inpt_badanie.Location = new System.Drawing.Point(309, 25);
            this.inpt_badanie.Name = "inpt_badanie";
            this.inpt_badanie.Size = new System.Drawing.Size(103, 27);
            this.inpt_badanie.TabIndex = 3;
            this.inpt_badanie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // data_txt
            // 
            this.data_txt.AutoSize = true;
            this.data_txt.Location = new System.Drawing.Point(417, 29);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(44, 20);
            this.data_txt.TabIndex = 5;
            this.data_txt.Text = "Data:";
            // 
            // btn_zapisz
            // 
            this.btn_zapisz.Location = new System.Drawing.Point(694, 71);
            this.btn_zapisz.Name = "btn_zapisz";
            this.btn_zapisz.Size = new System.Drawing.Size(94, 29);
            this.btn_zapisz.TabIndex = 6;
            this.btn_zapisz.Text = "ZAPISZ";
            this.btn_zapisz.UseVisualStyleBackColor = true;
            this.btn_zapisz.Click += new System.EventHandler(this.btn_zapisz_Click);
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(464, 25);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(266, 27);
            this.dtp_data.TabIndex = 7;
            this.dtp_data.ValueChanged += new System.EventHandler(this.dtp_data_ValueChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(29, 71);
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
            this.godzina.Location = new System.Drawing.Point(102, 101);
            this.godzina.Name = "godzina";
            this.godzina.Size = new System.Drawing.Size(63, 20);
            this.godzina.TabIndex = 9;
            this.godzina.Text = "godzina";
            this.godzina.Click += new System.EventHandler(this.godzina_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(102, 71);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(41, 20);
            this.data.TabIndex = 10;
            this.data.Text = "Data";
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // txt_dzis
            // 
            this.txt_dzis.AutoSize = true;
            this.txt_dzis.Location = new System.Drawing.Point(29, 71);
            this.txt_dzis.Name = "txt_dzis";
            this.txt_dzis.Size = new System.Drawing.Size(67, 20);
            this.txt_dzis.TabIndex = 11;
            this.txt_dzis.Text = "Dziś jest:";
            // 
            // txt_godz
            // 
            this.txt_godz.AutoSize = true;
            this.txt_godz.Location = new System.Drawing.Point(29, 101);
            this.txt_godz.Name = "txt_godz";
            this.txt_godz.Size = new System.Drawing.Size(67, 20);
            this.txt_godz.TabIndex = 12;
            this.txt_godz.Text = "Godzina:";
            // 
            // wyswietl_btn
            // 
            this.wyswietl_btn.Location = new System.Drawing.Point(694, 245);
            this.wyswietl_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wyswietl_btn.Name = "wyswietl_btn";
            this.wyswietl_btn.Size = new System.Drawing.Size(93, 31);
            this.wyswietl_btn.TabIndex = 13;
            this.wyswietl_btn.Text = "WYŚWIETL";
            this.wyswietl_btn.UseVisualStyleBackColor = true;
            this.wyswietl_btn.Click += new System.EventHandler(this.wyswietl_btn_Click);
            // 
            // wyswietl_txt
            // 
            this.wyswietl_txt.Location = new System.Drawing.Point(29, 247);
            this.wyswietl_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wyswietl_txt.Name = "wyswietl_txt";
            this.wyswietl_txt.Size = new System.Drawing.Size(323, 27);
            this.wyswietl_txt.TabIndex = 14;
            // 
            // usun_btn
            // 
            this.usun_btn.Location = new System.Drawing.Point(89, 125);
            this.usun_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usun_btn.Name = "usun_btn";
            this.usun_btn.Size = new System.Drawing.Size(86, 31);
            this.usun_btn.TabIndex = 15;
            this.usun_btn.Text = "Usuń";
            this.usun_btn.UseVisualStyleBackColor = true;
            this.usun_btn.Click += new System.EventHandler(this.usun_btn_Click);
            // 
            // usun_txt
            // 
            this.usun_txt.Location = new System.Drawing.Point(29, 127);
            this.usun_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usun_txt.Name = "usun_txt";
            this.usun_txt.Size = new System.Drawing.Size(59, 27);
            this.usun_txt.TabIndex = 16;
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(311, 281);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(41, 29);
            this.plus_btn.TabIndex = 17;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.Location = new System.Drawing.Point(264, 281);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(41, 29);
            this.minus_btn.TabIndex = 18;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.usun_txt);
            this.Controls.Add(this.usun_btn);
            this.Controls.Add(this.wyswietl_txt);
            this.Controls.Add(this.wyswietl_btn);
            this.Controls.Add(this.txt_godz);
            this.Controls.Add(this.txt_dzis);
            this.Controls.Add(this.data);
            this.Controls.Add(this.godzina);
            this.Controls.Add(this.time);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.btn_zapisz);
            this.Controls.Add(this.data_txt);
            this.Controls.Add(this.inpt_badanie);
            this.Controls.Add(this.badanie_txt);
            this.Controls.Add(this.imie_txt);
            this.Controls.Add(this.inpt_imie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpt_imie;
        private System.Windows.Forms.Label imie_txt;
        private System.Windows.Forms.Label badanie_txt;
        private System.Windows.Forms.TextBox inpt_badanie;
        private System.Windows.Forms.Label data_txt;
        private System.Windows.Forms.Button btn_zapisz;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label godzina;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label txt_dzis;
        private System.Windows.Forms.Label txt_godz;
        private System.Windows.Forms.Button wyswietl_btn;
        private System.Windows.Forms.TextBox wyswietl_txt;
        private System.Windows.Forms.Button usun_btn;
        private System.Windows.Forms.TextBox usun_txt;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
    }
}

