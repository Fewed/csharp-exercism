using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var m = numbers.Length;
        var n = sliceLength;
        if (n > m || n <= 0) throw new ArgumentException("Wrong parameters!");
        var size = m + 1 - n;
        var temp = new string[size];
        for (var i = 0; i < size; i++) temp[i] = numbers[i..(i + n)];
        return temp;
    }
}