using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando os objetos Instituição
            var iesUTFPR = new Instituicao();
            iesUTFPR.Nome = "UTFPR";
            iesUTFPR.Endereco = "Medianeira";

            var iesCC = new Instituicao();

            iesCC.Nome = "Casa do Código";
            iesCC.Endereco = "São Paulo";

            // Criando os Objetos Departamentos
            var dptoEnsino = new Departamento("Computacao");
            var dptoAlimentos = new Departamento("Alimentos");
            var dptoRevisao = new Departamento("Revisão Escrita");

            // Associacao de Departamento com a Instituição
            iesUTFPR.RegistrarDepartamento(dptoEnsino);
            iesUTFPR.RegistrarDepartamento(dptoAlimentos);

            iesCC.RegistrarDepartamento(dptoRevisao);

            Console.WriteLine("UTFPR");
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }

            Console.WriteLine("Casa de Código");
            for (int i = 0; i < iesCC.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}");
            }

            Console.Write("Pressione qualquer tecla para continuar");

            Console.ReadKey();
        }
    }
}
