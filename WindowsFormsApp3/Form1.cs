using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double en = Convert.ToDouble(textBox6.Text);
            double boy = Convert.ToDouble(textBox7.Text);
            double yukseklik = Convert.ToDouble(textBox8.Text);
            double agirlik = Convert.ToDouble(textBox9.Text);
            double mesafe = Convert.ToDouble(textBox10.Text);

            double ebataGoreFiyat = (en * boy * yukseklik * mesafe * 0.000005) + 9;
            double agirligaGoreFiyat = (agirlik * mesafe * 0.005) + 10;
            double tutar;

            if (ebataGoreFiyat > agirligaGoreFiyat)
            {
                tutar = ebataGoreFiyat;
            }
            else
            {
                tutar = agirligaGoreFiyat;
            }
            if (checkBox1.Checked)
            {
                tutar = tutar / 2;
            }

            label12.Text = tutar.ToString();

            if (mesafe >= 0 && mesafe <= 100)
            {
                MessageBox.Show("1 iş günü içerisinde siparişiniz teslim edilecektir." + textBox9.Text + "KG olan gönderinizin tutarı " + label12.Text + " TL'dir.");
            }
            if (mesafe >= 100 && mesafe <= 200)
            {
                MessageBox.Show("2 iş günü içerisinde siparişiniz teslim edilecektir." + textBox9.Text + "KG olan gönderinizin tutarı " + label12.Text + " TL'dir.");
            }
            if (mesafe >= 300 && mesafe >= 400)
            {
                MessageBox.Show("3 iş günü içerisinde siparişiniz teslim edilecektir." + textBox9.Text + "KG olan gönderinizin tutarı " + label12.Text + " TL'dir.");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gönderinizin ön kaydı alınmıştır.Adres Bilgisi: " + textBox11.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "İstanbul")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Maltepe");
                comboBox3.Items.Add("Küçükyalı");
                comboBox3.Items.Add("Kadıköy");
            }
            if (comboBox4.Text == "Ankara")
            {

                comboBox3.Items.Clear();
                comboBox3.Items.Add("Çankaya");
                comboBox3.Items.Add("Yenimahalle");
                comboBox3.Items.Add("Evren");
            }
            if (comboBox4.Text == "İzmir")
            {

                comboBox3.Items.Clear();
                comboBox3.Items.Add("Bornova");
                comboBox3.Items.Add("Foça");
                comboBox3.Items.Add("Karşıkaya");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " * " + comboBox3.Text + " * "+textBox2.Text);
            MessageBox.Show("Gönderi bilgileriniz e-mail adresinize gönderildi. En kısa sürede sizlerle iletişime geçeceğiz.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            //this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
