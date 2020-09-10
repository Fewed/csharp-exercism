using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = { "", "tobor", "nemaR", "!yrgnuh m'I", "racecar", "reward" };

            foreach (string item in testArray)
            {
                Console.WriteLine($"{item} {item == RevStr(RevStr(item))}");
            }
        }

        static string RevStr(string input)
        {
            string temp = "";
            for (int i = input.Length; i > 0; i--) temp += input[i - 1];
            return temp;
        }
    }
}
