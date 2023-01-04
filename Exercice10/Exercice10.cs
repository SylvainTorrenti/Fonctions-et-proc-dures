string ConvertirEnBinaire(int Nombre)
{
    return Convert.ToString(Nombre, 2);

}
int ConvertirEnDecimal(int Nombre)
{

    return Convert.ToInt32(Nombre.ToString(), 2);
    //return Decimal;

}


Console.WriteLine(ConvertirEnBinaire(2));
Console.WriteLine(ConvertirEnBinaire(8));
Console.WriteLine(ConvertirEnBinaire(9));
Console.WriteLine(ConvertirEnBinaire(36));
Console.WriteLine(ConvertirEnDecimal(10));
Console.WriteLine(ConvertirEnDecimal(1000));
Console.WriteLine(ConvertirEnDecimal(1001));
Console.WriteLine(ConvertirEnDecimal(100100));

