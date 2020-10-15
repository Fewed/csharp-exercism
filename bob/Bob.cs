using System.Linq;

public static class Bob
{
    static bool isQuestion(string str) => str.EndsWith('?');
    static bool isYell(string str) => (str.ToUpper() == str) && str.Any(char.IsLetter);
    static bool isSilence(string str) => str == string.Empty;

    const string QuestionAnswer = "Sure.",
        YellAnswer = "Whoa, chill out!",
        YellQuestionAnswer = "Calm down, I know what I'm doing!",
        SilenceAnswer = "Fine. Be that way!",
        DefaultAnswer = "Whatever.";

    public static string Response(string statement)
    {
        statement = statement.Trim();
        if (isSilence(statement)) return SilenceAnswer;
        if (isQuestion(statement)) return isYell(statement) ? YellQuestionAnswer : QuestionAnswer;
        return isYell(statement) ? YellAnswer : DefaultAnswer;
    }
}