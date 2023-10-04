using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class FactoriaNeo
    {

       public static Neo crearNeo() {
            Random rnd = new Random();
            Ubicacion ubicacion = new Ubicacion();
            bool elegido;
            int num= rnd.Next(1,3);   
            

            if (num == 1)
            {
                elegido=true;

            }else elegido=false;    

            //(string nombre, string ciudad_nac, Ubicacion ubicacion, int edad, bool elegido)
            Neo neo = new Neo("Neo","Ciudad Neo",ubicacion,32,elegido);
            return neo;
        }


    }
}
