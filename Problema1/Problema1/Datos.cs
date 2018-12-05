using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Datos
    {
        public void AskValues()
        {
            
            int elements;
            int[] values;

            Console.Write("Número de elementos: ");
            elements = Convert.ToInt32(Console.ReadLine()); //Pide el número de elementos
            
                values = new int[elements]; //Inicializa el arreglo con los elementos indicados
                Console.Clear();
                Console.Write("Ingreso de datos: \n");

            for (int counter = 0; counter < elements; counter++)
            {
               

                while (counter < elements) // Simplemente se valida para que no te deje meter mas numeros que no sean 0,1,2 o letras

                {
                    Console.WriteLine("Elemento {0}: ", counter + 1);
                    string temp = Console.ReadLine();

                    int valor = 0;
                    if (!int.TryParse(temp, out valor))
                    {
                        Console.WriteLine("El valor no es numerico.");
                        continue;
                    }

                    List<int> opciones = new List<int>() { 0, 1, 2 };
                    if (!opciones.Contains(valor))
                    {
                        Console.WriteLine("No es un valor permitido.");
                        continue;
                    }

                    values[counter] = valor;
                    counter++;

                }

            }
            

                

                Bubble Order = new Bubble(); //Hace la instanciación a la clase Burbuja

                Order.BubbleSort(values); //Se llama al método de bulbasaur a través del objeto
            
           
        }
    }
}
