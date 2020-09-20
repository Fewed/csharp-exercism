using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            var r = new Robot();
            Console.WriteLine(r.Name);
            var r2 = new Robot();
            Console.WriteLine(r2.Name);
            Print(Robot.names);
            r.Reset();
            Print(Robot.names);

        }



        static void Print(HashSet<string> str)
        {
            foreach (string item in str) Console.Write($"{item}, ");
            Console.Write("\n");
        }


        public class Robot
        {
            public string Name { get; private set; }

            private static readonly (char type, int size)[] pattern = {
                ('L', 2),
                ('d', 3)
            };
            public static HashSet<string> names = new HashSet<string> { };

            public Robot() => Name = GetName();



            private static char GetRandomChar(char type)
            {
                var decoder = new Dictionary<char, (int, int)>
                {
                    ['L'] = ('A', 'Z'),   // ASCII A-Z range
                    ['d'] = ('0', '9')    // ASCII 0-9 range
                };
                var (min, max) = decoder[type];
                var random = new Random();
                return (char)random.Next(min, max + 1);
            }

            private static string GenerateName()
            {
                var name = "";

                for (var i = 0; i < pattern.Length; i++)
                {
                    var (type, size) = pattern[i];
                    for (var j = 0; j < size; j++) name += GetRandomChar(type);
                }

                return name;
            }

            private static string GetName()
            {
                string name;

                do name = GenerateName();
                while (!names.Add(name));

                return name;
            }

            public void Reset()
            {
                names.Remove(Name);
                Name = GetName();
            }
        }


        //public class HighScores
        //{
        //    private List<int> _list;
        //    public HighScores(List<int> list) => _list = list;

        //    public List<int> Scores() => _list;

        //    public int Latest() => _list.Last();

        //    public int PersonalBest() => _list.Max();

        //    public List<int> PersonalTopThree()
        //    {
        //        var temp = new List<int> { }; // preventing _list mutation due to sorting
        //        foreach (int item in _list) temp.Add(item);
        //        temp.Sort((a, b) => a <= b ? 1 : -1);
        //        var topScoresQuantity = temp.Count < 3 ? temp.Count : 3;
        //        return temp.GetRange(0, topScoresQuantity);
        //    }
        //}

    }
}
