using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_LAB_II
{
    public class Calculadora
    {
        /// <summary>
        /// Metodo para la operacion entre numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Devuelve resultado de la operacion</returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            operador = validarOperador(operador);
            if (operador == "/" && numero2.getNumero() == 0)
                return 0;
            else if (operador == "/")
                return numero1 / numero2;
            else if (operador == "*")
                return numero1 * numero2;
            else if (operador == "+")
                return numero1 + numero2;
            else if (operador == "-")
                return numero1 - numero2;
            else
                return 0;          
        }
        /// <summary>
        /// Valida si el operador es valido
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Devuelve el operador</returns>
        public static string validarOperador(string operador)
        {
            if (operador != "/" && operador != "*" && operador != "+" && operador != "-")
                operador = "+";           
                return operador;           
        }

    }
}
