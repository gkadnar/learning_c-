using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingTypes.Inheritance
{
    class InheritanceExamples
    {
        public static void Example01()
        {
            basicInheritance();
            basicUpcasting();
            basicDowncasting();
            basicAsAndIsOperators();
            basicVirtualFunctions();
            basicAbstractClassesAndMembers();
            basicHidingInheritedMembers();
        }

        private static void basicInheritance()
        {
            Console.WriteLine("basicInheritance");
            // basic inheritance examples
            Stock msft = new Stock
            {
                Name = "MSFT",
                SharesOwned = 1000
            };
            Console.WriteLine(msft.Name);           // MSFT
            Console.WriteLine(msft.SharesOwned);    // 1000
            House mansion = new House
            {
                Name = "Mansion",
                Mortgage = 250000
            };
            Console.WriteLine(mansion.Name);        // Mansion
            Console.WriteLine(mansion.Mortgage);    // 250000

            Subclass sc = new Subclass();
        }
        private static void basicUpcasting()
        {
            Console.WriteLine("basicUpcasting");
            // upcasting
            Stock msft = new Stock();
            Asset a = msft;                         // Upcast
            Console.WriteLine(a == msft);           // True
            Console.WriteLine(a.Name);              // OK
            //Console.WriteLine(a.SharesOwned);     // Error: SharesOwned undefined
        }
        private static void basicDowncasting()
        {
            Console.WriteLine("basicDowncasting");
            // downcasting
            Stock msft = new Stock();
            Asset a = msft;                         // Upcast
            Stock s = (Stock)a;                     // Downcast
            Console.WriteLine(s.SharesOwned);       // <No error>
            Console.WriteLine(s == a);              // True
            Console.WriteLine(s == msft);           // True
        }
        private static void basicAsAndIsOperators()
        {
            Console.WriteLine("basicAsOperator");
            
            // as operator
            Asset a = new Asset();
            Stock s = a as Stock;                  // s is null; no exception thrown
            Console.WriteLine(s);

            // is operator
            if (a is Stock)
                Console.WriteLine(((Stock)a).SharesOwned);
            if (a is Stock ss)
                Console.WriteLine(ss.SharesOwned);

            if (a is Stock sss && sss.SharesOwned > 100000)
                Console.WriteLine("Wealthy");
            else
                sss = new Stock();                  // s is in scope

            Console.WriteLine(sss.SharesOwned);     // Still in scope
        }
        private static void basicVirtualFunctions()
        {
            Console.WriteLine("basicVirtualFunctions");

            House mansion = new House { Name = "McMansion", Mortgage = 250000 };
            Asset a = mansion;
            Console.WriteLine(mansion.Liability);  // 250000
            Console.WriteLine(a.Liability);        // 250000
        }
        private static void basicAbstractClassesAndMembers()
        {
            Console.WriteLine("basicAbstractClassesAndMembers");
            StockFromAbstract sfa = new StockFromAbstract() { SharesOwned = 1, CurrentPrice=666 };
            Console.WriteLine(sfa.NetValue);
        }
        private static void basicHidingInheritedMembers()
        {
            Console.WriteLine("basicAbstractClassesAndMembers");
            A a = new A();
            B b = new B();
            Console.WriteLine(a.Counter);
            Console.WriteLine(b.Counter);
            A a2 = (B)b;
            Console.WriteLine(a2.Counter);

            Overrider over = new Overrider();
            BaseClass b1 = over;
            over.Foo();                         // Overrider.Foo
            b1.Foo();                           // Overrider.Foo

            Hider h = new Hider();
            BaseClass b2 = h;
            h.Foo();                           // Hider.Foo
            b2.Foo();                          // BaseClass.Foo
        }
    }

    public class Asset
    {
        public string Name;
        public virtual decimal Liability => 0;      // Expression-bodied property
    }

    public class Stock : Asset   // inherits from Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;
    }

    public class House : Asset   // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => base.Liability + Mortgage;

    }

    public abstract class AbstractAsset
    {
        // Note empty implementation
        public abstract decimal NetValue { get; }
    }

    public class StockFromAbstract : AbstractAsset
    {
        public long SharesOwned;
        public decimal CurrentPrice;

        // Override like a virtual method.
        public override decimal NetValue => CurrentPrice * SharesOwned;
    }

    public class A { public int Counter = 1; }
    public class B : A { public int Counter = 2; }

    public class BaseClass
    {
        public int X;
        public BaseClass() { X = 1; }
        public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }
    }

    public class Subclass : BaseClass
    {
        public Subclass() { Console.WriteLine(X); }  // 1
    }

    public class Overrider : BaseClass
    {
        public override void Foo() { Console.WriteLine("Overrider.Foo"); }
    }

    public class Hider : BaseClass
    {
        public new void Foo() { Console.WriteLine("Hider.Foo"); }
    }
}
