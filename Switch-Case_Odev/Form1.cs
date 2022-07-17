using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplama, cıkarma, carpma, bolme;
            string sembol = comboBox1.Text;
            
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplama = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
       
            switch (sembol)
            {
                case "+": textBox3.Text = Convert.ToString(toplama); break;
                case "-": textBox3.Text = Convert.ToString(cıkarma); break;
                case "*": textBox3.Text = Convert.ToString(carpma); break;
                case "/": textBox3.Text = Convert.ToString(bolme); break;
                default: textBox3.Text = "Hatalı İşlem Girildi"; break;

            }

        }
    }
}
