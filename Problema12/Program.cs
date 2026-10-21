Console.Write("¿Tiene empleo? (si/no): ");
string empleo = Console.ReadLine()!.Trim().ToLower();
Console.Write("Ingreso mensual: ");
decimal ingreso = decimal.Parse(Console.ReadLine()!);

if (empleo == "si" || empleo == "sí")
{
    if (ingreso >= 2500000)
        Console.WriteLine("Crédito alto aprobado");
    else
        Console.WriteLine("Crédito básico aprobado");
}
else
{
    Console.WriteLine("Crédito rechazado");
}
