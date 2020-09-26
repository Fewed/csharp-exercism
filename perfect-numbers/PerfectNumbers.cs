using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static int getSum(int number)
    {
        if (number == 1) return 0;

        var temp = number - 1;
        var factors = new List<int> { 1 };

        while (temp != 1)
        {
            if (number % temp == 0) factors.Add(temp);
            temp--;
        }
        return factors.Sum();
    }


    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException("Out of range!");
        var sum = getSum(number);
        if (sum == number) return Classification.Perfect;
        if (sum > number) return Classification.Abundant;
        return Classification.Deficient;
    }
}
