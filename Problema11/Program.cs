using System;

enum EstadoSemaforo { Rojo, Amarillo, Verde }

class Program
{
    static void Main()
    {
        EstadoSemaforo estado = EstadoSemaforo.Rojo; 
        switch (estado)
        {
            case EstadoSemaforo.Rojo: Console.WriteLine("Deténgase"); break;
            case EstadoSemaforo.Amarillo: Console.WriteLine("Precaución, prepárese para detenerse"); break;
            case EstadoSemaforo.Verde: Console.WriteLine("Avance"); break;
        }
    }
}
