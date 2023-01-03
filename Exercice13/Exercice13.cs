static string CodeCesar(string a, int cle)
{
    string Resultat = "";
    int Temp;
    //Parcourir le tableau de string
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == ' ')
        {
            Resultat += ' ';
        }
        else
        {
            Temp = 0;
            Temp = ((short)a[i]);//Prendre la valeur
            Temp += cle;//Lui ajouter la clé et l'ajouter à la réponse
            if ((Temp > 90 && Temp < 97) && cle > 0 || (Temp > 122))
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
