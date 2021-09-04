using LambdaExpressions.Models;
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transformer sqr = x => x * x; 

            //Console.WriteLine(sqr(3));    // 9;


            //Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;

            //int total = totalLength("hello", "world");   // total is 10;


            //int factor = 2;


            //factor = 10;
            //Func<int> multiplier = () => ++factor;

            //Console.WriteLine(multiplier());           // 30

            //Func<int> natural = Natural();
            //Console.WriteLine(natural());      // 0
            //Console.WriteLine(natural());      // 1


            //Action[] actions = new Action[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    int loopScopedi = i;
            //    actions[i] = () => Console.Write(loopScopedi);
            //}

            //foreach (Action a in actions)
            //    a();

    


        }

        static Func<int> Natural()
        {
            int seed = 0;
            return () => seed++;
            // Returns a closure
        }
    }
}
