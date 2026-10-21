Console.Write("Código de país: ");
string codigo = Console.ReadLine()!.Trim().ToUpper();

string pais = codigo switch
{
    "CO" => "Colombia",
    "MX" => "México",
    "AR" => "Argentina",
    "PE" => "Perú",
    "CL" => "Chile",
    _ => "País no registrado"
};
Console.WriteLine(pais);
