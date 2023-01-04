//Fonction pour convertir en binaire
string ConvertirEnBinaire(int Nombre)
{
    return Convert.ToString(Nombre, 2);
}
//Fonction pour convertir en decimal depuis un int
int ConvertirEnDecimalInt(int Nombre)
{
    return Convert.ToInt32(Nombre.ToString(), 2);
}
//Fonction pour convertir en decimal depuis un string
int ConvertirEnDecimalString(string Nombre)
{
    return Convert.ToInt32(Nombre, 2);
}

//Console.WriteLine(ConvertirEnBinaire(2));
//Console.WriteLine(ConvertirEnBinaire(8));
//Console.WriteLine(ConvertirEnBinaire(9));
//Console.WriteLine(ConvertirEnBinaire(36));
//Console.WriteLine("");
//Console.WriteLine(ConvertirEnDecimalInt(10));
//Console.WriteLine(ConvertirEnDecimalInt(1000));
//Console.WriteLine(ConvertirEnDecimalInt(1001));
//Console.WriteLine(ConvertirEnDecimalInt(100100));
//Console.WriteLine("");
//Console.WriteLine(ConvertirEnDecimalString("10"));
//Console.WriteLine(ConvertirEnDecimalString("1000"));
//Console.WriteLine(ConvertirEnDecimalString("1001"));
//Console.WriteLine(ConvertirEnDecimalString("100100"));

Console.WriteLine(ConvertirEnDecimalInt(-5));

