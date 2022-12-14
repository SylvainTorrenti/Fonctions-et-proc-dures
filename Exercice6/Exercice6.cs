class Program
{
    static public string Reponse(string a)
    {
        if (a != "Oui" && a != "Non")
        {
            return "Répondez par Oui ou Non";
        }
        else
        {
            return a;
        }


    }

    static void Main(string[] args)
    {
        string reponse;
        Console.WriteLine("Etes vous marriez?");
        reponse = Console.ReadLine();
        Console.WriteLine(Reponse(reponse));
        while (reponse != "Oui" && reponse != "Non")
        {
            Console.WriteLine("Etes vous marriez?");
            reponse = Console.ReadLine();
            Console.WriteLine(Reponse(reponse));
        }

    }
}