using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace konversiNilai
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Int16.Parse(textBox1.Text) <= 100 && Int16.Parse(textBox1.Text) >= 91)
            {
                label4.Text = "Amat Baik";
            }
            else if (Int16.Parse(textBox1.Text) <= 90 && Int16.Parse(textBox1.Text) >= 81)
            {
                label4.Text = "Baik";
            }
            else if (Int16.Parse(textBox1.Text) <= 80 && Int16.Parse(textBox1.Text) >= 71)
            {
                label4.Text = "Cukup Baik";
            }
            else if (Int16.Parse(textBox1.Text) <= 70 && Int16.Parse(textBox1.Text) >= 61)
            {
                label4.Text = "Cukup";
            }
            else if (Int16.Parse(textBox1.Text) <= 60 && Int16.Parse(textBox1.Text) >= 0)
            {
                label4.Text = "Kurang";
            }
            else
            {
                label4.Text = "Nilai yang Anda Masukkan Salah";
            }
        }
    }
}
