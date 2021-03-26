using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            System.Console.Write("Informe o numero do Banco: ");
            banco.Numero = System.Console.ReadLine();

            System.Console.Write("Informe o Nome do Banco: ");
           banco.Nome = System.Console.ReadLine();

            System.Console.WriteLine("===============================================================");

            var str = "Obrigado por informar os dados para o número do Banco: " + banco.Numero + " e o nome do Banco: " + banco.Nome;

            System.Console.WriteLine(str);

            System.Console.Write("Pressione qualquer tecla para encerrar.");

            System.Console.ReadKey();
        }
    }
}
