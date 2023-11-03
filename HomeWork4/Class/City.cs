using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.Class
{
    public class City
    {
        public int Populace { get; set; }

        public City(int populace) 
        {
            Populace = populace;
        }

        public void ShowPeople()
        {
            Console.WriteLine($"Number of population: {Populace}");
        }

        public static City operator +(City a, City b)
            => new (a.Populace + b.Populace);


        public static City operator -(City a, City b)
            => new (a.Populace - b.Populace);


        public static bool operator ==(City a, City b)
            => a.Populace == b.Populace;
        public static bool operator !=(City a, City b)
            => a.Populace != b.Populace;


        public static bool operator >(City a, City b)
            => a.Populace > b.Populace;
        public static bool operator <(City a, City b)
            => a.Populace < b.Populace;
    }
}
