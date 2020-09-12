using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "nopqrstuvwxyz";
            string test2 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(Pangram(test2));
        }



        public static bool Pangram(string input)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (char item in input.ToLower())
            {
                if (alphabet.Contains(item)) alphabet = alphabet.Remove(alphabet.IndexOf(item), 1);
            }

            return alphabet == "";
        }
    }
}
