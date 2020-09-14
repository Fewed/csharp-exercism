using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2011, 4, 25);
            var dt2 = Add(dt);
            Console.WriteLine(dt);
            Console.WriteLine(dt2);
        }



        static DateTime Add(DateTime moment)
        {
            return moment.AddSeconds(1e9);
        }
    }
}
