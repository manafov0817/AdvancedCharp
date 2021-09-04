using System;
using System.IO;

namespace tryStatementsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int y = Calc(0);
            //Console.WriteLine(y);

            //try
            //{
            //    int y = Calc(0);
            //    Console.WriteLine(y);
            //}
            //catch 
            //{
            //    Console.WriteLine("x cannot be zero");
            //}
            //Console.WriteLine("program completed");




            //try
            //{
            //    byte b = byte.Parse(args[0]);
            //    Console.WriteLine(b);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Please provide at least one argument");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("That's not a number!");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("You've given me more than a byte!");
            //}






            //StreamReader reader = null;
            //// In System.IO namespace
            //try
            //{
            //    reader = File.OpenText("file.txt");
            //    if (reader.EndOfStream) return;
            //    Console.WriteLine(reader.ReadToEnd());
            //}
            //catch (FileNotFoundException nfe)
            //{
            //    Console.WriteLine(nfe.Message);

            //}
            //finally
            //{
            //    if (reader != null)
            //        reader.Dispose();
            //}


            try { Display(null); }
            catch (ArgumentNullException ex) { Console.WriteLine("Caught the exception"); }

           
        }
        static int Calc(int x) => 10 / x;
        string ProperCase(string value)
        {
            return value == null ? throw new ArgumentException("value") : value == "" ? "" : char.ToUpper(value[0]) + value.Substring(1);
        }
        static void Display(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            Console.WriteLine(name);
        }
    }
}
