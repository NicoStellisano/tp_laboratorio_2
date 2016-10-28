using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12_Library;

namespace Clase_12_Library_2
{
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Yamaha, Chevrolet, Ford, Iveco, Scania, BMW
        }

        private EMarca _marca;
        private string _patente;
        private ConsoleColor _color;

        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public abstract short CantidadRuedas { get; set; }
        /// <summary>
        /// Crea el objeto Vehiculo (Constructor)
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Vehiculo(string patente ,EMarca marca ,ConsoleColor color)
        {
             this._color = color;
             this._patente = patente;
             this._marca = marca;
         }
        /// <summary>
        /// Muestra los datos del vehículo
        /// </summary>
        /// <returns></returns>
         public virtual string Mostrar()
         {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente);
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString());
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
         }

        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
         /// <param name="v1">Vehiculo1</param>
         /// <param name="v2">Vehiculo2</param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1._patente == v2._patente);
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1">Vehiculo1</param>
        /// <param name="v2">Vehiculo2</param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(Object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 1;
        }

      
    }
}
