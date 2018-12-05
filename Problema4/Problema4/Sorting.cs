using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Sorting
    {
        public int ObtainPivot(int[] Array, int left, int right) //Aquí es donde se acomodan los elementos, se toma el pivote y los
        {                                                                       //menores que este van a la izquierda y los mayores a la derecha
            int Pivot = Array[right]; //Se toma como pivote el último elemento del arreglo

            int smallest = (left - 1); //Indice del elemento mas pequeño
            for (int counter = left; counter < right; counter++) //Se hace el recorrido desde la izquierda hasta la derecha
            {
                if (Array[counter] <= Pivot) //Si el elemento de la izquierda es menor que el pivote o igual a este
                {
                    smallest++; //Se incrementa el indice

                    int temp1 = Array[smallest]; //Se guarda el elemento del arreglo con el indice "Pequeno"
                    Array[smallest] = Array[counter]; //Se hace el cambio de el valor, similar al arreglo de burbuja
                    Array[counter] = temp1; //Se regresa el valor guardado al arreglo
                }
            }

            int temp = Array[smallest + 1];  //Similar a lo anterior, se guarda un valor (esta vez de la derecha)
            Array[smallest + 1] = Array[right]; //Se hace el intercambio
            Array[right] = temp; //Se retorna el valor guardado

            return smallest + 1; //Retorna el indice incrementado en 1
        }

        public void QuickSort(ref int[] array, int left, int right) //Es donde se hace el método recursivo
        {
            if (left < right) //Si la Izquierda es menor que la derecha
            {
                //particion es el indice que se recibe de el metodo ObtenerPivote
                int particion = ObtainPivot(array, left, right);

                QuickSort(ref array, left, particion - 1); //Se hace la recursividad con la Derecha disminuida en 1
                QuickSort(ref array, particion + 1, right); //Se hace la recursividad con la izquierda aumentada, con esto se va recorriendo el arreglo
            }                                               //Mientras se va acomodando en el metodo ObtenerPivote
        }
    }
}
