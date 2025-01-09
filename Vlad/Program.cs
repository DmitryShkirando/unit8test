using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Vlad
{
    class People
    {
        public string _rase { get; protected set; }

        public const string HUMAN = "Man";

        public readonly string SkinColor;
        public People(string Rase, string skinColor)
        {
            _rase = Rase;
            SkinColor = skinColor;  
        }

        public virtual void Show()
        {
            Console.WriteLine($"It is {_rase}");
        }
    }

    class Student : People
    {
        public int Age { get; set; }
        public string _name { get; }
        public Student(string name, string rase, string skin, int age) : base(rase, skin)
        {
            _name = name;
            Age = age;
        }

        public override void Show()
        {
            _rase = "Vova";
            Console.WriteLine($"It is {_name}, He is: {_rase}");
        }

        public int Summ(int a, int b)
        {
            return a + b;
        }

        public int LambdaSumm(int a, int b) => a + b;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            List<string> countries = new List<string>()
            {
                "Georgia",
                "Belarus",
                "Rissia"
            };

            List<Student> students = new List<Student>()
            { 
                new Student("Vova", "Asian", "White", 28),
                new Student("Boba", countries[1], "White", 25),
                new Student("Grisha", countries[0], "White", 55),
                new Student("Sush", countries[1], "Blue", 25),
                new Student("Ara", countries[2], "Grey", 17),
            };

            Student student2 = new Student("Sasha", countries[2], "Orange", 33);
            students.Add(student2);

            var oldStudents = students.OrderBy(student => student._name).ToList();
            var oldStudents5 = from student in students where student.Age > 20 orderby student._name select student;
            var t = oldStudents5.ToList();

            var oldStudentsLinq1 = students.Where(student => student.Age > 20).OrderBy(x => x.Age).Select(student => student._name).ToList();

            var valeric = students.Where(x => x.SkinColor!= "White").OrderBy(x => x.Age).Select(x => x.SkinColor).ToList();

            


            var bestStudent = students.OrderBy(x => x._name).Where(x => x.Age < 26).FirstOrDefault(x => x.SkinColor.Equals("Blue"));
            var AllStudent = students.OrderBy(x => x._name).Where(x => x.Age < 26).All(x => x.SkinColor.Equals("Green"));
            var AnyStudent = students.OrderBy(x => x._name).Where(x => x.Age < 26).Any(x => x.SkinColor.Equals("Blue"));
            var correctStudent = students.Where(x => x.Age > 25 && x.SkinColor.Equals("White")).ToList();
            //Console.WriteLine(bestStudent._name);

            List < Student > newStudent = new List<Student>();

            foreach (var student in students)
            {
                if (student.Age <= 25)
                {
                    newStudent.Add(student);
                }
            }
            foreach (var student in newStudent)
            {
                Console.WriteLine(student._name);
            }
            Console.WriteLine();

            foreach (var student in oldStudents)
            {
                Console.WriteLine(student._name);
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("dick", 10);
            var ten = dict["dick"];

            Dictionary<string, int> newDict = new Dictionary<string, int>()
            {
                { "boba", 1 },
                { "vlad", 7 },
                { "dima", 10 }
            };

            LinkedList<Student> list = new LinkedList<Student>();

            ArrayList array= new ArrayList() { 10, "Vlad", new Student("Ara", countries[2], "Grey", 17) };
            
            Generic gen = new Generic();
            var a = gen.GetNew<string>("Vlad");
            var b = gen.GetNew<int>(10);
            var c = gen.GetNew<Student>(student2);

            var d = gen.GetNewList<Student>(student2);
            Console.WriteLine($"Student - {d.FirstOrDefault()._name}");

            Console.ReadLine();
        }

        public class Generic
        {
            public T GetNew<T>(T value)
            {
                return value;
            }

            public List<T> GetNewList<T>(T value)
            {
                List<T> list = new List<T>();
                list.Add(value);    
                return list;
            }
        }
    }
}
