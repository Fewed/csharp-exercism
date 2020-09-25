using System;
using System.Linq;
using System.Text.RegularExpressions;

using Microsoft.VisualBasic.CompilerServices;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var pattern = new Regex(@"[a-zA-Z']+");
        var words = pattern.Matches(phrase).Select(item => item.ToString());

        return words.Aggregate("", (acc, cur) => acc + char.ToUpper(cur[0]));
    }
}