string Inverse(string String)
{
    string Gnirts = "";
    for (int i = String.Length - 1; i > -1; i--)
    {

        Gnirts += String[i];
    }
    return Gnirts;

}
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
