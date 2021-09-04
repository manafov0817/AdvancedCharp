using System;
using System.Data.SqlTypes;
using System.IO;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note b = new Note(2);

            //int ac = b + 2;


            //Console.WriteLine(b.value);

            //SqlBoolean a = SqlBoolean.Null;


            //Int64 a = (int)10l;

            //object o = a;

            //long l = (long)o;

            //Console.WriteLine(l);

            //object x = 45;
            //switch (x)
            //{
            //    case int b when b < 356:     // Fires only when b is true
            //        Console.WriteLine("True!");
            //        break;
            //    case bool b:
            //        Console.WriteLine("False!");
            //        break;
            //}

            //int x = 0;

            //for (int i = 0; i < 10; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            // }

            Console.WriteLine(Path.GetRandomFileName());


        }
    }
    public class Note
    {

        public int value;

        public Note(int semitonesFromA)
        {
            value = semitonesFromA;
        }

        public static int operator +(Note x, int semitones)
        {
            return x.value + semitones;
        }

        public static int operator -(Note x, int semitones)
        {
            return x.value + semitones;
        }
    }
}
