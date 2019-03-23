using LanguageBasics.TypeBasics;
using LanguageBasics.TypeBasics.NumericTypes;
using LanguageBasics.TypeBasics.BooleanTypes;
using LanguageBasics.TypeBasics.StringANdCharacterTypes;
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
            // numericTypes();
            // ******************** Numeric Types****************** //

            // ******************** Boolean Types****************** //
            //Booleans.Example01();
            // ******************** Boolean Types****************** //

            // ******************** String/Character Types********* //
            //StringsAndCharacter.Example01();
            // ******************** String/Character Types********* //

        }                                                   // End of method

        private static void typeBasics()
        {
            Basics.Example01();
            Basics.Example02();
            Basics.Example03();
            Basics.Example04();
            Basics.Example05();
        }

        private static void numericTypes()
        {
            Numerics.Example01();
            Numerics.Example02();
            Numerics.Example03();
            Numerics.Example04();
            Numerics.Example05();
            Numerics.Example06();
        }

        static int MultiplyBy23(int number)
        {
            return number * 23;
        }

    }                                                       // End of class
}                       
