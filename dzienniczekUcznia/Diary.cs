using System;
using System.Collections.Generic;
using System.Linq;

namespace dzienniczekUcznia
{
    class Diary
    {
        // stan ( zmienne - pola)
        List<float> ratings = new List<float>();
            

        // zachowania
        public void AddRaiting(float raiting)
        {
            ratings.Add(raiting);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;


            foreach (var raiting in ratings)
            {
                sum += raiting;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float GetMaxRating()
        {
            // metoda Max zwraca największą wartość z listy
            return ratings.Max();
        }

        public float GetMinRating()
        {
            // metoda Min zwraca najmniejszą wartość z listy
            return ratings.Min();
        }
    }
}
