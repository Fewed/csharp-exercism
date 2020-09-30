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
            var test = new List<string> { "2234567890", "+1 (223) 456-7890" };
            //var res = test.Select(PhoneNumber.Clean);
            //foreach (var item in res) Console.Write($"{item} ");

            var a = ScrabbleScore.Score("cabbage");
            Console.WriteLine(a);
        }



        public static class ScrabbleScore
        {
            static readonly Dictionary<char, int> dictionary = new Dictionary<char, int>
                {
                    {'A', 1 },
                    {'E', 1 },
                    {'I', 1 },
                    {'O', 1 },
                    {'U', 1 },
                    {'L', 1 },
                    {'N', 1 },
                    {'R', 1 },
                    {'S', 1 },
                    {'T', 1 },

                    {'D', 2 },
                    {'G', 2 },

                    {'B', 3 },
                    {'C', 3 },
                    {'M', 3 },
                    {'P', 3 },

                    {'F', 4 },
                    {'H', 4 },
                    {'V', 4 },
                    {'W', 4 },
                    {'Y', 4 },

                    {'K', 5 },

                    {'J', 8 },
                    {'X', 8 },

                    {'Q', 10 },
                    {'Z', 10 },
                };

            public static int Score(string input) =>
                input.Aggregate(0, (acc, cur) => acc + dictionary[char.ToUpper(cur)]);

        }


    }
}
