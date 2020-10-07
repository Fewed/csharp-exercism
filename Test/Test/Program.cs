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

            //var strings = new[]
            //        {
            //            "nail",
            //            "shoe"
            //        };

            var strings = new[] { "nail", "shoe", "horse", "rider", "message", "battle", "kingdom" };

            var res = Proverb.Recite(strings);

        }

    }



    public static class Proverb
    {
        static string GetStartString(string a, string b) => $"For want of a {a} the {b} was lost.";
        static string GetEndString(string a) => $"And all for the want of a {a}.";

        public static string[] Recite(string[] subjects)
        {
            var result = new string[subjects.Length];
            

            for (var i = 0; i < subjects.Length-1; i++)
            {
                result[i]=GetStartString(subjects[i], subjects[i + 1]);
                
            }

            result[^1] = GetEndString(subjects[0]);

            return result;
        }
    }


    //var strings = new[]
    //        {
    //            "nail",
    //            "shoe"
    //        };
    //var expected = new[]
    //{
    //            "For want of a nail the shoe was lost.",
    //            "And all for the want of a nail."
    //        };
    //Assert.Equal(expected, Proverb.Recite(strings));




}
