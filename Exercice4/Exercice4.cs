﻿int[] NoteDonnee = { 17, 18, 19, 20, 14, 16, 15, 12, 13, 14, 11, 8, };
for (int i = 0; i < NoteDonnee.Length; i++)
{
    Mention(NoteDonnee[i]);
}
void Mention(int Note)
{
    if (Note >= 10 && Note < 12)
    {
        Console.WriteLine("La mention est Passable");
    }
    if (Note >= 12 && Note < 14)
    {
        Console.WriteLine("La mention est Assez Bien");
    }
    if (Note >= 14 && Note < 16)
    {
        Console.WriteLine("La mention est Bien");
    }
    if (Note > 16)
    {
        Console.WriteLine("La mention est Très bien");
    }
    else if (Note < 10)
    {
        Console.WriteLine("C'est un Echec");
    }
}
