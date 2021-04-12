using System;
using System.Collections.Generic;
using System.Text;

namespace ComplementarDois_GerenteFuncionario.Model
{
    class Funcionario
    {
        public string Nome { get; set; }
        private Gerente gerente;
        public Gerente Gerente
        {
            get { return this.Gerente; }
            set
            {
                if (this.gerente != null)  
                    this.gerente.Funcionarios.Remove(this);

                this.gerente = value;
                if (this.gerente != null)
                    this.gerente.Funcionarios.Add(this);
            }
        }

        public override bool Equals(Object obj)
        {
            if (obj == null) return false;

            if (obj is Gerente)
            {
                Gerente g = obj as Gerente;
                return this.Nome.Equals(g.Nome);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
        }

        public List<Funcionario> Funcionarios
        {
            get { return this.Funcionarios;  }
            set
            {
                if (value == null)
                    removerAntigosDaGerencia(this.Funcionarios);
                else
                    registrarFuncionarios(value);
            }
        }

        public void removerAntigosDaGerencia(List<Funcionario> funcionarios)
        {
            Funcionario[] funcionariosARemover = new Funcionario[funcionarios.Count];
            funcionarios.CopyTo(funcionariosARemover);
            foreach (var funcionario in funcionariosARemover)
            {
                this.removerAntigosDaGerencia(funcionarios);
            }
        }

        private void removerDaGerencia(Funcionario funcionario)
        {
            if (funcionario.Gerente != null)
            {
                funcionario.Gerente = null;
            }
        }

        private void registrarFuncionarios(List<Funcionario> funcionarios)
        {
            removerAntigosDaGerencia(this.Funcionarios);
            registrarNovosNaGerencia(funcionarios);
        }

        private void registrarNovosNaGerencia(List<Funcionario> funcionarios)
        {
            Funcionario[] funcionariosARegistrar = new Funcionario[funcionarios.Count];
            funcionarios.CopyTo(funcionariosARegistrar);
            foreach (var funcionario in funcionariosARegistrar)
            {
                this.registrarNovosNaGerencia(funcionario);
            }
        }

        private void registrarNaGerencia(Funcionario funcionario)
        {
            if (funcionario.Gerente == null || !funcionario.Gerente.Equals(this))
                funcionario.Gerente = this;
        }

        public void RegistrarFuncionario(Funcionario funcionario)
        {
            removerDaGerencia(funcionario);
            registrarNaGerencia(funcionario);
        }
    }
}
