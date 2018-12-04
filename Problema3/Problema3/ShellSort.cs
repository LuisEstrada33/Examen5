using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class ShellSort
    {
        private int[] vector;

        public void Cargar()//Metodo en que se perdira la longitud del arreglo
        {
            
            Console.WriteLine("Shell Sort");
            Console.Write("Tamaño sera el arreglo: ");//Aqui se pide el tama
            int n = int.Parse(Console.ReadLine());
            vector = new int[n];
            for (int f = 0; f < vector.Length; f++) // Ciclo para ingresar los elementos del arreglo
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");

                vector[f] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Shell() //Metodo en el que se hara la comparacion de los elementos del arreglo para acomodarlos
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = vector.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector.Length - salto))
                    {
                        if (vector[e - 1] < vector[(e - 1) + salto])
                        {
                            auxi = vector[(e - 1) + salto];
                            vector[(e - 1) + salto] = vector[e - 1];
                            vector[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++
                            
                            ;
                    }
                }
                salto = salto / 2;
            }
        }
        public void Imprimir() //Metodo para imprimir los elementos del arreglo
        {
            Console.WriteLine("Vector ordenados en forma decendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
            Console.ReadKey();
        }


    }
}
