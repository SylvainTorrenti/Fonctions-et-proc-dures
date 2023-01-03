//Méthode qui interverti les chaines de caractère  entrées en paramétre
void PermutationString(string String1, string String2)
{
    string Temps2;
    string Temps;
    Temps = String1;
    Temps2 = String2;
    String1 = String2;
    String2 = Temps;
    Console.WriteLine($"La nouvelle valeur de { Temps} est {String1}");
    Console.WriteLine($"La nouvelle valeur de  { Temps2}  est { String2}");

}

PermutationString("Bien", "Mal");
PermutationString("coucou", "Salut");

