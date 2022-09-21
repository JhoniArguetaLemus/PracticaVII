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

namespace _Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //validación de textbox
        private void validacionTxt1(object sender, KeyPressEventArgs e)
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

        private void validacionTxt2(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txt1.Text != "" && txt2.Text != "")
            {

                Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


                if (cbSuma.Checked == true)
                {
                    txtResultado.Text = Suma(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();
                    cbSuma.Checked = false;
                }

                if (cbResta.Checked == true)
                {
                    txtResultado.Text = Restar(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();

                    cbResta.Checked = false;
                }

                if (cbDivision.Checked == true)
                {
                    txtResultado.Text = Dividir(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();

                    cbDivision.Checked = false;
                }

                if (cbMultiplicacion.Checked == true)
                {

                    txtResultado.Text = Multiplicar(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();

                    cbMultiplicacion.Checked = false;

                }

                cbMultiplicacion.Enabled = true;
                cbDivision.Enabled = true;
                cbResta.Enabled = true;
                cbSuma.Enabled = true;


            }
            else
            {
                MessageBox.Show("Al menos uno de los campos esta vacio");
            }



        }

        //funciones y metodos
        private double Suma(double num1, double num2) { return num1 + num2; }
        private double Restar(double num1, double num2) { return num1 - num2; }
        private double Multiplicar(double num1, double num2) { return num1 * num2; }
        private double Dividir(double num1, double num2) { return num1 / num2; }

        private void Limpiar()
        {
            txt1.Clear();
            txt2.Clear();
            txtResultado.Clear();
        }


        //permitir que solo un checbox este marcado 
        private void cbSuma_CheckedChanged(object sender, EventArgs e)
        {

            
            cbMultiplicacion.Enabled = false;
            cbDivision.Enabled = false;
            cbResta.Enabled = false;
        }

        private void cbResta_CheckedChanged(object sender, EventArgs e)
        {
            cbMultiplicacion.Enabled = false;
            cbDivision.Enabled = false;
            cbSuma.Enabled = false;
        }

        private void cbDivision_CheckedChanged(object sender, EventArgs e)
        {
            cbMultiplicacion.Enabled = false;
            cbSuma.Enabled = false;
            cbResta.Enabled = false;
        }

        private void cbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            cbSuma.Enabled = false;
            cbDivision.Enabled = false;
            cbResta.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       
    }
}
