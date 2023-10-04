using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Smith: Personaje
    {
        
        public int capac_inf { get; set; }


        public Smith() { }

        public Smith(string nombre, string ciudad_nac, Ubicacion ubicacion, int edad, int capac_inf)
        : base(nombre, ciudad_nac, ubicacion,edad)
        {
            
            this.capac_inf = capac_inf;
        }

        public override string ToString()
        {
            // Devuelve una cadena que representa el objeto Generico
            return $"Nombre: {nombre}, Ciudad de nacimiento: {ciudad_nac}, Edad: {edad}, Cap_infeccion: {capac_inf}, Ubicación: ({ubicacion.latitud}, {ubicacion.longitud})";
        }

    }

}
