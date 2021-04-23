using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiroProjeto
{
    class Disciplina
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj is Disciplina)
            {
                Disciplina d = obj as Disciplina;
                return this.Nome.Equals(d.Nome);
            }
            return false;
        }

        public override int GetHashCode()
        {
            
            return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
        }

        public HashSet<Disciplina> Disciplinas { get; } = new HashSet<Disciplina>();

        public void RegistrarDisciplina(Disciplina d)
        {
            Disciplinas.Add(d);
        }

        public int ObterQuantidadeDisciplinasDoCurso()
        {
            return Disciplinas.Count;
        }

        public Disciplina ObterDisciplinaPorNome(string nome)
        {
            return Disciplinas.Where<Disciplina>(n => n.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}
