//Méthode qui affiche tout les nombre premier inferieur au nombre entré en paramétre 
void AffichagePremier(int Nombre)
{
    for (int i = 1; i <= Nombre; i++)
    {
        if (EstPremier(i))
        {
            Console.WriteLine(i);
        }
    }
}
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

AffichagePremier(100);

