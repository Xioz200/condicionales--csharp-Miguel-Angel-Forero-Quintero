Console.Write("Ingrese un entero: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero > 0) Console.WriteLine("Positivo");
else if (numero < 0) Console.WriteLine("Negativo");
else Console.WriteLine("Cero");