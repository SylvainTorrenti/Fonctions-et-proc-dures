class Program
{
    public static void PermutationString(string str, string str2)
    {
        string Temps2;
        string Temps;
        Temps= str;
        Temps2= str2;   
        str= str2;
        str2 = Temps;
        Console.WriteLine("La nouvelle valeur de " + Temps + " est " + str);
        Console.WriteLine("La nouvelle valeur de " + Temps2 + " est " + str2);

    }

    static void Main(string[] args)
    {
        PermutationString("Bien", "Mal");
        PermutationString("coucou", "Salut");
    }
}