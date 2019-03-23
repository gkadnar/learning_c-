using LanguageBasics.TypeBasics;
using LanguageBasics.NumericTypes;
using System;                                               // Importing namespace

namespace LanguageBasics                                    // Namespace declaration
{
    class MyFirstProgram                                    // Class declaration
    {
        static void Main(string[] args)                     // Method declaration
        {
            Console.WriteLine(MultiplyBy23(10));            // Statement 1
            Console.WriteLine(MultiplyBy23(23));            // Statement 2

            // ******************** TypeBasics ******************** //
            // typeBasics();
            // ******************** TypeBasics ******************** //

            // ******************** Numeric Types****************** //
            Numerics.Example01();
            Numerics.Example02();
            Numerics.Example03();
            Numerics.Example04();
            Numerics.Example05();
            Numerics.Example06();
            // ******************** Numeric Types****************** //

        }                                                   // End of method

        private static void typeBasics()
        {
            Basics.Example01();
            Basics.Example02();
            Basics.Example03();
            Basics.Example04();
            Basics.Example05();
        }

        static int MultiplyBy23(int number)
        {
            return number * 23;
        }

    }                                                       // End of class
}                       
