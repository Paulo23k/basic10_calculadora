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

namespace basic10_calculadora
{
    public partial class Form1 : Form
    {
        decimal num1 = 0, num2 = 0;
        string operador = "";
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "1";
        }

        private void txtB_calc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "0";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "6";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "8";
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            if (txtB_calc.Text != "")
            {
                num1 = decimal.Parse(txtB_calc.Text, CultureInfo.InvariantCulture);
                txtB_calc.Text = "";
                operador = "soma";
                label_operacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Digite um número");
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(txtB_calc.Text, CultureInfo.InvariantCulture);
            if (operador == "soma")
            {
                txtB_calc.Text = Convert.ToString(num1 + num2);
            }
            else if (operador == "subtracao")
            {
                txtB_calc.Text = Convert.ToString(num1 - num2);
            }
            else if (operador == "multiplicacao")
            {
                txtB_calc.Text = Convert.ToString(num1 * num2);
            }
            else if (operador == "divisao")
            {
                txtB_calc.Text = Convert.ToString(num1 / num2);
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtB_calc.Text += "9";
        }
    }
}
