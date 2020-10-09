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

            var array = new[] { 1, 3, 21, 5, 8 };
            var value = 21;

            //var res = BinarySearch.Find(array, value);
            Console.WriteLine(BeerSong.G(99,2));
        }

    }







    public static class BeerSong
    {
        public static string GetFragment(int num)
        {
            var template1 = $"{num} bottles of beer on the wall, {num} bottles of beer.\n" +
            $"Take one down and pass it around, {num - 1} bottles of beer on the wall.\n\n";

            var template2 = $"2 bottles of beer on the wall, 2 bottles of beer.\n" +
            $"Take one down and pass it around, 1 bottle of beer on the wall.\n\n";

            var template3 = $"1 bottle of beer on the wall, 1 bottle of beer.\n" +
             $"Take one down and pass it around, no more bottles of beer on the wall.\n\n";

            var template4 = $"No more bottles of beer on the wall, no more bottles of beer.\n" +
             $"Go to the store and buy some more, 99 bottles of beer on the wall.\n\n";

            if (num == 2) return template2;
            if (num == 1) return template3;
            if (num == 0) return template4;
            return template1;
        }

        public static string Recite(int startBottles, int takeDown)
        {
            var res = "";

            for (var i = startBottles; i > startBottles-takeDown; i--)
            {
                res += GetFragment(i);
            }

            return res.Trim()
                ;
        }

        public static string G(int startBottles, int takeDown)
        {
            return Enumerable.Range(startBottles-takeDown+1,takeDown).Reverse()
           .Aggregate("", (acc, cur) => acc + " " + cur).Trim();
        }
    }

    //var expected =
    //            "99 bottles of beer on the wall, 99 bottles of beer.\n" +
    //            "Take one down and pass it around, 98 bottles of beer on the wall.\n" +
    //            "\n" +
    //            "98 bottles of beer on the wall, 98 bottles of beer.\n" +
    //            "Take one down and pass it around, 97 bottles of beer on the wall.";
    //Assert.Equal(expected, BeerSong.Recite(99, 2));








}
