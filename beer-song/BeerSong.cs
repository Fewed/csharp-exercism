using System;
using System.Linq;

public static class BeerSong
{
    static string GetPart(int num)
    {
        var template1 = $"{num} bottles of beer on the wall, {num} bottles of beer.\n" +
        $"Take one down and pass it around, {num - 1} bottles of beer on the wall.\n\n";

        var template2 = $"2 bottles of beer on the wall, 2 bottles of beer.\n" +
        $"Take one down and pass it around, 1 bottle of beer on the wall.\n\n";

        var template3 = $"1 bottle of beer on the wall, 1 bottle of beer.\n" +
         $"Take it down and pass it around, no more bottles of beer on the wall.\n\n";

        var template4 = $"No more bottles of beer on the wall, no more bottles of beer.\n" +
         $"Go to the store and buy some more, 99 bottles of beer on the wall.\n\n";

        if (num == 2) return template2;
        if (num == 1) return template3;
        return num == 0 ? template4 : template1;
    }

    public static string Recite(int startBottles, int takeDown) =>
        Enumerable.Range(startBottles - takeDown + 1, takeDown).Reverse()
           .Aggregate("", (acc, cur) => acc + GetPart(cur)).Trim();
}