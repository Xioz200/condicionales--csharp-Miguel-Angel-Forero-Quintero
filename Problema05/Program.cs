Console.Write("Primer entero: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Segundo entero: ");
int b = int.Parse(Console.ReadLine()!);

int mayor = a > b ? a : b;
Console.WriteLine($"El mayor es {mayor}");