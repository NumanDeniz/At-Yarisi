using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarişi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int at1, at2, at3, at4,sayi;
        Form1 fm1 = new Form1();
        Random rand = new Random();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            at1 = pictureBox1.Left;
            at2 = pictureBox2.Left;
            at3 = pictureBox3.Left;
            at4 = pictureBox4.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int at1genişlik = pictureBox1.Width;
            int at2genişlik = pictureBox2.Width;
            int at3genişlik = pictureBox3.Width;
            int at4genişlik = pictureBox4.Width;

            if (at1genişlik + at1 >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numanralı Oyuncu Kazanmıştır...");
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (at2genişlik + at2 >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numanralı Oyuncu Kazanmıştır...");
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (at3genişlik + at3 >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numanralı Oyuncu Kazanmıştır...");
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (at4genişlik + at4 >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("4 Numanralı Oyuncu Kazanmıştır...");
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //oyuncu 2
            if (sayi == 2)
            {
                button3.Enabled = true;
                button4.Enabled = false;
            }
            button5.Enabled = true;
            
            pictureBox2.Left = pictureBox2.Left + rand.Next(15, 25);
            
            
            at2 = pictureBox2.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // oyuncu 3
            if (sayi == 3)
            {
                button3.Enabled = true;
                button4.Enabled = false;
            }
            pictureBox3.Left = pictureBox3.Left + rand.Next(15, 25);
            button5.Enabled = false;
            button6.Enabled = true;
            at3 = pictureBox3.Left;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //oyuncu 4
            if (sayi == 4)
            {
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
            }
            pictureBox4.Left = pictureBox4.Left + rand.Next(15, 25);
            button6.Enabled = false;
        

            at4 = pictureBox4.Left;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            pictureBox4.Left = 0;

            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sayi = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "2") {

                button3.Visible = true;
                button3.Enabled = true;
                button4.Visible = true;
                button4.Enabled = false;
                button5.Visible = false;
                button6.Visible = false;
                button3.Enabled = true;
                button1.Enabled = false;
                timer1.Enabled = true;
            }
            else if (textBox1.Text == "3")
            {
                button3.Visible = true;
                button3.Enabled = true;
                button4.Visible = true;
                button4.Enabled = false;
                button5.Visible = true;
                button5.Enabled = false;
                button6.Visible = false;

                timer1.Enabled = true;
            }
            else if(textBox1.Text == "4")
            {
                button3.Visible = true;
                button3.Enabled = true;
                button4.Visible = true;
                button4.Enabled = false;
                button5.Visible = true;
                button5.Enabled = false;
                button6.Visible = true;
                button6.Enabled = false;
                button1.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // oyuncu 1
            pictureBox1.Left = pictureBox1.Left + rand.Next(15, 25);
            button3.Enabled = false;
            button4.Enabled = true;
            at1 = pictureBox1.Left;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
