using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var error = new ArgumentException("Wrong format!");
        var input = new Regex(@"[0-9]*").Matches(phoneNumber)
                    .Aggregate("", (acc, cur) => acc + cur);

        if (input.Length < 10
            || input.Length > 11
            || (input.Length == 11) && (input[0] != '1'))
            throw error;

        if ((input.Length == 11) && (input[0] == '1')) input = input[1..];

        var pattern = new Regex(@"[2-9]\d{2}[2-9]\d{2}\d{4}");
        var res = pattern.IsMatch(input);
        return !res ? throw error : input;
    }
}