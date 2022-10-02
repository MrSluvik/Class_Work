using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Console;

namespace Pair_CSharp_28._08._2022
{
    partial class Program
    {
        static void Main2()
        {          
            //завдання 1
            int[] arr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            //
            All_City(arr);
            Pair(arr);
            NoPair(arr);

            Console.Write($"Введіть число ");
            int n = Convert.ToInt32(ReadLine());
            MoreN(arr, n);

            Diapazon(arr);
            Seven(arr);
            Eigth(arr);

        }
        public static void All_City(int[] arr)
        {
            var SelectedArray = from i in arr
                                select i;
            foreach (int numb in SelectedArray)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void Pair(int[] arr)
        {
            var SelectedArray2 = from i in arr
                                 where i % 2 == 0
                                 select i;
            foreach (int numb in SelectedArray2)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void NoPair(int[] arr)
        {
            var SelectedArray3 = from i in arr
                                 where i % 2 != 0
                                 select i;
            foreach (int numb in SelectedArray3)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void MoreN(int[] arr,int n)
        {
            var SelectedArray4 = from i in arr
                                 where i > n
                                 select i;
            foreach (int numb in SelectedArray4)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();
        }
        public static void Diapazon(int[] arr)
        {
            var SelectedArray5 = from i in arr
                                 where i > 50 && i < 80
                                 select i;
            foreach (int numb in SelectedArray5)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();

        }
        public static void Seven(int[] arr)
        {
            var SelectedArray6 = from i in arr
                                 where i % 7 == 0
                                 orderby i ascending
                                 select i;
            foreach (int numb in SelectedArray6)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();

        }
        public static void Eigth(int[] arr)
        {
            var SelectedArray7 = from i in arr
                                 where i % 8 == 0
                                 orderby i descending
                                 select i;
            foreach (int numb in SelectedArray7)
            {
                Console.Write($"{numb} ");
            }
            Console.WriteLine();

        }
    }
}
