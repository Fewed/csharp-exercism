using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scores = new List<int> { 10, 30, 90, 30, 100, 20, 10, 0, 30, 40, 40, 70, 50 };
            //var sc = new HighScores(scores);
            //Print(sc.Scores());
            //Console.WriteLine(sc.Latest());
            //Console.WriteLine(sc.PersonalBest());
            //Print(sc.PersonalTopThree());
            //Print(sc.Scores());

            //var expected = new Dictionary<char, int>
            //{
            //    ['A'] = 20,
            //    ['C'] = 12,
            //    ['G'] = 17,
            //    ['T'] = 21
            //};



            //Print(Robot.names);
            //for (var i = 0; i < 10; i++) Robot.addName(pattern);
            //Print(Robot.names);

            //var r = new Robot();
            //Console.WriteLine(r.Name);
            //var r2 = new Robot();
            //Console.WriteLine(r2.Name);
            //Print(Robot.names);
            //r.Reset();
            //Print(Robot.names);


            //Console.WriteLine("\a");
            //delay();


            //int a, b;
            //b = a = 7;

            //string c, d;
            //c = d = "hj";

            //int[] e = new int[3] {1,2,3};
            //var f = e;



            //Console.WriteLine($"a={a}, b={b}");
            //Console.WriteLine($"c={c}, d={d}");
            //foreach (int item in e) Console.Write($"{item}, ");
            //Console.WriteLine();
            //foreach (int item in f) Console.Write($"{item}, ");
            //Console.WriteLine();

            //a++;
            //d.Replace('j','A');
            //e[1] = 9;

            //Console.WriteLine($"a={a}, b={b}");
            //Console.WriteLine($"c={c}, d={d}");
            //foreach (int item in e) Console.Write($"{item}, ");
            //Console.WriteLine();
            //foreach (int item in f) Console.Write($"{item}, ");
            //Console.WriteLine();


            //var a = 0b0100;
            //var b = 0b0010;
            //var c = 0b0001;
            //var d = 0b0110;
            //Console.WriteLine((a & d) == a);

            //Console.WriteLine(checkAllergen((int)Allergen.Peanuts, 1));

            //getAllergens(0b_0000_0010);

            var gs = new GradeSchool();
            gs.Add("Mark", 2);

            gs.Add("Mary", 3);
            gs.Add("Antony", 2);
            Print2(gs._list);
            //var twos = gs.Grade(2);
            //Print(twos);
            var l = gs.Roster();
            //Print(l);
            Print2(gs._list);


            //var sut = new GradeSchool();
            //sut.Add("Franklin", 5);
            //sut.Add("Bradley", 5);
            //sut.Add("Jeff", 1);
            //var expected = new[] { "Bradley", "Franklin" };
            //var real= sut.Grade(5);

        }


        public static void Print(IEnumerable<string> list)
        {
            foreach (var item in list) Console.Write($"{item} ");
            Console.WriteLine();
        }

        public static void Print2(List<(string student, int grade)> list)
        {
            foreach (var item in list) Console.Write($"{item.student}={item.grade} ");
            Console.WriteLine();
        }

        public class GradeSchool
        {
            public readonly List<(string student, int grade)> _list = new List<(string student, int grade)> { };

            public void Add(string student, int grade) => _list.Add((student, grade));

            public IEnumerable<string> Roster()
            {
                var temp = _list.ToList();
                temp.Sort((a, b) => a.student.CompareTo(b.student));
                temp.Sort((a, b) => a.grade.CompareTo(b.grade));
                return temp.Select(item => item.student);
            }

            public IEnumerable<string> Grade(int grade)
            {
                var temp = _list.ToList();
                temp.Sort((a, b) => a.student.CompareTo(b.student));
                return temp.Where(item => item.grade == grade).Select(item => item.student);
                // can we use in C# something like javascript parameters desctructuring ?
                // Select(({student}) => student)
            }
        }

    }
}
