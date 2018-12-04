using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Datos
    {
        Queue<int> values = new Queue<int>(); //Cola que va almacenando los valores ingresados
        public void Entervalues()
        {
            int[] Array; //Arreglo que será enviado como parámetro
            
            bool continuee = true;
            while (continuee) //Mientras la condición sea verdadera
            {
                try
                {
                    Console.Clear();
                    Console.Write("Opciones disponibles: \n1.-Numeros Random y Ordenados por Radix \n2.- Salir \nOpción deseada: "); //Opciones disponibles
                    switch (Convert.ToInt16(Console.ReadLine()))
                    {
                        
                        case 1:
                            Random rdm = new Random();
                            for (int i = 0; i < 80; i++)
                            {
                                values.Enqueue(Convert.ToInt32(rdm.Next(1, 101))); //Recibe los numeros Random
                            }
                            Console.WriteLine("Numeros Random Desordenados");
                            foreach (var item in values)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Numeros Ordenados");
                            Array = new int[values.Count]; //Se inicializa el arreglo con la longitud de la cola
                            for (int counter = 0; counter < values.Count; counter++) //Aquí se llena el arreglo con los valores de la cola
                                Array[counter] = values.ElementAt(counter);
                            
                            Sorting Ordenar = new Sorting(); //Se hace la instanciación de la clase 
                            Ordenar.Ordenar(Array); //Se hace la llamada al método, se envia como parametro el arreglo
                            values.Clear(); //Se limpia la cola
                            Console.ReadKey();
                            break;
                       
                        case 2:
                            continuee = false;
                            Console.Write("<Enter para salir>"); //Si se indica la opción 3 se cierra el programa
                            break;
                        default: //De no ser una opción válida se despliega el mensaje y vuelve a iniciar
                            Console.Clear();
                            Console.WriteLine("Ingrese una opción válida");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); //Si hay un error, se lanza el mensaje de la excepción
                    Console.ReadKey();
                }
            }
        }
        
    }
}
