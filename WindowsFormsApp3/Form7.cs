using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgeleSayi = r.Next(0, 2000);
            textBox12.Text = rastgeleSayi.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(textBox14.Text);
            int agirlik = Convert.ToInt32(textBox15.Text);

            int hesap = adet * agirlik;

            textBox16.Text = hesap.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*int ab = 1500;
            int bc = 5500;
            int cd = 2500;

            int toplam = ab + Convert.ToInt32(textBox16.Text);
            int toplam2 = bc + Convert.ToInt32(textBox16.Text);
            int toplam3 = cd + Convert.ToInt32(textBox16.Text);

            if ((comboBox1.Text == "Yurtiçi Kampanyası") && (comboBox2.Text == "Normal Gönderim")) 
            {
                textBox19.Text = textBox16.Text + toplam;
            }

            else if ((comboBox1.Text =="Yurtdışı Kampanyası") && (comboBox2.Text == "Süper Hızlı Gönderim"))
            {
                textBox19.Text = textBox16.Text + (toplam3 + toplam2);
            }
            */
            int adet = Convert.ToInt32(textBox14.Text);
            int agirlik = Convert.ToInt32(textBox15.Text);

            int hesap = adet * agirlik;

            int ab = 150;
            int bc = 550;

            int cd = 300;

            int kdv = (hesap) * 18 / 100;

           

            if ((comboBox1.Text == "Yurtiçi Kampanyası") && (comboBox2.Text == "Normal Gönderim"))
            {
                int tfiyat = kdv + hesap;
                int i = (tfiyat + ab);
                textBox19.Text = i.ToString();


            }

            else if ((comboBox1.Text == "Yurtdışı Kampanyası") && (comboBox2.Text == "Süper Hızlı Gönderim"))
            {
                int tfiyat2 = kdv + hesap;
                int i = (tfiyat2 + bc);
                textBox19.Text = i.ToString();
            }

            else if ((comboBox1.Text == "Yurtiçi Kampanyası") && (comboBox2.Text == "Süper Hızlı Gönderim"))
            {
                int tfiyat3 = kdv + hesap;
                int i = (tfiyat3 + cd);
                textBox19.Text = i.ToString();
            }

            else if ((comboBox1.Text == "Yurtdışı Kampanyası") && (comboBox2.Text == "Normal Gönderim"))
            {
                int tfiyat4 = kdv + hesap;
                int i = (tfiyat4 + bc);
                textBox19.Text = i.ToString();
            }


            /*int tfiyat = kdv + hesap;

            textBox19.Text = tfiyat.ToString();
            */


        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gönderici adı:  " + textBox1.Text + "Alıcı Adı:  " + textBox7.Text + "Fatura No:  "+ textBox12.Text + "Ücret:  "+textBox19.Text );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }
    }
}
