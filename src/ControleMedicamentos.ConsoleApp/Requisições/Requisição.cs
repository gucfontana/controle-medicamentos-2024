using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Requisições;

public class Requisição
{
    public string NomeMedicamento { get; set; }
    public int Quantidade { get; set; }
    public string Cpf { get; set; }
    public string DataRequisicao { get; set; }

    public Requisição(string nomeMedicamento, int quantidade, string cpf, string dataRequisicao)
    {
        NomeMedicamento = nomeMedicamento;
        Quantidade = quantidade;
        Cpf = cpf;
        DataRequisicao = dataRequisicao;
    }

    public override string ToString()
    {
        return
            $"Nome do Medicamento: {NomeMedicamento}, Quantidade: {Quantidade}, CPF: {Cpf}, Data da Requisição: {DataRequisicao}";
    }
}