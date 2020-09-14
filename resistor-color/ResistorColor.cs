using System;

public static class ResistorColor
{
    public static int ColorCode(string color) => Array.IndexOf(Colors(), color);

    public static string[] Colors() => "Black Brown Red Orange Yellow Green Blue Violet Grey White".ToLower().Split();
}