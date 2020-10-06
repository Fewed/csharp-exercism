using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    static Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            {3, "Pling" },
            {5, "Plang" },
            {7, "Plong" },
        };

    public static string Convert(int number)
    {
        var temp = "";
        var keys = dictionary.Keys.ToList();
        var (start, end) = (keys[0], keys[^1]);
        start = Math.Min(start, number);
        end = Math.Max(end, number);

        for (var i = start; i <= end; i++)
        {
            if (number % i == 0 && dictionary.ContainsKey(i)) temp += dictionary[i];
        }

        return temp == "" ? number.ToString() : temp;
    }
}