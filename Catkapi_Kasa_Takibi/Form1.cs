using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catkapi_Kasa_Takibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam, kasa = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Masa Açıldı.");
            textBox6.Focus();
            label18.Text = "";
            label17.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            toplam = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

      
            int dondurma, cerez, cay, kahvaltı, oyemegi, tutar;

            dondurma = Convert.ToInt16(textBox1.Text);
            cerez = Convert.ToInt16(textBox2.Text); ;
            cay = Convert.ToInt16(textBox3.Text); ;
            kahvaltı = Convert.ToInt16(textBox4.Text); ;
            oyemegi = Convert.ToInt16(textBox5.Text); ;
            tutar = dondurma * 20 + cerez *25 + cay * 10 + kahvaltı *75 + oyemegi*100;
            toplam = toplam + tutar;
            kasa = kasa + toplam;

            label17.Text = tutar.ToString();
            label18.Text = toplam.ToString();
            label16.Text = kasa.ToString();

            listBox1.Items.Add(

                "Masa No:" + textBox6.Text + "  " +
                textBox1.Text + "  Adet Dondurma" +
               "  " + textBox2.Text + " Adet Çerez" +
               "  " + textBox3.Text + " Adet Çay" +
               "  " + textBox4.Text + " Adet Kahvaltı" +
               "  " + textBox5.Text + " Adet Ö.Yemeği" +
               "  " + "Son Hesap Tutarı: " + label18.Text
            ) ;

        }
    }
}
