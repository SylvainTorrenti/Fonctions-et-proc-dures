string Inverse(string String)
{
    string Gnirts = "";
    for (int i = String.Length - 1; i > -1; i--)
    {

        Gnirts += String[i];
    }
    return Gnirts;

}

Console.WriteLine(Inverse("Nathalie"));
Console.WriteLine("");
Console.WriteLine(Inverse("WINDOWS"));



