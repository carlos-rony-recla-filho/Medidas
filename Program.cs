using System;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Double metros = 0;
            Double cm = 0;
            Double km = 0;

            Console.WriteLine("Bem-vindo ao conversorde metros em Km e Cm");
            
            Console.Write("\n");
            
            Console.Write("Digite a medida em metros: ");
            metros = Int32.Parse(Console.ReadLine());

            cm = metros * 100;
            km = metros / 1000;
            
            Console.WriteLine($"--- Equivalência ---\n {cm} cm \n {metros} m \n {km} km");
        }

    }
}
