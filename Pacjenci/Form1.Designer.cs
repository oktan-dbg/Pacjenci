
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
            this.inpt_imie = new System.Windows.Forms.TextBox();
            this.imie_txt = new System.Windows.Forms.Label();
            this.badanie_txt = new System.Windows.Forms.Label();
            this.inpt_badanie = new System.Windows.Forms.TextBox();
            this.data_txt = new System.Windows.Forms.Label();
            this.btn_zapisz = new System.Windows.Forms.Button();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
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
            this.inpt_badanie.Location = new System.Drawing.Point(308, 25);
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
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(464, 25);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(266, 27);
            this.dtp_data.TabIndex = 7;
            this.dtp_data.ValueChanged += new System.EventHandler(this.dtp_data_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

