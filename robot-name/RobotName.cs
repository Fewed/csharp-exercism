using System;
using System.Collections.Generic;

public class Robot
{
    private readonly int _idx;
    public string Name => names[_idx];

    private static readonly string pattern = "L2d3";
    public static List<string> names = new List<string> { };

    public Robot()
    {
        names.Add(GetName());
        _idx = names.Count - 1;
    }

    private static char GetRandomChar(char type)
    {
        var decoder = new Dictionary<char, (int, int)>
        {
            ['L'] = (65, 90),   // ASCII A-Z range
            ['d'] = (48, 57)    // ASCII 0-9 range
        };
        var (min, max) = decoder[type];
        var random = new Random();
        return (char)random.Next(min, max + 1);
    }

    private static string GenerateName()
    {
        var name = "";

        for (var i = 0; i < pattern.Length; i += 2)
        {
            var type = pattern[i];
            var size = int.Parse("" + pattern[i + 1]);
            for (var j = 0; j < size; j++) name += GetRandomChar(type);
        }

        return name;
    }

    private static string GetName()
    {
        string name;

        do name = GenerateName();
        while (names.Contains(name));

        return name;
    }

    public void Reset() => names[_idx] = GetName();
}