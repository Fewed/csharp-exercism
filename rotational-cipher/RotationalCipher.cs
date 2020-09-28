using System;
using System.Linq;

public static class RotationalCipher
{
    static readonly string chars = "abcdefghijklmnopqrstuvwxyz";
    static char GetChar(char value, int offset)
    {
        if (!char.IsLetter(value)) return value;
        var isUpper = char.IsUpper(value);
        value = char.ToLower(value);
        var idx = chars.IndexOf(value) + offset;
        if (idx >= chars.Length) idx -= chars.Length;
        return isUpper ? char.ToUpper(chars[idx]) : chars[idx];
    }

    public static string Rotate(string text, int shiftKey) =>
        text.Aggregate("", (acc, cur) => acc + GetChar(cur, shiftKey));
}