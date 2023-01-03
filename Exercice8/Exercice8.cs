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

Console.WriteLine(EstPremier(2));
Console.WriteLine(EstPremier(5));
Console.WriteLine(EstPremier(6));
Console.WriteLine(EstPremier(25));

