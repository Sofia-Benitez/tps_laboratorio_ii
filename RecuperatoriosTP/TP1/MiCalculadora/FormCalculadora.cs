using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add(" ");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            cmbOperador.Text = " ";
            lblResultado.Text = " ";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            //llama al metodo Operar de la calculadora y devuelve el resultado en double
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char operadorChar = Convert.ToChar(operador);

            double resultado = Calculadora.Operar(operando1, operando2, operadorChar);

            return resultado;
        }

       

        //BOTONES
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string numero1 = txtNumero1.Text;
            string numero2 = txtNumero2.Text;
            string operador = cmbOperador.Text;

            resultado = Operar(numero1, numero2, operador);

            lblResultado.Text = resultado.ToString();

            if (resultado==double.MinValue)
            {
                MessageBox.Show("Error. No es posible dividir por 0");
            }
            else
            {
                if (operador == " ")
                {
                    operador = "+";
                }
                lstOperaciones.Items.Add($"{numero1}{operador}{numero2}={resultado.ToString()}");
            }

        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            
            string binarioAConvertir = lblResultado.Text;
            string decimalConvertido = Operando.BinarioDecimal(binarioAConvertir);
            
            if (decimalConvertido != "Valor invalido")
            {
                lblResultado.Text = decimalConvertido;
                lstOperaciones.Items.Add($"{binarioAConvertir}->{decimalConvertido}");
            }
            else
            {
                MessageBox.Show("Error. Valor inválido");
            }
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string decimalAConvertir = lblResultado.Text;
            string binarioConvertido = Operando.DecimalBinario(decimalAConvertir);
            
            if(binarioConvertido != "Valor invalido")
            {
                lblResultado.Text = binarioConvertido;
                lstOperaciones.Items.Add($"{decimalAConvertir}->{binarioConvertido}");
            }
            else
            {
                MessageBox.Show("Error. Valor inválido");
            }

        }

        
    }
}
