using System;

public static class CollatzConjecture
{
    public static int Steps(int n)
    {
        if (n < 1) throw new ArgumentOutOfRangeException("Out of range!");
        var steps = 0;
        while (n != 1)
        {
            n = (n % 2 == 0) ? n / 2 : 3 * n + 1;
            steps++;
        }
        return steps;
    }
}