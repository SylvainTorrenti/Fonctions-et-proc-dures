class Program
{
    static void Main(string[] args)
    {
        int[] Note = { 17, 18, 19, 20, 14, 16, 15, 12, 13, 14, 11, 8, };
        for (int i = 0; i < Note.Length; i++)
        {
            Mention(Note[i]);
        }
    }
    static void Mention(int a)
    {
        if (a >= 10 && a < 12)
        {
            Console.WriteLine("La mention est Passable");
        }
        if (a >= 12 && a < 14)
        {
            Console.WriteLine("La mention est Assez Bien");
        }
        if (a >= 14 && a < 16)
        {
            Console.WriteLine("La mention est Bien");
        }
        if (a > 16)
        {
            Console.WriteLine("La mention est Très bien");
        }
        else if (a < 10)
        {
            Console.WriteLine("C'est un Echec");
        }
    }
}