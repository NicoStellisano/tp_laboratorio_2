using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string _ruta;
        public Texto(string archivo)
        {
            this._ruta = archivo;
        }

        public bool guardar(string datos)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(this._ruta, true)) 
                {
                    escritor.WriteLine(datos);
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
            return true;
        }
        

        public bool leer(out List<string> datos)
        {
            datos = new List<string>();
            try
            {
                using (StreamReader lector = new StreamReader(this._ruta))
                {
                    while (lector.EndOfStream == false) 
                    {
                        datos.Add(lector.ReadLine());
                    }
                }
            }
            catch (Exception)
            {
                
            }
            return true;
        }
    }
}
