using System;

public static class Bob
{
    static bool isQuestion(string str) => str[^1] == '?';
    static bool isYell(string str) => (str.ToUpper() == str) && (str.ToLower() != str);
    static bool isSilence(string str) => str == "";

    static string questionAnswer = "Sure.",
        yellAnswer = "Whoa, chill out!",
        yellQuestionAnswer = "Calm down, I know what I'm doing!",
        silenceAnswer = "Fine. Be that way!",
        defaultAnswer = "Whatever.";

    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (isSilence(statement)) return silenceAnswer;
        if (isQuestion(statement) && !isYell(statement)) return questionAnswer;
        if (!isQuestion(statement) && isYell(statement)) return yellAnswer;
        if (isQuestion(statement) && isYell(statement)) return yellQuestionAnswer;
        return defaultAnswer;
    }
}