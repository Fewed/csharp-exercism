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
            Console.WriteLine(Triangle.IsScalene(7, 3, 2));
        }

    }





    public static class Triangle
    {
        static bool isTriangle(double side1, double side2, double side3)
        {
            var cond1 = (side1 > 0) && (side2 > 0) && (side3 > 0);
            var cond2 = (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
            return cond1 && cond2;
        }

        public static bool IsScalene(double side1, double side2, double side3)
        {
            var cond1 = (side1 != side2) && (side1 != side3) && (side2 != side3);
            return isTriangle(side1, side2, side3) && cond1;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            var cond1 = (side1 == side2) || (side1 == side3) || (side2 == side3);
            return isTriangle(side1, side2, side3) && cond1;
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            var cond1 = (side1 == side2) && (side1 == side3);
            return isTriangle(side1, side2, side3) && cond1;
        }
    }

    // Assert.False(Triangle.IsScalene(7, 3, 2));








}
