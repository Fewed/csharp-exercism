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

    public static class QueenAttack
    {
        public static bool CanAttack(Queen white, Queen black)
        {
            var cond1 = white.Row == black.Row;
            var cond2 = white.Column == black.Column;
            var cond3 = (white.Row - black.Row) == (white.Column - black.Column);
            return cond1 || cond2 || cond3;
        }

        public static Queen Create(int row, int column) => new Queen(row, column);
    }


    //var whiteQueen = QueenAttack.Create(2, 4);
    //var blackQueen = QueenAttack.Create(6, 6);
    //Assert.False(QueenAttack.CanAttack(whiteQueen, blackQueen));








}
