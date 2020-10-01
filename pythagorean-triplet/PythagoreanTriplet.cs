using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var temp = new List<(int a, int b, int c)> { };
        int a = 0, b = 0, c = 0;
        for (var i = 0; i < sum; i++)
        {
            a = i;
            b = (sum * (sum - 2 * a)) / (2 * (sum - a));
            c = sum - a - b;
            var cond1 = (a * a + b * b) == c * c;
            var cond2 = (a < b) && (b < c);
            if (cond1 && cond2) temp.Add((a, b, c));
        }
        return temp;
    }
}