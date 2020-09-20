using System;
using System.Collections.Generic;

public class Robot
{
    public string Name { get; private set; }

    private static readonly (char type, int size)[] pattern = {
                ('L', 2),
                ('d', 3)
            };
    public static HashSet<string> names = new HashSet<string> { };

    public Robot() => Name = GetName();



    private static char GetRandomChar(char type)
    {
        var decoder = new Dictionary<char, (int, int)>
        {
            ['L'] = ('A', 'Z'),   // ASCII A-Z range
            ['d'] = ('0', '9')    // ASCII 0-9 range
        };
        var (min, max) = decoder[type];
        var random = new Random();
        return (char)random.Next(min, max + 1);
    }

    private static string GenerateName()
    {
        var name = "";

        for (var i = 0; i < pattern.Length; i++)
        {
            var (type, size) = pattern[i];
            for (var j = 0; j < size; j++) name += GetRandomChar(type);
        }

        return name;
    }

    private static string GetName()
    {
        string name;

        do name = GenerateName();
        while (!names.Add(name));

        return name;
    }

    public void Reset()
    {
        names.Remove(Name);
        Name = GetName();
    }
}