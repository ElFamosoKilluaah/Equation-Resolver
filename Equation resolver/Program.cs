using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Equation_resolver {

    class Program {

        static void Main(string[] args) {

            //Get all values of the 
            long a = U.doubleInput("Veuillez rentrer a: ");
            long b = U.doubleInput("Veuillez rentrer b: ");
            long c = U.doubleInput("Veuillez rentrer c: ");

            //Get the delta and solutions
            long delta = Resolver.delta(a, b, c);
            long x1 = Resolver.x1(a, b, delta);
            long x2 = Resolver.x2(a, b, delta);

            //Display all values
            Console.WriteLine("Delta = b²-4ac = " + delta);
            Console.WriteLine("x1 = (-b-sqrt(delta)) /2a = " + x1);
            Console.WriteLine("x2 = (-b+sqrt(delta)) /2a = " + x2);

            Console.WriteLine("*****");
            Console.WriteLine("\n\n");
            Resolver.variationTable(a, delta);
            Console.ReadKey();

        }
    }
}
