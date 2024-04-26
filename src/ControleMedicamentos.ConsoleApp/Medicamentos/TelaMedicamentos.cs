using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Medicamentos;

internal class TelaMedicamentos
{
    public static void TelaCadastroMedicamentos()
    {
        Console.WriteLine("Cadastro de Medicamentos\n");
        Console.WriteLine("1 - Cadastrar Medicamento");
        Console.WriteLine("2 - Atualizar Medicamento");
        Console.WriteLine("3 - Excluir Medicamento");
        Console.WriteLine("4 - Listar Medicamentos");
        Console.WriteLine("5 - Voltar\n");
        Console.WriteLine("Digite a opção desejada: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                ConsoleClear();
                CadastrarMedicamento();
                break;
            case "2":
                ConsoleClear();
                AtualizarMedicamento();
                break;
            case "3":
                ConsoleClear();
                ExcluirMedicamento();
                break;
            case "4":
                ConsoleClear();
                ListarMedicamentos();
                break;
            case "5":
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    private static void CadastrarMedicamento()
    {
        Console.WriteLine("Digite o nome do medicamento: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite a descrição do medicamento: ");
        var descrição = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do medicamento: ");
        var quantidade = int.Parse(Console.ReadLine());

        var medicamento = new Medicamento(nome, descrição, quantidade);
        RepositorioMedicamentos.CadastrarMedicamento(medicamento);
    }

    private static void AtualizarMedicamento()
    {
        Console.WriteLine("Digite o nome do medicamento: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite a descrição do medicamento: ");
        var descrição = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do medicamento: ");
        var quantidade = int.Parse(Console.ReadLine());

        var medicamento = new Medicamento(nome, descrição, quantidade);
        RepositorioMedicamentos.AtualizarMedicamento(medicamento);
    }

    private static void ExcluirMedicamento()
    {
        Console.WriteLine("Digite o nome do medicamento: ");
        var nome = Console.ReadLine();
        RepositorioMedicamentos.ExcluirMedicamento(nome);
    }

    private static void ListarMedicamentos()
    {
        var medicamentos = RepositorioMedicamentos.ListarMedicamentos();
        foreach (var medicamento in medicamentos)
            Console.WriteLine(
                $"Nome: {medicamento.Nome} - Descrição: {medicamento.Descricao} - Quantidade: {medicamento.Quantidade}");

        Console.WriteLine($"\nTotal de medicamentos cadastrados: {medicamentos.Count}");

        var totalMedicamentosEstoque = medicamentos.Sum(m => m.Quantidade);
        Console.WriteLine($"Total de medicamentos em estoque: {totalMedicamentosEstoque}");

        var medicamentoMaiorQuantidade = medicamentos.OrderByDescending(m => m.Quantidade).FirstOrDefault();
        Console.WriteLine(
            $"Medicamento com a maior quantidade em estoque: {medicamentoMaiorQuantidade.Nome} - Quantidade: {medicamentoMaiorQuantidade.Quantidade}");

        var medicamentoMenorQuantidade = medicamentos.OrderBy(m => m.Quantidade).FirstOrDefault();
        Console.WriteLine(
            $"Medicamento com a menor quantidade em estoque: {medicamentoMenorQuantidade.Nome} - Quantidade: {medicamentoMenorQuantidade.Quantidade}");
    }

    private static void ConsoleClear()
    {
        Console.Clear();
    }
}