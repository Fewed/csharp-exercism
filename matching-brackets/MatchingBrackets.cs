using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    List<char> stack = new List<char> { };
    public MyStack(params char[] initial)
    {
        if (initial.Length != 0)
            foreach (var item in initial) stack.Add(item);
    }

    public void Push(char item) => stack.Add(item);

    public void Pop() => stack.RemoveAt(stack.Count - 1);

    public char Last { get => stack.ElementAt(stack.Count - 1); }

    public void Print() =>
        Console.WriteLine(stack.Aggregate("", (acc, cur) => acc + $"{cur} ").Trim());
}

public static class MatchingBrackets
{
    static Dictionary<char, int> UpdateCounters(string input, Dictionary<char, int> counters)
    {
        var chars = new MyStack();
        var keys = counters.Keys.ToList();

        foreach (var item in input)
        {
            if (keys.Contains(item))
            {
                var idx = keys.IndexOf(item);

                if (idx % 2 == 0)
                {
                    counters[item]++;
                    chars.Push(item);
                }
                else
                {
                    var idxPre = keys.IndexOf(chars.Last);

                    if (idx - idxPre == 1)
                    {
                        counters[item]--;
                        chars.Pop();
                    }
                    else throw new Exception();
                }
            }
        }

        return counters;
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


        try { counters = UpdateCounters(input, counters); }
        catch { return false; }

        return SumCounters(counters);
    }
}