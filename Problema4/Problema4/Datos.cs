using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Datos
    {
        public void Ordenar()
        {
            int[] valores = new int[28] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 }; //Arreglos para las letras
            char[] letras = new char[28] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ',', '.', };
            string cadena = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est";
            List<char> ListaLetras = new List<char>(); //Aquí se guardarán las letras de la cadena
            int indice = 0;
            ListaLetras = cadena.ToCharArray().ToList(); //Se convierte la cadena a una lista de char
            int[] array = new int[ListaLetras.Count]; //Arreglo de valores para ordenar

            for (int contador = 0; contador < ListaLetras.Count; contador++)
            {

                if (ListaLetras.ElementAt(contador) == ' ')
                {
                    //Si es un espacio no hace nada
                }
                else
                {
                    indice = Buscar(ListaLetras.ElementAt(contador), letras.ToList()); //Obtiene el indice de la letra que se busca
                    array[contador] = valores[indice]; //Se obtiene el valor de la letra y se guarda en el arreglo
                }
            }

            Sorting Ordenamiento = new Sorting(); //Se hace la instanciación de la clase Sorting

            Ordenamiento.QuickSort(ref array, 0, array.Length - 1); //Se llama al método QuickSort para ordenar el arreglo

            for (int contador = 0; contador < array.Length; contador++) //Recorre todo el arreglo
            {
                if (array[contador] > 0)
                    Console.WriteLine(letras[array[contador] - 1] + ".- " + array[contador]); //Imprime las letras con su valor ordenadas
            }

            Console.ReadKey();
        }

        private int Buscar(char item, List<char> lista) //Recibe como parametro una variable de tipo char y una lista de tipo char
        {
            int contador = 0;
            int indice = 0;
            bool encontrado = false; //Variales auxiliares para el ciclo
            while (contador < lista.Count && encontrado == false) //Mientras sea menor que la cantidad de elementos de la lista y no se haya encontrado el elemento
            {
                if (Convert.ToString(lista.ElementAt(contador)) == item.ToString()) //Si el elemento actual de la lista es igual al buscado se termina el ciclo
                {
                    encontrado = true; //Con esto se sale del ciclo
                    indice = contador; //La variable indice guarda el indice del valor de la posición encontrada
                }
                else
                    contador++;
            }
            return indice; //Regresa el indice

        }
    }
}
