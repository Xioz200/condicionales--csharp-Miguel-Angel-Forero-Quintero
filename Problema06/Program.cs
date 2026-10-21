Console.Write("Saque 1 (piedra/papel/tijera): ");
string j1 = Console.ReadLine()!.Trim().ToLower();
Console.Write("Saque 2 (piedra/papel/tijera): ");
string j2 = Console.ReadLine()!.Trim().ToLower();

bool valida1 = j1 == "piedra" || j1 == "papel" || j1 == "tijera";
bool valida2 = j2 == "piedra" || j2 == "papel" || j2 == "tijera";

if (!valida1 || !valida2)
    Console.WriteLine("Jugada no válida");
else if (j1 == j2)
    Console.WriteLine("Empate");
else if ((j1 == "piedra" && j2 == "tijera") ||
         (j1 == "tijera" && j2 == "papel") ||
         (j1 == "papel" && j2 == "piedra"))
    Console.WriteLine("Gana el jugador 1");
else
    Console.WriteLine("Gana el jugador 2");
