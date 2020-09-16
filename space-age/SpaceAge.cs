using System;

class SpaceAge
{
    private double _seconds;
    private double _k = 31557600;

    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() => _seconds / (_k * 1);

    public double OnMercury() => _seconds / (_k * 0.2408467);

    public double OnVenus() => _seconds / (_k * 0.61519726);

    public double OnMars() => _seconds / (_k * 1.8808158);

    public double OnJupiter() => _seconds / (_k * 11.862615);

    public double OnSaturn() => _seconds / (_k * 29.447498);

    public double OnUranus() => _seconds / (_k * 84.016846);

    public double OnNeptune() => _seconds / (_k * 164.79132);
}