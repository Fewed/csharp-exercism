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
            var test = new List<int> { 6, 12, 8 };
            var res = test.Select(PerfectNumbers.Classify);
            foreach (var item in res) Console.Write($"{item} ");

            var a = PerfectNumbers.getSum(12);
            Console.WriteLine(a);
        }

        public enum Classification
        {
            Perfect,
            Abundant,
            Deficient
        }

        public static class PerfectNumbers
        {
            public static int getSum(int number)
            {
                var temp = number - 1;
                var factors = new List<int> { 1 };

                while (temp != 1)
                {
                    if (number % temp == 0) factors.Add(temp);
                    temp--;
                }
                return factors.Sum();
            }


            public static Classification Classify(int number)
            {
                var sum = getSum(number);
                if (sum == number) return Classification.Perfect;
                if (sum > number) return Classification.Abundant;
                return Classification.Deficient;
            }


        }

    }
}
