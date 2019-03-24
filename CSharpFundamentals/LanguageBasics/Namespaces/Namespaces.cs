using System;
using System.Collections.Generic;
using System.Text;
using Outer.Middle.Inner;
using static System.Console;

namespace LanguageBasics.Namespaces
{
    class Nejmspejses
    {
        public static void Example01()
        {
            Console.WriteLine("**********Namespaces.Example01 BEGIN**********");

            // the using directive example
            Class3 c;    // Don't need fully qualified name

            // using static example
            WriteLine("Hello");

            Console.WriteLine("**********Namespaces.Example01 END*************");
        }
    }
}

namespace Outer
{
    class Class1 { }
    namespace Middle
    {
        class Class2 { }
        namespace Inner
        {
            class Class3 { }
        }
    }
}

namespace MyTradingCompany
{
    namespace Common
    {
        class ReportBase { }
    }
    namespace ManagementReporting
    {
        class SalesReport : Common.ReportBase { }
    }
}
