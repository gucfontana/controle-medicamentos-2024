using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Pacientes;

public class Paciente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string DataNascimento { get; set; }

    public Paciente(string nome, string cpf, string dataNascimento)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, CPF: {Cpf}, Data de Nascimento: {DataNascimento}";
    }
}