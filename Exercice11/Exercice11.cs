class Program
{

    static string Inverse(string a)
    {
        string b = "";
        for (int i = a.Length - 1; i > -1; i--)
        {

            b += a[i];
        }
        return b;

    }
    static void Main(string[] args)
    {
        Console.WriteLine(Inverse("Nathalie"));
        Console.WriteLine("");
        Console.WriteLine(Inverse("WINDOWS"));
    }


}