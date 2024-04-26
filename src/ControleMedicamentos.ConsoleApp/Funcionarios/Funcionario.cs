using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Funcao { get; set; }
        public string Senha { get; set; }

        public Funcionario(string nome, string cpf, string funcao, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Funcao = funcao;
            Senha = senha;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, CPF: {Cpf}, Função: {Funcao}";
        }
    }

    public class Gerente : Funcionario
    {
        public Gerente(string nome, string cpf, string funcao, string senha) : base(nome, cpf, funcao, senha)
        {

        }

    }
}

