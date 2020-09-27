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
            var res = test.Select(PhoneNumber.Clean);
            foreach (var item in res) Console.Write($"{item} ");


        }



        public class PhoneNumber
        {
            public static (string,bool) Clean(string phoneNumber)
            {
                var input = (new Regex(@"[0-9]*")).Matches(phoneNumber)
                    .Aggregate("", (acc, cur) => acc + cur);

                if ((input.Length == 11) && (input[0] == '1')) input = input[1..];

                var pattern = new Regex(@"[2-9]\d{2}[2-9]\d{2}\d{4}");
                var res = pattern.IsMatch(input);
                return (input,res);
            }
        }


    }
}
