using System;

public static class Triangle
{
    static bool isTriangle(double side1, double side2, double side3)
    {
        var cond1 = (side1 > 0) && (side2 > 0) && (side3 > 0);
        var cond2 = (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        return cond1 && cond2;
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        var cond1 = (side1 != side2) && (side1 != side3) && (side2 != side3);
        return isTriangle(side1, side2, side3) && cond1;
    }

    public static bool IsIsosceles(double side1, double side2, double side3)
    {
        var cond1 = (side1 == side2) || (side1 == side3) || (side2 == side3);
        return isTriangle(side1, side2, side3) && cond1;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        var cond1 = (side1 == side2) && (side1 == side3);
        return isTriangle(side1, side2, side3) && cond1;
    }
}