using System;

namespace helloProgram
{
    class Program
    {
        private const string textPhrase = "My name is: ";

        static void Main(string[] args)
        {
            string myName = args[0];

            Console.WriteLine(textPhrase + myName);
            Console.WriteLine("Data: " + DateTime.Now.ToString("dd/mm/yyyy"));
            Console.WriteLine("Czas: " + (DateTime.Now.ToString("HH:mm:ss")));

            //foreach (var item in args)
            //{
            //    Console.WriteLine(textPhrase + myName);
            //}
        }
    }
}
