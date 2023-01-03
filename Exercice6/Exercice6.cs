
string Reponse(string a)
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


