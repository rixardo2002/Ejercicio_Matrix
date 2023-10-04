using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Neo : Personaje
    {
        public bool elegido { get; set; }

        public Neo() { }

        public Neo(string nombre, string ciudad_nac, Ubicacion ubicacion, int edad, bool elegido)
        : base(nombre, ciudad_nac, ubicacion, edad)
        {
            this.elegido = elegido;
        }

       

        public override string ToString()
        {
            // Devuelve una cadena que representa el objeto Generico
            return $"Nombre: {nombre}, Ciudad de nacimiento: {ciudad_nac}, Edad: {edad}, Elegido: {elegido}, Ubicación: ({ubicacion.latitud}, {ubicacion.longitud})";
        }

    }
}
