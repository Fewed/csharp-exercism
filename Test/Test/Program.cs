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
            var ctrl = "[]{}()";
            Console.WriteLine(value);
            Console.WriteLine(MatchingBrackets.IsPaired(value));

            //var st = new MyStack('q', 'w', 'e');
            //Console.WriteLine(st.Last);
            //st.Print();
            //st.Push('r');
            //st.Print();
            //st.Pop();
            //st.Pop();
            //st.Print();
            //Console.WriteLine(st.Last);
        }


        class MyStack
        {
            List<char> stack = new List<char> { };
            public MyStack(params char[] initial)
            {
                if (initial.Length != 0)
                    foreach (var item in initial) stack.Add(item);
            }

            public void Push(char item) => stack.Add(item);

            public void Pop() => stack.RemoveAt(stack.Count - 1);

            public char Last { get => stack.ElementAt(stack.Count - 1); }

            public void Print() =>
                Console.WriteLine(stack.Aggregate("", (acc, cur) => acc + $"{cur} ").Trim());
        }

        public static class MatchingBrackets
        {
            static Dictionary<char, int> UpdateCounters(string input, Dictionary<char, int> counters)
            {
                var chars = new MyStack();
                var keys = counters.Keys.ToList();

                foreach (var item in input)
                {
                    if (keys.Contains(item))
                    {
                        var idx = keys.IndexOf(item);

                        if (idx % 2 == 0)
                        {
                            counters[item]++;
                            chars.Push(item);
                        }
                        else
                        {
                            var idxPre = keys.IndexOf(chars.Last);

                            counters[item]--;
                            if (idx - idxPre == 1) chars.Pop();
                        }
                    }
                }

                return counters;
            }

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

                return SumCounters(UpdateCounters(input, counters));
            }
        }


    }









}
