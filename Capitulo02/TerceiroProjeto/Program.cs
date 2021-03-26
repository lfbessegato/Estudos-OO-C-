using System;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();

            System.Console.Write("Informe o RAIO de um circulo: ");

            circulo.Raio = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("===============================================================");

            System.Console.WriteLine("Area: " + circulo.Area());
            System.Console.WriteLine("Comprimento: " +circulo.Comprimento());

            System.Console.Write("Pressione qualquer tecla para encerrar.");

            System.Console.ReadKey();
        }
    }
}
