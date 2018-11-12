using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Bartek");
            Console.WriteLine(DateTime.Now.ToString(("dd/mm/yyyy HH:mm:ss")));
            Console.ReadKey();
        }
    }
}
