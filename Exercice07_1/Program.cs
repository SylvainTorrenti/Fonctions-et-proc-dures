//Fonction indiquant si un nombre est pair ou non
bool EstPair(int Entier)
{
    return Entier % 2 == 0;
}

Console.WriteLine(EstPair(2));
Console.WriteLine(EstPair(3));
bool Rep = EstPair(4);
Console.WriteLine(Rep);

if (EstPair(5))
{
    Console.WriteLine("Le nombre est pair");
}
else
{
    Console.WriteLine("le nombre est impair");
}