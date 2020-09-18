using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scores = new List<int> { 10, 30, 90, 30, 100, 20, 10, 0, 30, 40, 40, 70, 50 };
            //var sc = new HighScores(scores);
            //Print(sc.Scores());
            //Console.WriteLine(sc.Latest());
            //Console.WriteLine(sc.PersonalBest());
            //Print(sc.PersonalTopThree());
            //Print(sc.Scores());

            var (s1, s2) = ("GGACGGATTCTG", "AGGACGGATTCT");
            Console.WriteLine(Hamming.Distance(s1, s2));
        }

        static void Print(List<int> list)
        {
            foreach (int item in list) Console.Write($"{item} ");
            Console.Write("\n");
        }


        public static class Hamming
        {
            public static int Distance(string firstStrand, string secondStrand)
            {
                if (firstStrand.Length != secondStrand.Length) return -1;
                var hammingDistance = 0;
                for (int i = 0; i < firstStrand.Length; i++)
                {
                    if (firstStrand[i] != secondStrand[i]) hammingDistance++;
                }
                return hammingDistance;
            }
        }


        //public class HighScores
        //{
        //    private List<int> _list;
        //    public HighScores(List<int> list) => _list = list;

        //    public List<int> Scores() => _list;

        //    public int Latest() => _list.Last();

        //    public int PersonalBest() => _list.Max();

        //    public List<int> PersonalTopThree()
        //    {
        //        var temp = new List<int> { }; // preventing _list mutation due to sorting
        //        foreach (int item in _list) temp.Add(item);
        //        temp.Sort((a, b) => a <= b ? 1 : -1);
        //        var topScoresQuantity = temp.Count < 3 ? temp.Count : 3;
        //        return temp.GetRange(0, topScoresQuantity);
        //    }
        //}

    }
}
