using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace Pair_CSharp_28._08._2022
{
    partial class Program
    {
        public static void Main3()
        {
            string[] city = {"New-York","LA","Kyiv","Tokio","Nagoya","Amsterdam","Nevada" };

            All_City(city);
            City_Length(city);
            CityNameA(city);
            CityNameM(city);
            CityNameNK(city);
            CityNameNe(city);
        }
        public static  void All_City(string []city)
        {
            var SelectedArray = from i in city
                                select i;
            foreach (var numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void City_Length(string[] city)
        {
            var SelectedArray = from i in city
                                where i.Length==4
                                select i;
            foreach (var numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void CityNameA(string[] city)
        {
            var SelectedArray = (from i in city  where i.StartsWith("A") select i);
            foreach (var numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void CityNameM(string[] city)
        {
            var SelectedArray = (from i in city where i.EndsWith("m") select i);
            
            foreach (var numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void CityNameNK(string[] city)
        {
            var SelectedArray = (from i in city where i.StartsWith("N") && i.EndsWith("k") select i);

            foreach (var numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void CityNameNe(string[] city)
        {
            var SelectedArray = from i in city
                                where i.StartsWith("Ne")
                                orderby i descending
                                select i;

            foreach (var numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
    }
}
