using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var a = new List<char> { };

        foreach (char item in word)
        {
            var charLower = char.ToLower(item);
            var isLetter = (charLower >= 'a') && (charLower <= 'z');
            if (isLetter && a.Contains(charLower)) return false;
            a.Add(charLower);
        }

        return true;
    }
}
