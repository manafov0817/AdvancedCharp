using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bob = ("Bob", 23);    // Allow compiler to infer the element types



            //(string, int, bool) typedTuple = GetTuple(); // ("String",55,true)

            //var namedTuple = (name: "Mahammad", age: 55, hasdriverlicence: true);

            //(string name, int age, bool hasdriverlicence) namedTuple2 = (name: "Mahammad", age: 55, hasdriverlicence: true);

            //Type compitable

            //(string name, int age, char sex) bob1 = ("Bob", 23, 'M');
            //(string age, int sex, char name) bob2 = bob1;   // No error!

            //Console.WriteLine(bob2.name);    // M
            //Console.WriteLine(bob2.age);     // Bob
            //Console.WriteLine(bob2.sex);     // 23


            ValueTuple<string, int> bob1 = ValueTuple.Create("Bob", 23);
            (string, int) bob2 = ValueTuple.Create("Bob", 23);

            (string name, int age, bool hasdriverlicence) = GetTuple(); // deconstructing tuple

            (string, int, bool) deconstructingValuesTuple = (name, age, hasdriverlicence);

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(hasdriverlicence);


            Tuple<string, int> t = Tuple.Create("Bob", 23);  // Factory method
            Console.WriteLine(t.Item1);       // Bob
            Console.WriteLine(t.Item2);       // 23

        }
        static (string, int, bool) GetTuple()
        {
            return ("String", 55, true);
        }
    }
}
