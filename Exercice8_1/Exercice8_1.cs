﻿class Program
{
    public static void AffichagePremier(int nb)
    {
        for (int i = 1; i <= nb; i++)
        {
            if (EstPremier(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    public static bool EstPremier(int nb)
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
    static void Main(string[] args)
    {
        AffichagePremier(100);
    }
}