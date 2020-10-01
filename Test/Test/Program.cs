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

            var a = PythagoreanTriplet.TripletsWithSum(1000);
            //Console.WriteLine(10 / Math.Sqrt(2));
        }



        public static class PythagoreanTriplet
        {
            public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
            {

                for (var i = 0; i < sum; i++)
                {
                    var b = (sum * (sum - 2 * i)) / (2 * (sum - i));
                    var c = sum - i - b;
                    var cond1 = (i * i + b * b) == c * c;
                    var cond2 = (i < b) && (b < c);
                    if (cond1 && cond2) return new[] { 1,2,3};
                }
                return (2, 2, 3);
            }
        }

    }
}
