using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renklerin_Dili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mavi")
            {
                label4.Text = textBox1.Text +" "+ comboBox1.Text+" "+"Mutluluğun ve pozitifliğin rengidir .";
                renk.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "İyimserliğin rengidir .";
                renk.BackColor = Color.Yellow;

            }
            if (comboBox1.Text == "Yeşil")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "Doğanın, büyümenin, uyumun rengidir. ;) .";
                renk.BackColor = Color.Green;
            }
            if (comboBox1.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "Enerji vermekte, duyguları uyandırmakta ve harekete geçmemiz için bizi motive etmektedir .";
                renk.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "Asaletin Rengidir .";
                renk.BackColor = Color.Black;
            }
            if (comboBox1.Text == "Beyaz")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " " + "Saflığın Rengidir .";
                renk.BackColor = Color.White;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
