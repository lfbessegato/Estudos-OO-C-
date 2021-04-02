using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criando os objetos Instituição
            var iesUTFPR = new Instituicao()
            {
                Nome = "UTFPR",
                Endereco = new Endereco()
                {
                    Rua = "Brasil",
                    Numero = "1000"
                }
            };

            var iesCC = new Instituicao()
            {
                Nome = "Casa do Código",
                Endereco = new Endereco()
                {
                    Bairro = "Liberdade",

                }
            };

            // Criando os Objetos Departamentos
            var dptoEnsino = new Departamento("Computacao");
            var dptoAlimentos = new Departamento("Alimentos");
            var dptoRevisao = new Departamento("Revisão Escrita");

            // Associacao de Departamento com a Instituição
            iesUTFPR.RegistrarDepartamento(dptoEnsino);
            iesUTFPR.RegistrarDepartamento(dptoAlimentos);

            iesCC.RegistrarDepartamento(dptoRevisao);

            Console.WriteLine($"UTFPR - Endereço => { iesUTFPR.Endereco.Rua } { iesUTFPR.Endereco.Numero } { iesUTFPR.Endereco.Bairro }");
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }



            Console.WriteLine($"Casa de Código - Endereço => { iesCC.Endereco.Rua } { iesCC.Endereco.Numero } { iesCC.Endereco.Bairro }");
            for (int i = 0; i < iesCC.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesCC.Departamentos[i].Nome}");
            }

            Console.Write("Pressione qualquer tecla para continuar");

            Console.ReadKey();
        }
    }
}
