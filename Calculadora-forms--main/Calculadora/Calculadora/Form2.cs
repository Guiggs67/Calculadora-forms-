using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {
        double valor, valor_2 = 0;
        int operacao;
        double resul;
        double op = 0;
        int cont = 0;

        public List<int> Mlista = new List<int>();
    



        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = 2;
            cont++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = 1;
            op += valor;
            cont++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = 4;
            op += valor;
            cont++;

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            valor = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            operacao = 3;
            op += valor;
            cont++;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor_2 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == 1)
            {
                resul = op + valor_2;
            }
            if (operacao == 2)
            {
                resul = op - valor_2;
            }
            if (operacao == 3)
            {
                resul = op * valor_2;
            }
            if (operacao == 4)
            {
                resul = op / valor_2;
            }

            textBox1.Text = resul.ToString();

            op = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double media = op / cont;
            textBox1.Text = media.ToString();

        }



    }
}
