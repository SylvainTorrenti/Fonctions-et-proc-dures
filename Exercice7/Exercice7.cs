class Program
{
    static public int[] SommeTableau(int[] a, int[] b)
    {
        int[] c = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i] + b[i];
        }
        return c;
    }
    static void AfficherTableau(int[] Tab)
    {
        Console.Write("[ ");
        for (int i = 0; i < Tab.Length; i++)
        {
            Console.Write(Tab[i]);
            Console.Write(" ");
        }
        Console.WriteLine("]");
    }
    static void Main(string[] args)
    {
        int[] Tableau1 = { 4, 8, 7, 9, 1, 5, 4, 6 };
        int[] Tableau2 = { 7, 6, 5, 2, 1, 3, 7, 4 };
        int[] Tableau3 = new int[Tableau1.Length];
        Tableau3 = SommeTableau(Tableau1,Tableau2);
        AfficherTableau(Tableau1);
        Console.WriteLine();
        AfficherTableau(Tableau2);
        Console.WriteLine();
        AfficherTableau(Tableau3);
        
    }
}