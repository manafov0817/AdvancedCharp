using System;

namespace Patterns
{
    class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "ss";

            if (obj is string)
                Console.WriteLine(((string)obj).Length);


            if (obj is MyClass { Id: 4, Name: "Mahammad" })
                Console.WriteLine("A string with 4 characters");

            bool ShouldAllow(Uri uri) => uri switch
            {
                { Scheme: string { Length: 4 }, Port: 80 } => true,
                { Scheme: "https", Port: 443 } when uri.Host.Length < 1000 => true,
                { Scheme: "ftp", Port: 21 } => true,
                { IsLoopback: true } => true,
                _ => false
            };



        }
    }
}
