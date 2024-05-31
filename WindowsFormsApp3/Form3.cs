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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="busranur"&&textBox2.Text=="1234")
            {
                MessageBox.Show("Giriş başarılı.");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                //this.Close();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }
    }
}
