using LanguageBasics.TypeBasics;
using LanguageBasics.TypeBasics.NumericTypes;
using LanguageBasics.TypeBasics.BooleanTypes;
using LanguageBasics.TypeBasics.StringANdCharacterTypes;
using LanguageBasics.VariablesAndParameters;
using LanguageBasics.ExpressionsAndOperators;
using LanguageBasics.Statements;
using LanguageBasics.Namespaces;

using LanguageBasics.ArrayBasics;

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

            // ******************** Arrays************************* //
            //Arrays.Example01();
            //Arrays.Example02();
            // ******************** Arrays************************* //

            // ******************** Vars and Params**************** //
            //VarsAndPArams.Example01();
            //VarsAndPArams.Example02();
            // ******************** Vars and Params**************** //

            // ******************** Expessions and Operators******* //
            //ExprsAndOpss.Example01();
            // ******************** Expessions and Operators******* //

            // ******************** Statements******************** //
            // Stejtments.Example01();
            // Stejtments.Example02();
            // Stejtments.Example03();
            // Stejtments.Example04();
            // ******************** Statements******************** //

            // ******************** Namespaces******************** //
            Nejmspejses.Example01();
            // ******************** Namespaces******************** //

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
