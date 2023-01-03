//Fonction qui compresse la chaine de caractère  entré en paramétre
string Compression(string String)
{
    int Resultat = 0;
    string StringComp = "";
    for (int i = 0; i < String.Length; i++)
    {
        if (i == String.Length - 1)
        {
            if (String[i] == String[i - 1])
            {
                Resultat++;
            }
            else if (String[i] != String[i - 1])
            {
                Resultat++;
            }
            if (Resultat == 1)
            {
                StringComp += $"{String[i]}";
            }
            else
            {
                StringComp += $"{Resultat}{String[i]}";
            }
        }

        else if (String[i] == String[i + 1])
        {
            Resultat++;
        }
        else if (String[i] != String[i + 1] || String[i] != String[i - 1])
        {
            Resultat++;
            if (Resultat == 1)
            {
                StringComp += $"{String[i]}";
            }
            else
            {
                StringComp += $"{Resultat}{String[i]}";
            }

            Resultat = 0;
        }

    }

    return StringComp;

}

Console.WriteLine(Compression("aa"));
Console.WriteLine(Compression("AAAaa"));
Console.WriteLine(Compression("AAAAABBBCC"));
