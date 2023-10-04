using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Matrix
    {
        public Personaje[,] personajesMatrix { get; set; }

        public Matrix()
        {

        }
        public Matrix(Personaje[,] personajesMatrix)
        {
            this.personajesMatrix = personajesMatrix;
        }




    }
}
