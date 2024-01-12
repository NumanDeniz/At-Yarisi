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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // text box a girilen değere göre form 2 deki label ve picture box ların görüntülenmesi ayarlama
            sayi = Convert.ToInt32(textBox1.Text);

            if (textBox1.Text == "2")
            {
                Form2 f2 = new Form2();
                f2.pictureBox3.Visible = false;
                f2.pictureBox4.Visible = false;
                f2.label3.Visible = false;
                f2.label4.Visible = false;
                f2.label5.Width = 51;
                f2.label5.Height = 251;
                f2.textBox1.Text = textBox1.Text;
                f2.ShowDialog();
                
            }
            else if (textBox1.Text == "3")
            {
                Form2 f2 = new Form2();
                f2.pictureBox4.Visible = false;
                f2.label4.Visible = false;
                f2.label5.Width = 51;
                f2.label5.Height = 351;
                f2.textBox1.Text = textBox1.Text;
                f2.ShowDialog();
            }
            else if (textBox1.Text == "4")
            {
                Form2 f2 = new Form2();
                f2.textBox1.Text = textBox1.Text;
                f2.ShowDialog();
            }
            else if (textBox1.Text == " ")
            {
                MessageBox.Show("Lütfen 2 ile 4 arası bir rakam giriniz");
            }
            else
            {
                MessageBox.Show("En az 2 en fazla 4 oyuncu seçilebilir");
            }
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);// sadece sayı girişi sağlanır.
            if ((int)e.KeyChar == 32)// boşluk girilmesini engeller(space)
            {
                e.Handled = true;
            }
        }
    }
    
}
