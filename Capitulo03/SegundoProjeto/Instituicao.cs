namespace SegundoProjeto
{
    class Instituicao
    {
        public string Nome { get; set; }
        public Endereco  Endereco { get; set; }

        public string Tipo { get; } = "Ensino Superior";

        public Departamento[] Departamentos { get; } = new Departamento[10];

        private int QuantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
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
