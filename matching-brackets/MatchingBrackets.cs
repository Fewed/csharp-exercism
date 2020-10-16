using System.Collections.Generic;
using System.Linq;

public static class MatchingBrackets
{
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

        var chars = new Stack<char> { };
        var keys = counters.Keys.ToList();

        foreach (var item in input)
        {
            if (counters.ContainsKey(item))
            {
                var idx = keys.IndexOf(item);
                var idxPre = keys.IndexOf(chars.ElementAt(chars.Count - 1));

                if (idx % 2 == 0)
                {
                    counters[item]++;
                    chars.Push(item);
                }
                else if (idx - idxPre == 1)
                {
                    counters[item]--;
                    chars.Pop();
                }
            }
        }

        return SumCounters(counters);
    }
}