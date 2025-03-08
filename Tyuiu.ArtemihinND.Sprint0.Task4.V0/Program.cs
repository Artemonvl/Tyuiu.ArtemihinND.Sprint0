using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ArtemihinND.Sprint0.Task4.V0.Lib;
namespace Tyuiu.ArtemihinND.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));

            Console.WriteLine(DataService.Subtraction(6, 1));

            Console.WriteLine(DataService.Multiplication(16, 5));

            Console.WriteLine(DataService.Division(63, 9));

            Console.ReadKey();

        }
    }
}
