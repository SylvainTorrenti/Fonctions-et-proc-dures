class Program
{
    static void Main(string[] args)
    {
        EstPair(4);
        EstPair(5);
        EstPair(6);
        EstPair(7);
        EstPair(8);
    }
    static bool EstPair(int a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("True");
            return true;
        }
        else
        {
            Console.WriteLine("False");
            return false;
        }
    }
}