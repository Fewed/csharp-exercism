using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            var value = "([{}({}[])])";
            Console.WriteLine(value);
            Console.WriteLine(MatchingBrackets.IsPaired(value));

            //var st = new MyStack(new List<char> { 'q', 'w', 'e' });
            //Console.WriteLine(st.Last);
            //st.Print();
            //st.Push('r');
            //st.Print();
            //st.Pop();
            //st.Pop();
            //st.Print();
            //Console.WriteLine(st.Last);
        }


        public class MyStack
        {
            List<char> stack;
            public MyStack(List<char> initial) => stack = initial;

            public void Push(char item) => stack.Add(item);

            public void Pop() => stack.RemoveAt(stack.Count - 1);

            public char Last { get => stack.ElementAt(stack.Count - 1); }

            public void Print()
            {
                var res = "";
                foreach (var item in stack) res += $"{item} ";
                res = res.Trim()[..^1];
                Console.WriteLine(res);
            }

        }

        public static class MatchingBrackets
        {
            static bool SumCounters(Dictionary<char, int> dict)
            {
                var values = dict.Values.ToArray();
                for (var i = 0; i < values.Length; i += 2)
                {
                    if (values[i] + values[i + 1] != 0) return false;
                }
                return true;
            }

            public static bool IsPaired(string input)
            {
                var counters = new Dictionary<char, int>
                {
                    {'[', 0},
                    {']', 0},

                    {'{', 0},
                    {'}', 0},

                    {'(', 0},
                    {')', 0},
                };

                var chars = new MyStack(new List<char> { });
                chars.Push('"');
                var keys = counters.Keys.ToList();

                foreach (var item in input)
                {
                    if (counters.ContainsKey(item))
                    {
                        var idx = keys.IndexOf(item);
                        var lc = chars.Last;
                        var idxPre = keys.IndexOf(lc);

                        Console.WriteLine("----------------------------------");
                        Console.WriteLine($"lc {lc}");
                        Console.WriteLine($"idxpre-idx {idxPre} - {idx}");

                        chars.Print();

                        if (idx % 2 == 0)
                        {
                            counters[item]++;
                            chars.Push(item);
                        }
                        else
                        {

                            if (idxPre - idx == 1)
                            {
                                counters[item]--;
                                chars.Pop();
                            }
                            else chars.Push(item);
                        }

                        //Console.WriteLine($"{chars.Count} {chars.ElementAt(chars.Count-1)}");
                    }
                }

                return SumCounters(counters);
            }
        }


    }









}
