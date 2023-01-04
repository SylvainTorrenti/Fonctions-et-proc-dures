int[] NoteDonnee = { 17, 18, 19, 20, 14, 16, 15, 12, 13, 14, 11, 8, };
for (int i = 0; i < NoteDonnee.Length; i++) //Parcours le tableau
{
    Console.WriteLine(Mention(NoteDonnee[i]));
}
//méthode qui affiche la mention en fonction de la note entrée en paramétre
string Mention(int Note)
{
    if (Note >= 10 && Note < 12)
    {
        return "La mention est Passable";
    }
    if (Note >= 12 && Note < 14)
    {
        return "La mention est Assez Bien";
    }
    if (Note >= 14 && Note < 16)
    {
        return "La mention est Bien";
    }
    if (Note >= 16)
    {
        return "La mention est Très bien";
    }

    return "C'est un Echec";

}
