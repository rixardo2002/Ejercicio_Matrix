using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class FactoriaMatrix
    {





        public static Matrix crearMatrix(int x, int y, Generico[] genericos, int num)
        {
            int numElementos = 0;
            Personaje[,] personajesMatrix = new Personaje[x, y]; // Por ejemplo, una matriz de 3x3

            Random random = new Random();

            Neo neo = FactoriaNeo.crearNeo();
            Smith smith = FactoriaSmith.crearSmith();

            Matrix matrix;

            int longrand;
            int latrand;

            int latNeo = random.Next(1, (x - 1));
            int longNeo = random.Next(1, (y - 1));
            

            neo.ubicacion = new Ubicacion { longitud = longNeo, latitud = latNeo };
            personajesMatrix[latNeo, longNeo] = neo;
            //Console.Write(neo);

            int latSmith = random.Next(0, (x));
            int longSmith = random.Next(0, (y));


            if (personajesMatrix[latSmith, longSmith] == null)
            {

                smith.ubicacion = new Ubicacion { latitud = latSmith, longitud = longSmith };
                personajesMatrix[latSmith, longSmith] = smith;
            }
            else
            {
                longSmith = random.Next(0, (x));
                latSmith = random.Next(0, (y));
                smith.ubicacion = new Ubicacion { latitud = latSmith, longitud = longSmith };
                personajesMatrix[latSmith, longSmith] = smith;
            }
            Console.WriteLine();

            //Console.Write(smith);
            Console.WriteLine();

            while (numElementos < num)
            {


                for (int i = 0; i < genericos.Length && numElementos < num; i++)
                {
                    do
                    {
                        longrand = random.Next(0, x);
                        latrand = random.Next(0, y);


                    } while (personajesMatrix[latrand, longrand] != null);
                    genericos[i].ubicacion.latitud = latrand;
                    genericos[i].ubicacion.longitud = longrand;
                    personajesMatrix[latrand, longrand] = genericos[i];
                    //Console.WriteLine(genericos[i]);
                    numElementos++;


                }
            }
            matrix = new Matrix(personajesMatrix);


            return matrix;
        }
    }
}

