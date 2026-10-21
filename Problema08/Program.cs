Console.Write("Ingrese un carácter: ");
string entrada = Console.ReadLine()!.Trim().ToLower();

if (entrada.Length != 1 || entrada[0] < 'a' || entrada[0] > 'z')
    Console.WriteLine("No es una letra");
else if ("aeiou".Contains(entrada[0]))
    Console.WriteLine("Es vocal");
else
    Console.WriteLine("Es consonante");