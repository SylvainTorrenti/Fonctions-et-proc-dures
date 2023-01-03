EstPair(4);
EstPair(5);
EstPair(6);
EstPair(7);
EstPair(8);
//Fonction booléenne qui indique si l'entier entré en paramétre est pair ou non
bool EstPair(int Entier)
{
    if (Entier % 2 == 0)
    {
        Console.WriteLine("True");
        return true;
    }
    else
    {
        Console.WriteLine("False");
        return false;
    }
}
