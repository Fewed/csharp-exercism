using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        var cond1 = white.Row == black.Row;
        var cond2 = white.Column == black.Column;
        var cond3 = Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column);
        return cond1 || cond2 || cond3;
    }

    public static Queen Create(int row, int column) =>
        !(row >= 0 && row <= 7 && column >= 0 && column <= 7)
            ? throw new ArgumentOutOfRangeException("Out of range!")
            : new Queen(row, column);
}