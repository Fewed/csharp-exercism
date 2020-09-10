using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        return RevStr(input);
    }

    static string RevStr(string input)
    {
        string temp = "";
        for (int i = input.Length; i > 0; i--) temp += input[i - 1];
        return temp;
    }

    static string RevStr2(string input)
    {
        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        return String.Join("", charArr);
    }
}