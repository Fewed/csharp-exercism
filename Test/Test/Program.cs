using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new List<string> { "2234567890", "+1 (223) 456-7890" };

            //var array = new[] { 1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634 };
            //var value = 144;

            var array = new[] { 1, 3, 21, 5, 8 };
            var value = 21;

            //var res = Sieve.Primes(13);
            //Console.WriteLine(res);

            var whiteQueen = QueenAttack.Create(2, 4);
            var blackQueen = QueenAttack.Create(6, 6);
            Console.WriteLine(QueenAttack.CanAttack(whiteQueen, blackQueen));
        }
    }


    public class Queen
    {
        public Queen(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; }
        public int Column { get; }
    }



    public static class Bob
    {
        static bool isQuestion(string str) => str[^1] == '?';
        static bool isYell(string str) => str.ToUpper() == str;
        static bool isSilence(string str) => str == "";

        static string questionAnswer = "Sure.",
            yellAnswer = "Whoa, chill out!",
            yellQuestionAnswer = "Calm down, I know what I'm doing!",
            silenceAnswer = "Fine. Be that way!",
            defaultAnswer = "Whatever.";

        public static string Response(string statement)
        {
            if (isQuestion(statement) && !isYell(statement)) return questionAnswer;
            if (!isQuestion(statement) && isYell(statement)) return yellAnswer;
            if (isQuestion(statement) && isYell(statement)) return yellQuestionAnswer;
            if (isSilence(statement)) return silenceAnswer;
            return defaultAnswer;
        }
    }







}
