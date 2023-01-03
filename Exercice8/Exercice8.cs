//Fonction qui indique si le nombre entré en paramétre est pair ou non
bool EstPremier(int Nombre)
{
    if (Nombre <= 3)
    {
        return true;
    }
    else
    {
        int SqrtEntier = (int)Math.Sqrt(Nombre);
        for (int i = 2; i <= SqrtEntier; i++)
        {
            if (Nombre % i == 0)
                return false;
        }
        return true;
    }
}

Console.WriteLine(EstPremier(2));
Console.WriteLine(EstPremier(5));
Console.WriteLine(EstPremier(6));
Console.WriteLine(EstPremier(25));

