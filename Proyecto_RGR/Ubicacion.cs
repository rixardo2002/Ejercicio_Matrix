using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Ubicacion
    {


        public int latitud { get; set; }
        public int longitud { get; set; }
        
        public Ubicacion() { }

        public Ubicacion(int latitud,int longitud)
        {
            this.latitud = latitud;
            this.longitud = longitud;
            

        }
    }
}

