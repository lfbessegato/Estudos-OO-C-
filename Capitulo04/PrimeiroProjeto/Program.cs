using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Exemplo de uso de coleções
            
            var dptoAlimentos = new Departamento();
            dptoAlimentos.RegistrarCurso(new Curso { Nome = "Tecnologia em Alimentos", CargaHoraria = 2000 });

            dptoAlimentos.RegistrarCurso(new Curso { Nome = "Engenharia de Alimentos", CargaHoraria = 3000 });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cursos no departamento de {dptoAlimentos.Nome}");

            foreach(var curso in dptoAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.CargaHoraria}h)");
            }

            // Chamada a função para fechar o departamento
            dptoAlimentos.FecharDepartamento();
            dptoAlimentos = null;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O departamento de alimentos foi fechado");
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
