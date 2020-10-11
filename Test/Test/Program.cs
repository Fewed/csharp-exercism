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

            var res = Sieve.Primes(13);
            Console.WriteLine(res);
        }

    }


    //algorithm Sieve of Eratosthenes is
    //input: an integer n > 1.
    //output: all prime numbers from 2 through n.

    //let A be an array of Boolean values, indexed by integers 2 to n,
    //initially all set to true.

    //for i = 2, 3, 4, ..., not exceeding √n do
    //    if A[i] is true
    //        for j = i2, i2+i, i2+2i, i2+3i, ..., not exceeding n do
    //            A[j] := false

    //return all i such that A[i] is true.


    public static class Sieve
    {
        public static int[] Primes(int limit)
        {
            if (limit < 2) throw new ArgumentOutOfRangeException("Out of range!");

            var primes = Enumerable.Repeat(true, limit + 1).ToArray();
            var max = Math.Floor(Math.Sqrt(limit));

            for (var i = 2; i <= max; i++)
            {
                if (primes[i] == true)
                {
                    for (var j = i * i; j < limit + 1; j += i) primes[j] = false;
                }
            }

            return primes.Select((item, idx) => (item == true) && (idx != 1) ? idx : 0)
                .Where(item => item != 0).ToArray();
        }
    }


    //var expected = new[] { 2, 3, 5, 7 };
    //Assert.Equal(expected, Sieve.Primes(10));








}
