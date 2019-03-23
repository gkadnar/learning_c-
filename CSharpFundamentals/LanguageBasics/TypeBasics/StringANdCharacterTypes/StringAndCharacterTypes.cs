using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.TypeBasics.StringANdCharacterTypes
{
    class StringsAndCharacter
    {
        public static void Example01()
        {
            Console.WriteLine("**********StringAndCharater.Example01 BEGIN**********");

            char c = 'A';                   // Simple character
            char newLine = '\n';            // new line defined using escape character
            char backSlash = '\\';          // bacslash literal

            // character literals initialized as Unicode 
            char copyrightSymbol2 = '\u00A9';
            char omegaSymbol2 = '\u03A9';
            char newLine2 = '\u000A';

            string a = "Heat";              // string type initialization

            // string types are reference types, but still becose of immutability, equality operator follows value-type semantics
            string a3 = "test";
            string b3 = "test";
            Console.WriteLine(a3 == b3);  // True

            // string with char literals
            string a4 = "Here's a tab:\t";
            Console.WriteLine($"String with char literal: {a4}.");

            //example of how to avoid escaping 
            string a5 = "\\\\server\\fileshare\\helloworld.cs";
            string a6 = @"\\server\fileshare\helloworld.cs";
            Console.WriteLine($"Explicit escaping: {a5}.");
            Console.WriteLine($"Escaping with verbatim: {a6}.");

            //inneficient string contatenation
            // that $ before actual string marks it as interpolated string
            string s = a3 + a4 + a5 + a6;
            Console.WriteLine($"String concatenation: {s}");

            Console.WriteLine("**********StringAndCharater.Example01 END*************");
        }
    }
}
