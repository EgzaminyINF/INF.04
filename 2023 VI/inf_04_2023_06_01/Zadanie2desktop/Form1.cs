using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.pocztowka;
                label1.Text = "Cena: 1zł";
            }else if(radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.list;
                label1.Text = "Cena: 1,5zł";
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.paczka;
                label1.Text = "Cena: 10zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int test;
            bool ok = int.TryParse(textBox2.Text, out test);
            if (textBox2.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!ok)
            {
                MessageBox.Show("Kod pocztowy powinien składać się z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłko zostały wprowadzone");
            }
        }
    }
}
