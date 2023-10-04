using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class FactoriaSmith
    {
            public static Smith crearSmith()
            {
            Random random = new Random();

            Ubicacion ubicacion = new Ubicacion();
            int porcentaje = random.Next(1, 101);

            //string nombre, string ciudad_nac, Ubicacion ubicacion, int numero, int capac_inf

            Smith smith = new Smith("Smith","Ciudad Smith", ubicacion, 33, porcentaje);

                return smith;
            }
    }
   
}

