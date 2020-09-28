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

            Console.WriteLine(RotationalCipher.Rotate(
                "Gur dhvpx oebja sbk whzcf bire gur ynml qbt.", 13));
            Console.WriteLine(RotationalCipher.Rotate("omg", 5));
        }


        public static class RotationalCipher
        {
            static readonly string chars = "abcdefghijklmnopqrstuvwxyz";
            static char GetChar(char value, int offset)
            {
                if (!char.IsLetter(value)) return value;
                var isUpper = char.IsUpper(value);
                value = char.ToLower(value);
                var idx = chars.IndexOf(value) + offset;
                if (idx >= chars.Length) idx -= chars.Length;
                return isUpper ? char.ToUpper(chars[idx]) : chars[idx];
            }

            public static string Rotate(string text, int shiftKey) =>
                text.Aggregate("", (acc, cur) => acc + GetChar(cur, shiftKey));
        }



    }
}
