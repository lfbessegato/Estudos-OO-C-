using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            var cursoCC = new Curso() { Nome = "Ciência da Computação", CargaHoraria = 3000 };
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Algoritmos", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 60 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação a Objetos", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Estrutura de Dados", CargaHoraria = 80 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Programação para a Web", CargaHoraria = 80 });

            Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas: ");
            foreach (var d in cursoCC.Disciplinas)
            {
                Console.WriteLine($"==> {d.Nome} ({d.CargaHoraria})");
            }
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
