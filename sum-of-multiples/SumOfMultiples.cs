using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var temp = new List<int> { };
        multiples = multiples.Where(item => item != 0);

        for (int i = 1; i < max; i++)
        {
            foreach (var item in multiples)
            {
                if (i % item == 0 && !temp.Contains(i)) temp.Add(i);
            }
        }

        return temp.Sum();
    }
}