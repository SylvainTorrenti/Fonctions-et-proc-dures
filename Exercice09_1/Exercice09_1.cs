string PermutationInt(int Entier1, int Entier2)
{
    int Temps = Entier1;
    Entier1 = Entier2;
    Entier2 = Temps;
    return $"Les chaines permutées sont : {Entier1} et {Entier2}";
}
void Permute(ref int Entier1, ref int Entier2)
{
    int Temps = Entier1;
    Entier1 = Entier2;
    Entier2 = Temps;
}

int Nombre1 = 1;
int Nombre2 = 2;
Console.WriteLine($"Les chaines d'origine sont : {Nombre1} et {Nombre2}");
Console.WriteLine(PermutationInt(Nombre1, Nombre2));

int Nombre3 = 3;
int Nombre4 = 4;
Console.WriteLine($"Les chaines d'origine sont : {Nombre3} et {Nombre4}");
Permute(ref Nombre3, ref Nombre4);
Console.WriteLine($"Les chaines d'origine sont : {Nombre3} et {Nombre4}");



