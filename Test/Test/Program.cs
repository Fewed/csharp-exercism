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

            Console.WriteLine(Raindrops.Convert(105));
            //Console.WriteLine("91 14 42");
        }

    }

    public static class Raindrops
    {
        static Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            {3, "Pling" },
            {5, "Plang" },
            {7, "Plong" },
        };

        public static string Convert(int number)
        {
            var temp = "";
            var keys = dictionary.Keys.ToList();
            var (start, end) = (keys[0], keys[^1]);
            start = Math.Min(start, number);
            end = Math.Max(end, number);

            for (var i = start; i <= end; i++)
            {
                if (dictionary.ContainsKey(i)) temp += dictionary[i];
            }

            return temp == "" ? number.ToString() : temp;
        }
    }

    // Assert.Equal("PlingPlangPlong", Raindrops.Convert(105));




}
