using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _list;
    public HighScores(List<int> list) => _list = list;

    public List<int> Scores() => _list;

    public int Latest() => _list.Last();

    public int PersonalBest() => _list.Max();

    public List<int> PersonalTopThree()
    {
        var temp = new List<int> { }; // preventing _list mutation due to sorting
        foreach (int item in _list) temp.Add(item);
        temp.Sort((a, b) => a <= b ? 1 : -1);
        var topScoresQuantity = temp.Count < 3 ? temp.Count : 3;
        return temp.GetRange(0, topScoresQuantity);
    }
}