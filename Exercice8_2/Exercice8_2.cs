bool EstPremier(int nb)
{

    if (nb <= 3)
    {
        return true;
    }
    else
    {
        int SqrtEntier = (int)Math.Sqrt(nb);
        for (int i = 2; i <= SqrtEntier; i++)
        {
            if (nb % i == 0)
                return false;
        }
        return true;
    }
}
void TableauPremier(int nb)
{
    int[] TabPremier = new int[nb];
    for (int i = 1; i <= nb; i++)
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
