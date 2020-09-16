﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var planets = new Dictionary<string, double>
            {
                ["Earth"] = 1,
                ["Mercury"] = 0.2408467,
                ["Venus"] = 0.61519726,
                ["Mars"] = 1.8808158,
                ["Jupiter"] = 11.862615,
                ["Saturn"] = 29.447498,
                ["Uranus"] = 84.016846,
                ["Neptune"] = 164.79132,
            };

            var code = GenText("../../../template.txt", planets);
            Console.WriteLine(code);
            File.WriteAllText("../../../SpaceAge.cs", code);

            //var sa = new SpaceAge(2129871239);
            //var age = sa.onMars();
            //Console.WriteLine(age);
        }

        static string GenText(string path, Dictionary<string, double> dict)
        {
            var srcArr = File.ReadAllText(path).Split("\n");
            var (firstArr, lastArr) = (srcArr[..^1], srcArr[^1..]);
            var (first, last) = (String.Join("\n", firstArr) + "\n\n", String.Join("\n", lastArr));

            foreach (string key in dict.Keys)
            {
                first += $"    public double On{key}() => _seconds / (_k * {dict[key]});\n\n";
            }
            return first.Trim() + "\n" + last;
        }

        //class SpaceAge
        //{
        //    private double _seconds;
        //    private double _k = 31557600;

        //    public SpaceAge(int seconds) => _seconds = seconds;

        //    public double onMars() => _seconds / (_k * 1.8808158);
        //}
    }
}
