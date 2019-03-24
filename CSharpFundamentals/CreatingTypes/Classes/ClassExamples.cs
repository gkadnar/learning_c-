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
            Console.WriteLine("Octopus class deconstructed: " + o.Age);
            Console.WriteLine("Octopus class deconstructed: " + name);
            Console.WriteLine("Octopus class deconstructed: " + age);

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


}
