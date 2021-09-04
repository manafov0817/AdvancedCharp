using System;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<int> i = null;
            //Console.WriteLine(i .HasValue);              // True


            //int? x = 5;        // implicit
            //int y = (int)x;    // explicit

            //object o = "4"; 
            //int? x = o as int?;
            //Console.WriteLine(x.HasValue);


            int? a = null;
            int? b = 23;
            //Console.WriteLine(a<b);

            b = a;

            string? astring = null;
            string bstring = "bstring";

            Console.WriteLine(astring + bstring);

            System.Text.StringBuilder sb = null;
            int? length = sb?.ToString().Length;

#nullable enable    // Enable nullable reference types
            string s1 = null;   // Generates a compiler warning!string? s2 = null;

        }
    }
}
