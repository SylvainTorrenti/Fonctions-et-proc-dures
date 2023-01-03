//Fonction qui inverse la chaine de caractère  entrée en paramétre
string Inverse(string String)
{
    string Gnirts = "";
    for (int i = String.Length - 1; i > -1; i--)
    {

        Gnirts += String[i];
    }
    return Gnirts;

}
//Fonction qui verifie si la chaine de caractère  entrée en paramétre est un palindrome ou non
bool EstPalindrome(string String)
{
    if (Inverse(String) == String)
    {
        return true;
    }
    else
        return false;
}

Console.WriteLine(EstPalindrome("kayak"));
Console.WriteLine("");
Console.WriteLine(EstPalindrome("WINDOWS"));
Console.WriteLine("");
Console.WriteLine(EstPalindrome("maoam"));
