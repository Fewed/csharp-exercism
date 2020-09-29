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
            var test = new List<string> { "2234567890", "+1 (223) 456-7890" };
            //var res = test.Select(PhoneNumber.Clean);
            //foreach (var item in res) Console.Write($"{item} ");

            var b = new CircularBuffer<int>(5);

            b.Write(1);
            b.Write(2);

            b.Write(3);
            b.Write(4);
            b.Write(5);

            b.Read();
            b.Write(6);
            //b.Overwrite(6);
        }




        public class CircularBuffer<T>
        {
            List<T> buffer = new List<T> { };

            //public void DisplayBuffer()
            //{
            //    var temp = "";

            //    for (var i = 0; i < buffer.Capacity; i++)
            //    {
            //        var element = i < buffer.Count ? buffer[i].ToString() : "-";
            //        temp += $"[{element}] ";
            //    }

            //    Console.WriteLine(temp);
            //}

            public CircularBuffer(int capacity)
            {
                buffer.Capacity = capacity;
                //DisplayBuffer();
            }


            public T Read()
            {
                if (buffer.Count == 0) throw new InvalidOperationException("Buffer is empty");

                var oldest = buffer[0];
                Clear();
                return oldest;
            }

            public void Write(T value)
            {
                if (buffer.Count == buffer.Capacity) throw new InvalidOperationException("Buffer overflow!");

                buffer.Add(value);
                //DisplayBuffer();
            }

            public void Overwrite(T value)
            {
                if (buffer.Count == buffer.Capacity) Clear();
                Write(value);
            }

            public void Clear()
            {
                if (buffer.Count == 0) return;

                buffer = buffer.GetRange(1, buffer.Count - 1);
                buffer.Capacity++;
                //DisplayBuffer();
            }
        }

    }
}
