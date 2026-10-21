Console.Write("Ingrese el año: ");
int año = int.Parse(Console.ReadLine()!);

if (año % 400 == 0 || (año % 4 == 0 && año % 100 != 0))
    Console.WriteLine("Bisiesto");
else
    Console.WriteLine("No bisiesto");