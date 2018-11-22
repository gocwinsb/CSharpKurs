using System;

namespace helloProgram
{
    class Program
    {
        private const string askForName = "What is your name: ";
        private const string askForAge =  "What is your age: ";

        static void Main(string[] args)
        {
            int age;
            for (; ;)
            {
                string name = AskForName();
                age = NewMethod1(name);

                ClearProgramData();
            }


        }

        private static int NewMethod1(string name)
        {
            int age;
            Console.Write(askForAge);
            bool ageResult = int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Hi, " + name +
                                "\nDzisiejsza data to: " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jestes pełnoletni !");
            }
            else if (ageResult == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Wprowadziłeś błędny wiek !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Nie jestes pełnoletni !");
            }

            return age;
        }

        private static void ClearProgramData()
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            Console.Clear();
            Console.ResetColor();
        }

        private static string AskForName()
        {
            Console.Write(askForName);
            string name = Console.ReadLine();
            return name;
        }
    }
}
