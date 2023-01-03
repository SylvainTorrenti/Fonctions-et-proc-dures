
string Reponse(string Reponse)
{
    if (Reponse != "Oui" && Reponse != "Non")
    {
        return "Répondez par Oui ou Non";
    }
    else
    {
        return Reponse;
    }
}

string Reponse1;
Console.WriteLine("Etes vous marriez?");
Reponse1 = Console.ReadLine();
Console.WriteLine(Reponse(Reponse1));
while (Reponse1 != "Oui" && Reponse1 != "Non")
{
    Console.WriteLine("Etes vous marriez?");
    Reponse1 = Console.ReadLine();
    Console.WriteLine(Reponse(Reponse1));
}


