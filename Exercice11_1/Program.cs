class Program
{

    static string Inverse(string a)
    {
        string[] b = new string[a.Length];
        for (int i = a.Length - 1; i > -1; i--)
        {

            b[i] = Convert.ToString(a[i]);
        }
        return Convert.ToString(b);

    }
    static bool EstPalindrome(string a) // Voir pour utilisé String.Equals(string a, string b)
    {
        return Inverse(a) == a;
    }
    static void Main(string[] args)
    {
        Inverse("Bonjour");
        Console.WriteLine("");
        Inverse("WINDOWS");
    }

}