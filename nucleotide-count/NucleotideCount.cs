using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var result = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (char item in sequence)
        {
            if (!result.ContainsKey(item)) throw new ArgumentException("Invalid nucleotide!");
            result[item]++;
        }

        return result;
    }
}