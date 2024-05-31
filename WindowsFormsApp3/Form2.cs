using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
                MessageBox.Show("Bu fatura numarası sistemde bulunmaktadır. Lütfen gönderi durumunuzu sorgulamak adına diğer alanları doldurunuz.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "12345678910")
            {
                if (comboBox2.Text == "10987654321")
                {
                    textBox5.Text="Kargonuz transfer aşamasındadır.";
                }
            }
            if (comboBox1.Text == "12345678910")
            {
                if (comboBox2.Text == "10987654321")
                {
                    textBox5.Text="Kargonuz dağıtım merkezindedir.";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşleminiz başarılı.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            //this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*Form3 frm3 = new Form3();
            frm3.Show();*/
           
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
