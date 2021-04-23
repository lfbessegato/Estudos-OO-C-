using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    class Aluno
    {
        public string RegistroAcademico { get; set; }
        public string Nome { get; set; }
        public HashSet<Curso> Cursos { get; } = new HashSet<Curso>();

        public override bool Equals(object obj)
        {
            if (obj is Aluno)
            {
                Aluno a = obj as Aluno;
                return this.Nome.Equals(a.Nome);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
        }
    }
}
