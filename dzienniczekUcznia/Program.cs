using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzienniczekUcznia
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
           // diary.AddRaiting(5);
           
            float avg = diary.CalculateAverage();
           // float maxRating = diary.GetMaxRating();
           // float minRating = diary.GetMinRating();

            for (; ;)
            {
                Console.Write("Podaj ocenę: ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating >= 0 && rating < 11)
                    {
                        diary.AddRaiting(rating);
                    }
                else if (result == false)
                    {
                    Console.WriteLine("Wprowadzone znaki, nie są liczbą z zakresu (0,11)."); ;
                    }
                else
                    {
                        break;
                    }
            }

            Console.WriteLine("Srednia z ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyzsza z ocen to: " + diary.GetMaxRating());
            Console.WriteLine("Najnizsza z ocen to: " + diary.GetMinRating());

            Console.ReadKey();
        }
    }
}
