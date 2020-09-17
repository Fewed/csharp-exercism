using System;

class SpaceAge
{
    private double _seconds;
    private const double YEAR = 31557600d;

    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() => _seconds / (YEAR * 1);

    public double OnMercury() => _seconds / (YEAR * 0.2408467);

    public double OnVenus() => _seconds / (YEAR * 0.61519726);

    public double OnMars() => _seconds / (YEAR * 1.8808158);

    public double OnJupiter() => _seconds / (YEAR * 11.862615);

    public double OnSaturn() => _seconds / (YEAR * 29.447498);

    public double OnUranus() => _seconds / (YEAR * 84.016846);

    public double OnNeptune() => _seconds / (YEAR * 164.79132);
}