using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Personaje
    {
        public String nombre { get; set; }
        public String ciudad_nac { get; set; }
        public Ubicacion ubicacion { get; set; }
        public int edad { get; set; }
        public static int conteoPersonajes { get; }

        public Personaje()
        {

        }

        public Personaje(string nombre, string ciudad_nac, Ubicacion ubicacion, int edad)
        {
            this.nombre = nombre;
            this.ciudad_nac = ciudad_nac;
            this.ubicacion = ubicacion;
            this.edad = edad;
        }


        public override string ToString()
        {
            return $"Nombre: {nombre}, Ciudad de Nacimiento: {ciudad_nac}, Ubicación: {ubicacion}, Edad: {edad}";
        }


    }



}
