using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pair_CSharp_28._08._2022
{
    class Student
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string nameschool { get; set; }

        public Student()
        {
            name = "";
            lastname = "";
            age = 0;
            nameschool = "";
        }
         public Student(string name, string lastname, int age, string nameschool)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.nameschool = nameschool;
        }
    }

    partial class Program
    {
       
        public static void Main4()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Tom","Broit",21,"Oxford") ,
                  new Student("Boris","Brom",19,"MIT") ,
                    new Student("Toni","Nami",17,"Yurivka") ,
                      new Student("Harry","Claim",18,"MIT")                        
            };
            IEnumerable<Student> students1 = from s in students
                                             select s;                           
            foreach (var numb in students1)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();

            IEnumerable<Student> students2 = from s in students
                                             where s.name=="Boris"
                                             select s;
            foreach (var numb in students2)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();

            IEnumerable<Student> students3 = from s in students
                                             where s.lastname.StartsWith("Bro")
                                             select s;
            foreach (var numb in students3)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();

            IEnumerable<Student> students4 = from s in students
                                             where s.age>19
                                             select s;
            foreach (var numb in students4)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();

            IEnumerable<Student> students5 = from s in students
                                             where s.age > 20 && s.age<23
                                             select s;
            foreach (var numb in students5)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();

            IEnumerable<Student> students6 = from s in students
                                             where s.nameschool=="MIT"
                                             select s;
            foreach (var numb in students6)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();

            IEnumerable<Student> students7 = from s in students
                                             where s.nameschool == "Oxford" && s.age>18
                                             orderby s.age descending
                                             select s;
            foreach (var numb in students7)
            {
                Console.Write($"{numb.name} {numb.lastname} {numb.age} {numb.nameschool} \n");
            }
            Console.WriteLine();
        }
       
    }
}
// Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років. Результат відсортуйте за віком, за спаданням.
