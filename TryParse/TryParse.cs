bool ParseOK;
int Nombre;

do
{
    Console.WriteLine("rentrez un nombre : ");
    ParseOK = int.TryParse(Console.ReadLine(), out Nombre);
} while (ParseOK == false);
Console.WriteLine(Nombre);