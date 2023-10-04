using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class FactoriaGenerico
    {


        public static Generico crearGenerico()
        {

            string[] nombres = { "Inmaculada", "Agustin", "Antonio", "JoseMaria", "Vanesa", "Jaime", "Miguel", "Pablo", "Jose", "Ricardo", "Julian", "Ramon" };
            string[] ciudades = { "Madrid", "Valladolid", "Burgos", "Sevilla", "Lugo", "Asturias", "Valencia", "Murcia", "Leon", "Mallorca", "Tenerife", "Albacete" };



            //string nombre, string ciudad_nac, Ubicacion ubicacion, int edad, int numero, int prob_morir

            Generico generico = new Generico();
            Random rnd = new Random();

            int indiceN = rnd.Next(nombres.Length);
            String nombre = nombres[indiceN];

            int indiceC = rnd.Next(ciudades.Length);
            String ciudad = ciudades[indiceC];

            int prob_morir = rnd.Next(1, 101);
            Ubicacion ubicacion = new Ubicacion();

            int edad = rnd.Next(18, 76);


            generico = new Generico(nombre, ciudad, ubicacion, edad, prob_morir);
            //genericoArray[i].ToString();

            return generico;
        }



    }
}

