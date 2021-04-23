using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso de coleções

            var dptoAlimentos = new Departamento();
            dptoAlimentos.RegistrarCurso(new Graduacao { Nome = "Tecnologia em Alimentos", CargaHoraria = 2000 });

            dptoAlimentos.RegistrarCurso(new Graduacao { Nome = "Engenharia de Alimentos", CargaHoraria = 3000 });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cursos no departamento de {dptoAlimentos.Nome}");

            foreach (var curso in dptoAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.CargaHoraria}h)");
            }

            Console.WriteLine();
            var cursoCC = new Graduacao() { Nome = "Ciência da Computação", CargaHoraria = 3000 };
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

            var graduacao = new Graduacao() { Nome = "Curso de Graduação" };
            var latoSensu = new LatoSensu() { Nome = "Curso de latoSensu" };
            var strictoSenso = new StrictoSensu() { Nome = "Curso de Stricto" };

            var repositorioCursos = new RepositorioCurso();
            repositorioCursos.Gravar(graduacao);
            repositorioCursos.Gravar(latoSensu);
            repositorioCursos.Gravar(strictoSenso);

            Console.WriteLine();
            Console.WriteLine("Cursos gravados");
            foreach (var curso in repositorioCursos.ObterTodos())
            {
                Console.WriteLine($"==> {curso.Nome} ({curso.GetType()})");
            }

            var aluno = new Aluno()
            {
                RegistroAcademico = "1",
                Nome = "Asdrubal"
            };
            var turma = new Turma()
            {
                CodigoTurma = "1",
                PeriodoCurso = PeriodoCursoEnum.Primeiro,
                TurnoTurma = TurnoTurmaEnum.Matutino
            };
            
            cursoCC.RegistrarAluno(aluno);
            cursoCC.RegistrarTurma(turma);

            foreach (var d in cursoCC.Disciplinas)
            {
                try
                {
                    turma.RegistrarMatricula(new Matricula()
                    {
                        Aluno = aluno,
                        Disciplina = d
                    });
                } catch (Exception exception)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(exception.Message);
                }
            }

            Console.WriteLine("Registro de matrículas concluído");
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
