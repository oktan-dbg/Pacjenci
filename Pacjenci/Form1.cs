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
        public Form1()
        {//
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
    }
}
