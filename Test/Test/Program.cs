using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            var value = "([{}({}[])])";
            Console.WriteLine(value);
            Console.WriteLine(MatchingBrackets.IsPaired(value));

            //static void Te(ref int x) => ++x;

            //var a = 5;
            //Console.WriteLine(a);
            //Te(ref a);
            //Console.WriteLine(a);
        }



        public static class MatchingBrackets
        {
            static void UpdateCounters(char item, Dictionary<char, int> dict)
            {
                var step = dict.Keys.ToList().IndexOf(item) % 2 == 0 ? 1 : -1;
                if (dict.ContainsKey(item)) dict[item] += step;
            }

            static bool SumCounters(Dictionary<char, int> dict)
            {
                var values = dict.Values.ToArray();
                for (var i = 0; i < values.Length; i += 2)
                {
                    if (values[i] + values[i + 1] != 0) return false;
                }
                return true;
            }

            public static bool IsPaired(string input)
            {
                var counters = new Dictionary<char, int>
                {
                    {'[', 0},
                    {']', 0},

                    {'{', 0},
                    {'}', 0},

                    {'(', 0},
                    {')', 0},
                };

                foreach (var item in input) UpdateCounters(item, counters);

                return SumCounters(counters);
            }
        }


    }









}
