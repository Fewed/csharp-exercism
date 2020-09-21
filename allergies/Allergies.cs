using System;
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
    private readonly byte _mask;

    public Allergies(int mask) => _mask = (byte)mask;

    public bool IsAllergicTo(Allergen allergen)
    {
        var pos = 1 << (byte)allergen;
        return (pos & _mask) == pos;
    }

    public Allergen[] List()
    {
        var keys = Enum.GetNames(typeof(Allergen));
        var vals = Enum.GetValues(typeof(Allergen)).Cast<Allergen>();

        for (var i = 0; i < keys.Length; i++)
        {
            if (!IsAllergicTo((Allergen)i))
            {
                // vals = vals.Where(item => (int)item != 0); // works
                //vals = vals.Where(item => (int)item != i); // ???
                vals = vals.Except(new Allergen[] { (Allergen)i });
            }
        }

        return vals.ToArray();
    }
}