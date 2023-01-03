﻿string Compression(string a)
{
    int Resultat = 0;
    string Comp = "";
    for (int i = 0; i < a.Length; i++)
    {
        if (i == a.Length - 1)
        {
            if (a[i] == a[i - 1])
            {
                Resultat++;
            }
            else if (a[i] != a[i - 1])
            {
                Resultat++;
            }
            if (Resultat == 1)
            {
                Comp += $"{a[i]}";
            }
            else
            {
                Comp += $"{Resultat}{a[i]}";
            }
        }

        else if (a[i] == a[i + 1])
        {
            Resultat++;
        }
        else if (a[i] != a[i + 1] || a[i] != a[i - 1])
        {
            Resultat++;
            if (Resultat == 1)
            {
                Comp += $"{a[i]}";
            }
            else
            {
                Comp += $"{Resultat}{a[i]}";
            }

            Resultat = 0;
        }

    }

    return Comp;

}

Console.WriteLine(Compression("aa"));
Console.WriteLine(Compression("AAAaa"));
Console.WriteLine(Compression("AAAAABBBCC"));
