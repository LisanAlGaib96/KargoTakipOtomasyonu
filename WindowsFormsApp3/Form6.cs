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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add( textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text );
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox5.Text + " " + textBox6.Text + " " + textBox8.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
        }
    }
}
