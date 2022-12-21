class Exercice11_1
{

    static string Inverse(string a)
    {
        string b = "";
        for (int i = a.Length - 1; i > -1; i--)
        {

            b += a[i];
        }
        return b ; 

    }
    static bool EstPalindrome(string a)
    {
        if (Inverse(a) == a)
        {
            return true;
        }
        else
            return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(EstPalindrome("kayak")); 
        Console.WriteLine("");
        Console.WriteLine(EstPalindrome("WINDOWS"));
        Console.WriteLine("");
        Console.WriteLine(EstPalindrome("maoam"));

    }
    
}