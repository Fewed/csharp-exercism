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

            Console.WriteLine(Series.Slices("9142", 2));
            Console.WriteLine("91 14 42");
        }

    }



    public static class Series
    {
        public static string[] Slices(string numbers, int sliceLength)
        {
            var m = numbers.Length;
            var n = sliceLength;
            var size = m + 1 - n;
            var temp = new string[size];
            for (var i = 0; i < size; i++) temp[i] = numbers[i..(i + n)];
            return temp;
        }
    }

    //var expected = new[] { "91", "14", "42" };
    //Assert.Equal(expected, Series.Slices("9142", 2));

    // 3|2=2 5|2=4  m/(n-1)-1  m/(2n-m) - (m-n) || m+1-n
    // 5|3=3 5/(6-5) - 2 = 3


}
