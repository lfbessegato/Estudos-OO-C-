using System;

namespace Modelo
{
    public class Disciplina
    {
        public long? DisciplinaID { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public override bool Equals(Object obj)
        {
            if (obj is Disciplina)
            {
                Disciplina d = obj as Disciplina;
                return this.DisciplinaID.Equals(d.DisciplinaID);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.DisciplinaID == null ? 0 : this.DisciplinaID.GetHashCode());
        }
    }
}
