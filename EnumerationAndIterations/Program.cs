using System;
using System.Collections.Generic;

namespace EnumerationAndIterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (var enumerator = "bee   r".GetEnumerator())
            //    while (enumerator.MoveNext())
            //    {
            //        var element = enumerator.Current;
            //        Console.WriteLine(element);
            //    }

            //List<int> list = new List<int> { 1, 2, 3 };

            //var dict = new Dictionary<int, string>() {
            //    { 5, "five" },
            //    { 10, "ten" }
            //};

            //foreach (int fib in Fibs(6))
            //    Console.Write(fib + "  ");

            //foreach (string fib in Foo(true))
            //    Console.WriteLine(fib);

            foreach (int fib in EvenNumbersOnly(Fibs(9)))
                Console.WriteLine(fib);


        }
        //static IEnumerable<int> Fibs(int fibCount)
        //{
        //    for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
        //    {
        //        yield return prevFib;
        //        int newFib = prevFib + curFib;
        //        prevFib = curFib; curFib = newFib;
        //    }
        //}
        static IEnumerable<string> Foo(bool breakEarly)
        {
            yield return "One";

            yield return "Two";

            if (breakEarly)
            {
                yield return "You Fucked Up";
                yield break;
            }

            yield return "Three";
        }

        IEnumerable<string> Foo()
        {
            try { yield return "One"; }    // Illegal

            //catch { }
            finally { }
        }

        static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
            {
                yield return prevFib;
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }

        static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
        {
            foreach (int x in sequence)
            {
                if ((x % 2) == 0)
                {
                    Console.WriteLine("EvenNumbersOnly");
                    yield return x;
                }
            }
        }

    }
}
