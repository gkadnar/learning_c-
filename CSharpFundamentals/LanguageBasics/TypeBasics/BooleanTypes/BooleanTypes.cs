using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.TypeBasics.BooleanTypes
{
    class Booleans
    {
        public static void Example01()
        {
            Console.WriteLine("**********BooleanTypes.Example01 BEGIN**********");

            // using equality operators on numeric primitives produce boolean results
            int x = 1;
            int y = 2;
            int z = 1;
            Console.WriteLine(x == y);         // False
            Console.WriteLine(x == z);         // True

            // using equality operator on reference values
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2);       // False
            Dude d3 = d1;
            Console.WriteLine(d1 == d3);       // True

            Console.WriteLine($"Short-circut evaluation operators {useUmbrella(true,true,true)}");
            Console.WriteLine($"Example of ternary conditional operator {max(5,23)}");

            Console.WriteLine("**********BooleanTypes.Example01 END*************");
        }

        private static bool useUmbrella(bool rainy, bool sunny, bool windy)
        {
            return !windy && (rainy || sunny);
        }

        private static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }



    class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }
}
