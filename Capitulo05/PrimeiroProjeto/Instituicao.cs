namespace PrimeiroProjeto
{
    class Instituicao
    {
        public string Nome { get; set; }
        public Endereco  Endereco { get; set; }

        public string Tipo { get; } = "Ensino Superior";

        public Departamento[] Departamentos { get; } = new Departamento[10];

        private int QuantidadeDepartamentos = 0;

        public void RegistrarDepartamento(string nome)
        {
            AddDepartamento(new Departamento() { Nome = nome });
        }

        public void RegistrarDepartamento(Departamento d)
        {
            AddDepartamento(d);
        }
        public void AddDepartamento(Departamento d)
        {
            if (QuantidadeDepartamentos < 10)
                Departamentos[QuantidadeDepartamentos++] = d;
        }

        public int ObterQuantidadeDepartamentos()
        {
            return QuantidadeDepartamentos;
        }
    }
}
