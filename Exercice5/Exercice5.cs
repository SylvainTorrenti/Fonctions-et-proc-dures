double Carre(double Coordonee)
{
    return Coordonee * Coordonee;
}

double Distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Carre(y2 - y1) + Carre(x2 - x1));
}

Console.WriteLine("Calcul la distance entre deux points (5,6)-(4,3): " + Distance(5, 6, 4, 3));
Console.WriteLine("Calcul la distance entre deux points (4,3)-(5,6): " + Distance(4, 3, 5, 6));
