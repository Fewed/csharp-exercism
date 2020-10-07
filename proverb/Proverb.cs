using System;

public static class Proverb
{
    static string GetStartString(string a, string b) => $"For want of a {a} the {b} was lost.";
    static string GetEndString(string a) => $"And all for the want of a {a}.";

    public static string[] Recite(string[] subjects)
    {
        var result = new string[subjects.Length];
        if (result.Length == 0) return result;


        for (var i = 0; i < subjects.Length - 1; i++)
        {
            result[i] = GetStartString(subjects[i], subjects[i + 1]);
        }

        result[^1] = GetEndString(subjects[0]);

        return result;
    }
}