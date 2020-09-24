using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

public class GradeSchool
{
    List<(string student, int grade)> _list = new List<(string student, int grade)> { };

    public void Add(string student, int grade) => _list.Add((student, grade));

    public IEnumerable<string> Roster()
    {
        var temp = _list.ToList();
        temp.Sort((a, b) => a.student.CompareTo(b.student));
        temp.Sort((a, b) => a.grade.CompareTo(b.grade));
        return temp.Select(item => item.student);
    }

    public IEnumerable<string> Grade(int grade)
    {
        var temp = _list.ToList();
        temp.Sort((a, b) => a.student.CompareTo(b.student));
        return temp.Where(item => item.grade == grade).Select(item => item.student);
        // can we use in C# something like javascript parameters desctructuring ?
        // Select(({student}) => student)
    }
}