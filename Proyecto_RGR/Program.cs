//VERSION DEFINITIVA
using Proyecto_RGR;
int X = 15;
int Y = 15;
int numGprincipales = 20;
int maxGenericos = 200;
int cont, cont1 = 0;

Generico[] arrayGenericos = new Generico[maxGenericos];
for (int i = 0; i < arrayGenericos.Length; i++)
{
    arrayGenericos[i] = FactoriaGenerico.crearGenerico();
    //Console.WriteLine(arrayGenericos[i]);
}

Matrix matrix = FactoriaMatrix.crearMatrix(X, Y, arrayGenericos, numGprincipales);


Console.WriteLine("-------------------------------------------MATRIX INICIAL-------------------------------------------\t");

Utilidades.mostrarPersonajes(matrix);

Console.WriteLine();

Console.WriteLine();

Console.WriteLine("-------------------------------------------EMPIEZA LOS 20 SEGUNDOS-------------------------------------------\t");
cont = numGprincipales;
for (int i = 1; i <= 20 && cont1 < 200; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine();
    Console.WriteLine("");
    Console.WriteLine("\t************************\t");
    Console.WriteLine("\t******SEGUNDO " + i+ " *******\t");
    Console.WriteLine("\t************************\t");
    Console.WriteLine("");
    Console.WriteLine("");
    
    
    if (i == 1)
    {
        
        cont1 = Utilidades.comprobarPorcentajesPersonajes(matrix, arrayGenericos, cont);
        
    }
    else
    {
        
        cont1 = Utilidades.comprobarPorcentajesPersonajes(matrix, arrayGenericos, cont1);
       
        
    }

    if (i >= 2 && i % 2 == 0)
    {

        Utilidades.movimientoSmith(matrix);
        
    }




    if (i >= 5 && i % 5 == 0)
    {
        

        cont1 = Utilidades.movimientoNeo(matrix, cont1, arrayGenericos,X,Y);

        
        
    }

    Utilidades.mostrarPersonajes(matrix);

}






