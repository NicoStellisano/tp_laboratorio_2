using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public delegate void Descargando(int Progreso);
    public delegate void Descargado(string html);
    public class Descargador
    {
        private string html;
        private Uri direccion;

        public Descargador(Uri direccion)
        {
            
            this.direccion = direccion;
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient web = new WebClient();
                web.DownloadProgressChanged += this.WebClientDownloadProgressChanged;
                web.DownloadStringCompleted += this.WebClientDownloadCompleted;

                web.DownloadStringAsync(this.direccion);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public event Descargando downloading;
        public event Descargado terminado;

        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.downloading(e.ProgressPercentage);
        }
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            this.terminado(e.Result);
        }
    }
}
