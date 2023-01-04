//Méthode qui interverti les chaines de caractère  entrées en paramétre
string PermutationString(string String1, string String2)
{
    string Temps2;
    string Temps;
    Temps = String1;
    Temps2 = String2;
    String1 = String2;
    String2 = Temps;
    return $"Les chaines permutées sont : {String1} et {String2}";;

}
Console.WriteLine("Les chaines d'origine sont : Bien et Mal");
Console.WriteLine(PermutationString("Bien", "Mal")); 


