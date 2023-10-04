using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Generico : Personaje

    {
        
        public int prob_morir { get; set; }

        public Generico() { }


        public Generico(string nombre, string ciudad_nac, Ubicacion ubicacion, int edad, int prob_morir)
        : base(nombre, ciudad_nac, ubicacion,edad)
        {
            
            this.prob_morir = prob_morir;
        }
        public override string ToString()
        {
            // Devuelve una cadena que representa el objeto Generico
            return $"Nombre: {nombre}, Ciudad de nacimiento: {ciudad_nac}, Edad: {edad}, Probabilidad de morir: {prob_morir}, Ubicación: ({ubicacion.latitud}, {ubicacion.longitud})";
        }
    }
}
