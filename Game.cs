using System;
using System.Collections.Generic;
using System.Text;

namespace Pair_CSharp_28._08._2022
{
    public class Game
    {
        public string? Name { set; get; }
        public string? RealeseDate { set; get; }
        public double? Price { set; get; }
        public string? TypeOf { set; get; }

        public Game()
        {
            Name = "";
            RealeseDate = "";
            Price = 0;
            TypeOf = "";
        }
        public Game(string Name, string RealeseDate, double Price, string TypeOf)
        {
            this.Name = Name;
            this.RealeseDate = RealeseDate;
            this.Price = Price;
            this.TypeOf = TypeOf;
        }

        public void Start()
        {
            Console.WriteLine("Start Game!");
        }
        public void End()
        {
            Console.WriteLine("End Game!");
        }

    }
}
