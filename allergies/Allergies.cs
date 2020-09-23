using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private readonly int _mask;

    public Allergies(int mask) => _mask = mask;

    public bool IsAllergicTo(Allergen allergen)
    {
        var pos = 1 << (int)allergen;
        return (pos & _mask) == pos;
    }

    public Allergen[] List()
    {
        var allergens = Enum.GetValues(typeof(Allergen)).Cast<Allergen>();
        var safeList = new List<Allergen> { };

        foreach (var item in allergens)
        {
            if (!IsAllergicTo(item)) safeList.Add(item);
        }

        return allergens.Except(safeList).ToArray();
    }
}