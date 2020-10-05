using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var data = number.ToString();

        return data.Sum(n => (int)Math.Pow(int.Parse("" + n), data.Length)) == number;
    }
}