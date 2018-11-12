using System;

namespace helloProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Bartek");
            Console.WriteLine(  );
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
