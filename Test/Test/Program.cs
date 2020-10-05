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

            Console.WriteLine(ArmstrongNumbers.IsArmstrongNumber(153));
            //Console.WriteLine("91 14 42");
        }

    }





    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int number)
        {
            var data = number.ToString();

            return data.Sum(n => (int)Math.Pow(int.Parse("" + n), data.Length)) == number;
        }
    }


    // 9475




}
