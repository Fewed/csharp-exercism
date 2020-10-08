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
            //var test = new List<string> { "2234567890", "+1 (223) 456-7890" };

            //var array = new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634 };
            //var value = 144;

            var array = new[] { 1, 3,21, 5, 8 };
            var value = 21;

            var res = BinarySearch.Find(array, value);
            Console.WriteLine(res);
        }

    }





    public static class BinarySearch
    {
        public static int Find(int[] input, int value)
        {
            int GetMiddleIdx() => (int)Math.Round((float)input.Length / 2);

            if (input.Length == 0) return -1;

            int idx, idxPre = -1, middleIdx;
            idx = middleIdx = GetMiddleIdx();

            while (input[middleIdx] != value)
            {
                if (value > input[middleIdx])
                {
                    input = input[middleIdx..];
                    middleIdx = GetMiddleIdx();
                    idx += middleIdx;
                }
                else
                {
                    input = input[..middleIdx];
                    middleIdx = GetMiddleIdx();
                    idx -= middleIdx;
                }

                if (idx == idxPre) return -1;
                idxPre = idx;
            }

            return idx;
        }
    }








}
