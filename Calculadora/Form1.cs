using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {




       

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";

        }

        //funciones y metodo
        private Double Suma(double num1, double num2)
        { return num1 + num2; }

        private Double Multiplicar(double num1, double num2)
        { return num1 * num2; }

        private Double Dividir(double num1, double num2)
        { return num1 / num2; }

        private Double Restar(double num1, double num2)
        { return num1 - num2; }

        

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            txtResultado.Text = Multiplicar(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();

        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            txtResultado.Text=Suma(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            txtResultado.Text = Restar(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            txtResultado.Text = Dividir(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
        }


        //permitir solo entrada de números
        private void textBox1Validacion(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números");
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2Validacion(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números");
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            txtResultado.Clear();
        }

    }
}
