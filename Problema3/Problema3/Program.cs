using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShellSort SS = new ShellSort(); //SE instancia el objeto
            SS.Cargar();//Se mandan a llamar a los metodos
            SS.Shell();
            SS.Imprimir();
        }

    }
}
