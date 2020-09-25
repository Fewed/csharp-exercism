using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

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

            var a = "give me _your_ money";
            var b = "First In, First Out";
            Console.WriteLine(Acronym.Abbreviate2(b));
            //var re = new Regex(@"[a-z]+");
            //foreach (var item in re.Matches(a)) Console.Write(item+" ");
            //Console.WriteLine(Regex.IsMatch(a, @"^[a-zA-Z]+$"));
        }

        public static class Acronym
        {
            public static string Abbreviate(string phrase)
            {
                var words = phrase.Split(' ', '-');

                static string Process(string acc, string cur)
                {
                    var firstLetter = cur.ToCharArray().Where(char.IsLetter).ElementAt(0);
                    return acc + char.ToUpper(firstLetter);
                }

                return words.Aggregate("", Process);
            }

            public static string Abbreviate2(string phrase)
            {
                var pattern = new Regex(@"[a-zA-Z]+");
                var words = pattern.Matches(phrase).Select(item => item.ToString());
                //foreach (var item in re.Matches(a)) Console.Write(item + " ");
                //var words = phrase.Split(' ', '-').Where(item=>item.Contains(char.IsLetter()));

                static string Process(string acc, string cur)
                {
                    var firstLetter = cur[0];
                    return acc + char.ToUpper(firstLetter);
                    
                }

                return words.Aggregate("", Process);
            }
        }

    }
}
