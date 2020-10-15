using System.Collections.Generic;
using System.Linq;

public static class MatchingBrackets
{
    static void UpdateCounters(char item, Dictionary<char, int> dict)
    {
        var step = dict.Keys.ToList().IndexOf(item) % 2 == 0 ? 1 : -1;
        if (dict.ContainsKey(item)) dict[item] += step;
    }

    static bool SumCounters(Dictionary<char, int> dict)
    {
        var values = dict.Values.ToArray();
        for (var i = 0; i < values.Length; i += 2)
        {
            if (values[i] + values[i + 1] != 0) return false;
        }
        return true;
    }

    public static bool IsPaired(string input)
    {
        var counters = new Dictionary<char, int>
                {
                    {'[', 0},
                    {']', 0},

                    {'{', 0},
                    {'}', 0},

                    {'(', 0},
                    {')', 0},
                };

        foreach (var item in input) UpdateCounters(item, counters);

        return SumCounters(counters);
    }
}