using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_LAB_II
{
    public class Numero
    {
        private double _numero;
        private double _aux;

        public double getNumero()
        {
            return this._numero;
        }
        /// <summary>
        /// Se inicializa en 0 el numero
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }
        /// <summary>
        /// Se pasa como parametro un strng y se convierte a double para operar
        /// </summary>
        /// <param name="num">Palabra a parsear</param>
        public Numero(string num)
        {
            if (double.TryParse(num, out _aux))
                setNumero(num);         
        }
        /// <summary>
        /// Se pasa el double a operar
        /// </summary>
        /// <param name="nume">Double a operar</param>
        public Numero(double nume)
        {
            this._numero = nume;
        }
        /// <summary>
        /// Llama a la validacion y asigna el numero
        /// </summary>
        /// <param name="numero"></param>
        private void setNumero(string numero)
        {
            this._numero = validarNumero(numero);
            
        }
        /// <summary>
        /// Intenta parsear de string a double
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private double validarNumero(string numeroString)
        {
            if (double.TryParse(numeroString, out _aux))
                return _aux;          
                return 0;
        }

        public static double operator +(Numero n1, Numero n2)
         {
             return n1._numero + n2.getNumero();
            
         }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2.getNumero();
         
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2.getNumero();
           
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2.getNumero();
            
        }


    }
}
