using SistemaExperto;
using System;

class Program
{
    static void Main(string[] args)
    {
        MotorDeInferencia motor = new MotorDeInferencia();

        motor.IniciarChat();

        string input = Console.ReadLine();
        motor.ResponderFase(input);

        input = Console.ReadLine();
        motor.ResponderISO(input);

        input = Console.ReadLine();
        motor.ResponderPrioridad(input);
    }
}