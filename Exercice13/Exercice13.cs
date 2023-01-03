static string CodeCesar(string String, int Cle)
{
    string Resultat = "";
    int Temp;
    //Parcourir le tableau de string
    for (int i = 0; i < String.Length; i++)
    {
        if (String[i] == ' ')
        {
            Resultat += ' ';
        }
        else
        {
            Temp = 0;
            Temp = ((short)String[i]);//Prendre la valeur
            Temp += Cle;//Lui ajouter la clé et l'ajouter à la réponse
            if ((Temp > 90 && Temp < 97) && Cle > 0 || (Temp > 122))
            {
                Temp -= 26;
            }
            else if ((Temp > 90 && Temp < 97) || (Temp < 65))
            {
                Temp += 26;
            }
            Resultat += ((char)Temp);

        }

    }
    return Resultat;
}


Console.WriteLine(CodeCesar("Bonjour je suis Sylvain", 6));
