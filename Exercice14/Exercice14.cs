int Factorielle(int a)
{
    int Somme = 1;
    while (a > 0)
    {
        Somme = a * Somme;
        a = a - 1;
    }
    return Somme;
}

Console.WriteLine(Factorielle(5));
