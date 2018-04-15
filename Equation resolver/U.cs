using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation_resolver {

    class U {

        //All inputs methods
        public static String stringInput(String text) {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int intInput(String text) {
            return Convert.ToInt32(stringInput(text));
        }

        public static long doubleInput(String text) {
            return Convert.ToInt64(stringInput(text));
        }


    }
}
