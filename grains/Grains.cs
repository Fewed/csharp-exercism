using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        var error = new ArgumentOutOfRangeException("Argument out of range!");
        return (n < 1) || (n > 64) ? throw error : (ulong)1 << (n - 1);
    }

    public static ulong Total() => unchecked((ulong)-1); // 2^64 - 1
}