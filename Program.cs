using System;
using static System.Console;
using System.Text;

namespace Pair_CSharp_28._08._2022
{class Passport
    {
        public string Seria;
        public UInt32 Number;
        public Passport()
        {
            Seria = "";
            Number = 0;
        }
        public Passport(string seria,uint number):this()
        {
            Seria = seria;
            Number = number;
        }
        public override string ToString()
        {
            return $"Seria:{Seria}\nNumber: {Number}\n";
        }
    }
    class Person 
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public UInt32 Age { set; get; }
        public UInt32 INN { set; get; }
        public Passport passport { set; get; }
        public Person()
        {
            Name = "";
            Surname = "";
            Age = 0;
            INN = 0;
            passport = null;
        }
        public Person(string Name,string Surname):this()
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public Person(uint INN):this()
        {
            this.Name = Name;
            this.Surname = Surname;
           
        }

        public Person(string Name, string Surname,uint Age) : this(Name,Surname)
        {
            this.Age = Age;
        }
        public Person(string Name, string Surname, uint Age,uint iNN,Passport passport) : this(Name, Surname,Age)
        {
            INN = INN;
            this.passport = passport;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nSurname: {Surname}\nAge:{Age}\nINN: {INN}\n{passport.ToString()}";
        }



    }

    class Worker : Person
    {
        public uint Salary { set; get; }
        public string Position { set; get; }
       
        public Worker() : base()
        {
            this.Salary = 0;
            this.Position = "";
        }
        public Worker(uint salary, string position) : this()
        {
            Salary = salary;
            Position = position;
        }
        public Worker(string Name, string Surname, uint Age, uint iNN, Passport passport,uint Salary, string Position) : base(Name, Surname, Age,iNN,passport)
        {
            this.Salary = Salary;
            this.Position = Position;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nSurname: {Surname}\nAge:{Age}\nINN: {INN}\n{passport.ToString()}\nSalary:{Salary}\nPosition:{Position}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding= Encoding.Unicode;

            Person person = new Person("Vasya", "Pupkin", 23, 1234342432, new Passport("AR", 12456));
            WriteLine(person);
            Worker worker = new Worker("Vasya", "Pupkin", 23, 1234342432, new Passport("AR", 12456),2000,"Manager");
            WriteLine(worker);
        }
    }
}
