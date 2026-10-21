Console.Write("Peso en kg: ");
double peso = double.Parse(Console.ReadLine()!);
Console.Write("Estatura en metros: ");
double estatura = double.Parse(Console.ReadLine()!);

if (peso <= 0 || estatura <= 0)
{
    Console.WriteLine("Peso o estatura inválidos");
}
else
{
    double imc = peso / (estatura * estatura);
    string categoria = imc < 18.5 ? "Bajo peso" :
                       imc < 25 ? "Peso normal" :
                       imc < 30 ? "Sobrepeso" : "Obesidad";
    Console.WriteLine($"IMC: {imc:F1} - {categoria}");
}
