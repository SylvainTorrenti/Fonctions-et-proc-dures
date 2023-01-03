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
void TableauPremier(int Nombre)
{
    int[] TabPremier = new int[Nombre];
    for (int i = 1; i <= Nombre; i++)
    {
        if (EstPremier(i))
        {
            TabPremier[i] = i;
        }
    }
    for (int i = 0; i < TabPremier.Length; i++)
    {

        if (TabPremier[i] == 0)
        {
            Console.Write("");
        }
        else
        {
            Console.Write(TabPremier[i] + " ");
        }
    }
}

TableauPremier(100);
