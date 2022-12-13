class Program
{
    static public double Carre(double a)
    {
        return a * a;
    }
    
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Carre(y2 - y1) + Carre(x2 - x1));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Calcul la distance entre deux points (5,6)-(4,3): " + Distance(5, 6, 4, 3));
        Console.WriteLine("Calcul la distance entre deux points (4,3)-(5,6): " + Distance(4, 3, 5, 6));
    }
}