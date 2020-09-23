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


            var a = new Allergies(0b_0000_0011);
            //Console.WriteLine(a.IsAllergicTo(Allergen.Eggs));
            //Console.WriteLine(a.IsAllergicTo(Allergen.Peanuts));
            foreach (Allergen item in a.List()) Console.WriteLine(item);

        }




        public enum Allergen
        {
            Eggs,
            Peanuts,
            Shellfish,
            Strawberries,
            Tomatoes,
            Chocolate,
            Pollen,
            Cats
        }

        public class Allergies
        {
            private readonly int _mask;

            public Allergies(int mask) => _mask = mask;

            public bool IsAllergicTo(Allergen allergen)
            {
                var pos = 1 << (int)allergen;
                return (pos & _mask) == pos;
            }

            public Allergen[] List()
            {

                var allergens = Enum.GetValues(typeof(Allergen)).Cast<Allergen>();
                var safeList = new List<Allergen> { };

                foreach (var item in allergens)
                {
                    if (!IsAllergicTo(item)) safeList.Add(item);
                }

                return allergens.Except(safeList).ToArray();
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
