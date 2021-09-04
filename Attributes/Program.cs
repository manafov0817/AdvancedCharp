using System;
using System.Runtime.CompilerServices;

namespace Attributes
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Foo foo = new Foo();
        }
        static void Foo([CallerMemberName] string memberName = null,
                        [CallerFilePath] string filePath = null,
                        [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }


    }
    [Obsolete]
    public class Foo { }
}
