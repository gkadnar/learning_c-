using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingTypes.Classes
{
    class ClassExamples
    {
        public static void Example01()
        {
            //simplest class example
            YourClassName ycn = new YourClassName();
            Console.WriteLine("YourClassName class created");

            //field modifiers example
            FieldModifiersClass fmc = new FieldModifiersClass();
            Console.WriteLine("FieldModifiersClass class created");

            //methods and constructor examples
            Octopus o = new Octopus("zvecarka");             // Call constructor
            Console.WriteLine("Octopus class created: "+o.Age);
            o.WriteCubes();
            (string name, int age) = o;                     // Call deconstructor
            Console.WriteLine("Octopus class deconstructed age: " + o.Age);
            Console.WriteLine("Octopus class deconstructed name: " + name);
            Console.WriteLine("Octopus class deconstructed age: " + age);
            age = 22;
            Console.WriteLine("Octopus class deconstructed age changed?: " + o.Age);

            //object initializers examples
            Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
            Console.WriteLine($"Bunny1 {b1.Name}, {b1.LikesCarrots}, {b1.LikesHumans}");
            Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };
            Console.WriteLine($"Bunny2 {b2.Name}, {b2.LikesCarrots}, {b2.LikesHumans}");
            Bunny b3 = new Bunny(name: "Bo",likesCarrots: true);
            Console.WriteLine($"Bunny3 {b3.Name}, {b3.LikesCarrots}, {b3.LikesHumans}");

            //properties examples
            Stock msft = new Stock();
            msft.CurrentPrice = 30;
            msft.CurrentPrice -= 3;
            Console.WriteLine("Current price is = " + msft.CurrentPrice);
            msft.SharesOwned = 100;
            Console.WriteLine("My stock worth is = " + msft.Worth);
            msft.Worth3 = 27M;
            Console.WriteLine("Current shares owned is = " + msft.SharesOwned);
            Console.WriteLine("CurrentPrice2 property = " + msft.CurrentPrice2);
            Console.WriteLine("CurrentPrice3 property = " + msft.CurrentPrice3);

            //indexers examples
            Sentence s = new Sentence();
            Console.WriteLine(s[3]);       // fox
            s[3] = "kangaroo";
            Console.WriteLine(s[3]);       // kangaroo

            //partial types example
            PaymentForm pf = new PaymentForm();
            pf.Field1 = 23;
            Console.WriteLine("Partial types example = " + pf.Field1);

        }
    }

    // simplest class declaration
    class YourClassName
    {
                                                            // parameterless public constructor is generated automatically
    }

    class FieldModifiersClass
    {
        readonly string readOnlyField;                      // readonly field can be assigned only in declaration or in constructor.
    }

    class Octopus
    {
        string name;                                        // class field
        public int Age = 10;                                // class field
        string thirdField;                                  // class field

        public Octopus(string n)                            // Constructor definition
        {
            name = n;                                       // Initialization code (set up field)   
        }

        public Octopus(string n, int year) : this(n)        // Constructor overloading
        {
            year = Age;
        }

        private Octopus()                                   // Private constructor
        {

        }

        public void Deconstruct(out string n, out int year) // Deconstructor definition
        {
            n = name;
            year = Age;
        }

        //int Foo(int x) { return x * 2; }
        int Foo(int x) => x * 2;                            // shorten way for method definition using lambda expressions

        //method overloading
        void Foo(double x) {}
        void Foo(int x, float y) {}
        void Foo(float x, int y) {}
        void Foo(ref int x) {}                              // OK so far
        //void Foo(out int x) {}                            // Compile-time error cause ref and out are part of method signature

        // local methods
        public void WriteCubes()
        {
            Console.WriteLine(Cube(3));
            Console.WriteLine(Cube(4));
            Console.WriteLine(Cube(5));

            int Cube(int value) => value * value * value;
        }
    }

    class Bunny
    {
        public string Name;
        public bool LikesCarrots;
        public bool LikesHumans;

        public Bunny() { }
        public Bunny(string n) { Name = n; }
        public Bunny(string name,
              bool likesCarrots = false,
              bool likesHumans = false)
        {
            Name = name;
            LikesCarrots = likesCarrots;
            LikesHumans = likesHumans;
        }
    }

    public class Stock
    {
        private decimal currentPrice, sharesOwned;              // The private "backing" fields
        
        public decimal CurrentPrice                             // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        public decimal CurrentPrice2 { get; set; }              // same as above but defined as automatic property

        public decimal CurrentPrice3 { get; set; } = 123;       // same as above but additionaly set default value to 123

        public decimal SharesOwned
        {
            get { return sharesOwned; }
            set { sharesOwned = value; }
        }

        public decimal Worth                                    // read-only property without "backing" field
        {
            get { return currentPrice * sharesOwned; }
        }

        public decimal Worth2 => currentPrice * sharesOwned;    // same as above but shortened

        public decimal Worth3
        {
            get => currentPrice * sharesOwned;
            set => sharesOwned = value / currentPrice;
        }
    }

    class Sentence
    {
        string[] words = "The quick brown fox".Split();

        public string this[int wordNum]      // indexer
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
    }

    partial class PaymentForm               // part1 of partial class
    {
        private int field1;
        private int field2;
    }

    partial class PaymentForm               // part2 of partial class
    {
        public int Field1{get; set;}
    }          
}
