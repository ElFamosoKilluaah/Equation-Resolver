using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation_resolver {
    class Resolver {
        
        //Calculate the delta
        public static long delta(long a, long b, long c) {
            return (b * b) - 4 * a * c;
        }

        //Calculate root x1 (-)
        public static long x1(long a, long b, long delta) {
            return (-b - (long)Math.Sqrt(delta)) / (2 * a);
        }

        //Calculate root x1 (+)
        public static long x2(long a, long b, long delta) {
            return (-b + (long)Math.Sqrt(delta)) / (2 * a);
        }

        //Display the variation table
        public static void variationTable(long a, long delta) {
            if (delta < 0) {
                Boolean isANegative = a < 0;
                String symbol = isANegative ? "-" : "+";
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|x|-Infini |          |+Infini|");
                Console.WriteLine("| |             " + symbol + "             |");
                Console.WriteLine("-------------------------------");
            }

            else if (delta == 0) {
                Boolean isANegative = a < 0;
                String symbol = isANegative ? "-" : "+";
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|x|-Infini |   -b/2a  |+Infini|");
                Console.WriteLine("| |      " + symbol + "      0      " + symbol + "       |");
                Console.WriteLine("-------------------------------");
            }

            else if (delta > 0) {
                Boolean isANegative = a < 0;
                String symbol = isANegative ? "-" : "+";
                String opposedSymbol = isANegative ? "+" : "-";
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|x|-Infini|x1|    |x2|+Infini |");
                Console.WriteLine("| |" + symbol + "0     | 0| " + opposedSymbol + "  | 0|    " + symbol + "   |");
                Console.WriteLine("-------------------------------");
            }

        }

    }
}