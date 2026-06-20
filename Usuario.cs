using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUTP
{
    internal class Usuario
    {
   
        private int anio_nac;
        public int Panio
        {
            get { return anio_nac; }
            set { anio_nac = value; }
        }
        public Usuario( int anio_nac)
        {
     
            this.anio_nac = anio_nac;
        }

        public int CalcularEdad()
        {
            int anioActual = DateTime.Now.Year;
            return anioActual - anio_nac;
        }
    }
}
