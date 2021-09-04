using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DynamicBinding
{
    class Program
    {
        static void Foo(object x, object y) { Console.WriteLine("oo"); }
        static void Foo(object x, string y) { Console.WriteLine("os"); }
        static void Foo(string x, object y) { Console.WriteLine("so"); }
        static void Foo(string x, string y) { Console.WriteLine("ss"); }
        static void Main(string[] args)
        {
            //dynamic d = GetSomeObject("sss");
            //Console.WriteLine(d);


            //dynamic d = new Duck();
            //d.Quack();                  // Quack method was called
            //d.Waddle();                 // Waddle method was called
            //d.Xankisi();                // Xankisi method was called

            //dynamic x = "hello";
            //Console.WriteLine(x.GetType().Name);  // String
            //x = 123;  // No error (despite same variable)
            //Console.WriteLine(x.GetType().Name);  // Int32

            // •var says, “Let the compiler figure out the type.”
            // •dynamic says, “Let the runtime figure out the type.”

            //dynamic x = "hello";  // Static type is dynamic, runtime type is string
            //var y = "hello";      // Static type is string, runtime type is string
            //int i = x;            // Runtime error      (cannot convert string to int)
            //int j = y;            // Compile-time error (cannot convert string to int)


            //dynamic list = new List<int>();
            //var result = list.Add(5);         // RuntimeBinderException thrown

            object o = "hello";
            dynamic d = "goodbye";

            Foo(o, d);               // os

 

        }
     
        private static dynamic GetSomeObject(string a)
        {
            if (a == "ss")
            {
                return "sss";
            }
            else return 45;
        }

    }
    public class Person
    {
        public string Name { get; set; }
    }
    public class Duck : DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder,
                                             object[] args,
                                             out object result)
        {
            Console.WriteLine(binder.Name + " method was called");
            result = null;
            return true;
        }
    }
}
