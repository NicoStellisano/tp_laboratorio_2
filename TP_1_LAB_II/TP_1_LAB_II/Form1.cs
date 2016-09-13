using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1_LAB_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Boton para poner en 0 los txtBox y lbl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "0";
            this.txtNumero2.Text = "0";
            this.lblResultado.Text = "0";
        }
        /// <summary>
        /// Boton para operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(this.txtNumero1.Text);
            Numero num2 = new Numero(this.txtNumero2.Text);
            Calculadora calc = new Calculadora();
            string operador;
        
            operador = this.cmbOperacion.Text;
            this.lblResultado.Text = Calculadora.operar(num1, num2, operador).ToString();
            

        }
    }
}
