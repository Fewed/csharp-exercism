using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        return Pang(input);
    }

    public static bool Pang(string input)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        foreach (char item in input.ToLower())
        {
            if (alphabet.Contains(item)) alphabet = alphabet.Remove(alphabet.IndexOf(item), 1);
        }

        return alphabet == "";
    }
}
