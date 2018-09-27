using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalizar = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese una expreción matemática.");
                var exprecion = Console.ReadLine();
            } while (!finalizar);
        }
    }
}
