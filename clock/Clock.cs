using System;

public class Clock : IEquatable<Clock>
{
    int hours = 0,
        minutes = 0;

    (int, int) UpdateTime(int extraHrs = 0, int extraMins = 0)
    {
        var hrs = hours + extraHrs;
        var mins = minutes + extraMins;
        var temp = (mins + 60 * hrs) % (24 * 60);
        if (temp < 0) temp += 24 * 60;
        hrs = (temp / 60) % 24;
        mins = (temp - 60 * hrs) % 60;
        return (hrs, mins);
    }

    public Clock(int hours, int minutes) => (this.hours, this.minutes) = UpdateTime(hours, minutes);


    public Clock Add(int minutesToAdd)
    {
        var (hrs, mins) = UpdateTime(extraMins: minutesToAdd);
        return new Clock(hrs, mins);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        var (hrs, mins) = UpdateTime(extraMins: -minutesToSubtract);
        return new Clock(hrs, mins);
    }

    public bool Equals(Clock clock) => (clock.hours == hours) && (clock.minutes == minutes);

    public override string ToString() => $"{hours:D2}:{minutes:D2}";
}