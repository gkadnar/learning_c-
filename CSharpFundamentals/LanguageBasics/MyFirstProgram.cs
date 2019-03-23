using LanguageBasics.TypeBasics;
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
            Basics.Example01();
            Basics.Example02();
            Basics.Example03();
            Basics.Example04();
            // ******************** TypeBasics ******************** //
        }                                                   // End of method

        static int MultiplyBy23(int number)
        {
            return number * 23;
        }

    }                                                       // End of class
}                       
