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

            Console.WriteLine(DifferenceOfSquares.CalculateSumOfSquares(0));
            //Console.WriteLine("91 14 42");
        }

    }





    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max) =>
            (int)Math.Pow(Enumerable.Range(1, max).Sum(), 2);

        public static int CalculateSumOfSquares(int max) =>
            Enumerable.Range(1, max).Select(x => x * x).Sum();

        public static int CalculateDifferenceOfSquares(int max) =>
            CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }




}
