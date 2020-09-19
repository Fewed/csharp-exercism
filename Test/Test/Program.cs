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

            //var expected = new Dictionary<char, int>
            //{
            //    ['A'] = 20,
            //    ['C'] = 12,
            //    ['G'] = 17,
            //    ['T'] = 21
            //};
            var strand = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
            var res = NucleotideCount.Count(strand);
            Print(res);
        }

        static void Print(IDictionary<char, int> dict)
        {
            foreach (char key in dict.Keys) Console.Write($"{key}={dict[key]}, ");
            Console.Write("\n");
        }


        public static class NucleotideCount
        {
            public static IDictionary<char, int> Count(string sequence)
            {
                var result = new Dictionary<char, int>
                {
                    ['A'] = 0,
                    ['C'] = 0,
                    ['G'] = 0,
                    ['T'] = 0
                };

                foreach (char item in sequence) result[item]++;

                return result;
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
