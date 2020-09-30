using System;
using System.Collections.Generic;

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

    public CircularBuffer(int capacity) => buffer.Capacity = capacity;

    public T Read()
    {
        if (buffer.Count == 0) throw new InvalidOperationException("Buffer is empty");

        var oldest = buffer[0];
        DequeueHead();
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
        if (buffer.Count == buffer.Capacity) DequeueHead();
        Write(value);
    }

    public void DequeueHead()
    {
        if (buffer.Count == 0) return;

        var capacity = buffer.Capacity;
        buffer = buffer.GetRange(1, buffer.Count - 1);
        buffer.Capacity = capacity;
        //DisplayBuffer();
    }

    public void Clear()
    {
        if (buffer.Count == 0) return;

        buffer.RemoveRange(0, buffer.Count);
        //DisplayBuffer();
    }
}