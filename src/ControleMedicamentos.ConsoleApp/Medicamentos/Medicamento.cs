using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Medicamentos;

internal class Medicamento
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }

    public Medicamento(string nome, string descricao, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Descrição: {Descricao}, Quantidade: {Quantidade}";
    }
}