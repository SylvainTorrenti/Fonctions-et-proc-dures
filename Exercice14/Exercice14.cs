//Fonction qui calcule la factorielle d'un nombre entré en paramétre
int Factorielle(int Nombre)
{
    int Somme = 1;
    while (Nombre > 0)
    {
        Somme = Nombre * Somme;
        Nombre = Nombre - 1;
    }
    return Somme;
}

Console.WriteLine(Factorielle(5));
