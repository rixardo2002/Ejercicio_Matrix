using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_RGR
{
    internal class Utilidades
    {
        public static void mostrarPersonajes(Matrix matrix)
        {
            for (int i = 0; i < matrix.personajesMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.personajesMatrix.GetLength(1); j++)
                {
                    if (matrix.personajesMatrix[i, j] == null)
                    {
                        Console.Write(" [ ] ");

                    }
                    else
                    {
                        if (matrix.personajesMatrix[i, j] is Neo)
                        {
                            Console.Write(" [N] ");
                        }
                        else if (matrix.personajesMatrix[i, j] is Smith)
                        {
                            Console.Write(" [S] ");
                        }
                        else Console.Write(" [G] ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static int comprobarPorcentajesPersonajes(Matrix matrix, Generico[] genericos, int comienzo)
        {
            Random random = new Random();
            int cont = comienzo;
            int latG = 0;
            int longG = 0;
            for (int i = 0; i < matrix.personajesMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.personajesMatrix.GetLength(1); j++)
                {
                    if (matrix.personajesMatrix[i, j] is Generico)
                    {
                        Generico generico = (Generico)matrix.personajesMatrix[i, j];
                        //Console.WriteLine(generico);
                        if (generico.prob_morir > 70)
                        {
                            matrix.personajesMatrix[i, j] = null;
                            if (cont < 200)
                            {

                                do
                                {
                                    latG = random.Next(0, 15);
                                    longG = random.Next(0, 15);
                                    //Console.WriteLine(latG);
                                    // Console.WriteLine(longG);
                                } while (matrix.personajesMatrix[latG, longG] != null);

                                genericos[cont].ubicacion.latitud = latG;
                                genericos[cont].ubicacion.longitud = longG;
                                generico = genericos[cont];
                                //Console.WriteLine(generico);
                                cont++;

                                matrix.personajesMatrix[latG, longG] = generico;
                            }
                        }
                        else
                        {
                            generico.prob_morir = generico.prob_morir + 10;
                            //Console.WriteLine(generico.prob_morir);
                            //Console.WriteLine(generico);

                            matrix.personajesMatrix[i, j] = generico;

                        }
                    }
                }
            }

            return cont;
        }

        public static void movimientoSmith(Matrix matrix)
        {
            int filaD = 0, columnaD = 0;
            int filaS = 0, columnaS = 0;

            for (int i = 0; i < matrix.personajesMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.personajesMatrix.GetLength(1); j++)
                {
                    if (matrix.personajesMatrix[i, j] is Neo)
                    {
                        
                        filaD = i;
                        columnaD = j;
                    }
                    if (matrix.personajesMatrix[i, j] is Smith)
                    {
                       
                        filaS = i;
                        columnaS = j;
                    }


                }
            }
            
            Smith smith = (Smith)matrix.personajesMatrix[filaS, columnaS];

            //Una vez obtenidas las posiciones de neo y smith
            int distancia = (Math.Max(Math.Abs(filaD - filaS), Math.Abs(columnaD - columnaS))) - 1;
            if (distancia>0)
            {
            matrix.personajesMatrix[filaS,columnaS] = null;
            }
           //Console.WriteLine(distancia);
            for (int m = 0; m < distancia; m++)
            {
                if (filaD > filaS)
                {
                    filaS++;
                }
                else
                {
                    filaS--;

                }

                if (columnaD > columnaS)
                {
                    columnaS++;
                }
                else
                {

                    columnaS--;
                }

                if (matrix.personajesMatrix[filaS,columnaS] is Generico)
                {
                    matrix.personajesMatrix[filaS, columnaS] = null;
                }
            }
           
            smith.ubicacion.latitud = filaS;
            smith.ubicacion.longitud = columnaS;

            matrix.personajesMatrix[filaS, columnaS] = smith;

        }



        public static int movimientoNeo(Matrix matrix, int comienzo, Generico[] genericos,int altura,int anchura)
        {
            bool salir = false;

            int cont = comienzo;
            Random random = new Random();
            //Personaje[,] matrizAyacentes = new Personaje[3, 3];
            int latN = 0, longN = 0;

            for (int i = 0; i < matrix.personajesMatrix.GetLength(0) && !salir; i++)
            {
                for (int j = 0; j < matrix.personajesMatrix.GetLength(1) && !salir; j++)
                {
                    if (matrix.personajesMatrix[i, j] is Neo)
                    {
                        latN = i;
                        longN = j;
                        salir = true;

                    }

                }
            }

            Neo neo = (Neo)matrix.personajesMatrix[latN, longN];
            
            int numeroEleg = random.Next(1, 3);
            if (numeroEleg==1)
            {
                neo.elegido = true;
            }
            else
            {
                neo.elegido = false;
            }
            
            //Console.WriteLine(neo);
            int x = neo.ubicacion.latitud;
            int y = neo.ubicacion.longitud;


            if (neo.elegido)
            {


                for (int h = x - 1; h <= x + 1; h++)
                {
                    for (int z = y - 1; z <= y + 1; z++)
                    {

                        if (matrix.personajesMatrix[h, z] == null && cont < 200)
                        {
                            Generico generico = genericos[cont];
                            generico.ubicacion.latitud = h;
                            generico.ubicacion.longitud = z;
                            matrix.personajesMatrix[h, z] = generico;
                            cont++;
                        }
                    }
                }
            }

            int nuevaX = random.Next(1, (altura-1));
            int nuevaY = random.Next(1, (anchura-1));

            if (matrix.personajesMatrix[nuevaX, nuevaY] == null)
            {
                
                matrix.personajesMatrix[x, y] = null;
                neo.ubicacion.latitud = nuevaX;
                neo.ubicacion.longitud = nuevaY;
                matrix.personajesMatrix[nuevaX, nuevaY] = neo;

            }
            if (matrix.personajesMatrix[nuevaX, nuevaY] is Smith)
            {
                matrix.personajesMatrix[x, y] = null;
                Smith smith = (Smith)matrix.personajesMatrix[nuevaX, nuevaY];
                smith.ubicacion.latitud = x;
                smith.ubicacion.longitud = y;
                matrix.personajesMatrix[x, y] = smith;

                neo.ubicacion.latitud = nuevaX;
                neo.ubicacion.longitud = nuevaY;
                matrix.personajesMatrix[nuevaX, nuevaY] = neo;

            }
            if (matrix.personajesMatrix[nuevaX, nuevaY] is Generico)
            {
                matrix.personajesMatrix[x, y] = null;
                Generico generico = (Generico)matrix.personajesMatrix[nuevaX, nuevaY];

                generico.ubicacion.latitud = x;
                generico.ubicacion.longitud = y;
                matrix.personajesMatrix[x, y] = generico;

                neo.ubicacion.latitud = nuevaX;
                neo.ubicacion.longitud = nuevaY;
                matrix.personajesMatrix[nuevaX, nuevaY] = neo;

            }
            //Console.WriteLine(neo);
            
            return cont;
        }

        
    }
}
