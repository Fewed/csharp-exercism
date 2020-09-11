using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        return ToRna1(nucleotide);
    }

    public static string ToRna1(string nucleotide)
    {
        var (DNA, RNA) = ("GCTA", "CGAU");
        string temp = "";
        foreach (char item in nucleotide) temp += RNA[DNA.IndexOf(item)];
        return temp;
    }

    public static string ToRna2(string nucleotide)
    {
        string temp = "";
        foreach (char item in nucleotide)
        {
            switch (item)
            {
                case 'G':
                    temp += 'C';
                    break;
                case 'C':
                    temp += 'G';
                    break;
                case 'T':
                    temp += 'A';
                    break;
                case 'A':
                    temp += 'U';
                    break;
                default:
                    break;
            }
        }
        return temp;
    }

    public static string ToRna3(string nucleotide)
    {
        var nucleo = new Dictionary<char, char> { { 'G', 'C' }, { 'C', 'G' }, { 'T', 'A' }, { 'A', 'U' } };
        string temp = "";
        foreach (char item in nucleotide) temp += nucleo[item];
        return temp;
    }
}