using System;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) throw new ArgumentOutOfRangeException("Out of range!");

        var primes = Enumerable.Repeat(true, limit + 1).ToArray();
        var max = Math.Floor(Math.Sqrt(limit));

        for (var i = 2; i <= max; i++)
        {
            if (primes[i] == true)
            {
                for (var j = i * i; j < limit + 1; j += i) primes[j] = false;
            }
        }

        return primes.Select((item, idx) => (item == true) && (idx != 1) ? idx : 0)
            .Where(item => item != 0).ToArray();
    }
}