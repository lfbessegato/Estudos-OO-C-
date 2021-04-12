using System;
using System.Collections.Generic;
using System.Text;

namespace ComplementarDois_GerenteFuncionario.Model
{
    class Gerente
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }
}
