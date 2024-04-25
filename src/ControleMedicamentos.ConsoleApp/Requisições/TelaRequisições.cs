using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Requisições;

public class TelaRequisições
{
    public static void TelaRequisicoes()
    {
        while (true)
        {
            Console.WriteLine("Tela de Requisições\n");
            Console.WriteLine("1 - Cadastrar Requisição");
            Console.WriteLine("2 - Listar Requisições");
            Console.WriteLine("3 - Buscar Requisição por CPF");
            Console.WriteLine("4 - Remover Requisição");
            Console.WriteLine("5 - Atualizar Requisição");
            Console.WriteLine("6 - Voltar\n");
            Console.WriteLine("Digite a opção desejada: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    CadastrarRequisicao();
                    break;
                case "2":
                    Console.Clear();
                    ListarRequisições();
                    break;
                case "3":
                    Console.Clear();
                    BuscarRequisicaoPorCpf();
                    break;
                case "4":
                    Console.Clear();
                    RemoverRequisicao();
                    break;
                case "5":
                    Console.Clear();
                    AtualizarRequisicao();
                    break;
                case "6":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    private static void CadastrarRequisicao()
    {
        Console.WriteLine("Digite o nome do medicamento: ");
        var nomeMedicamento = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do medicamento: ");
        var quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o CPF do paciente: ");
        var cpf = Console.ReadLine();
        Console.WriteLine("Digite a data da requisição: ");
        var dataRequisicao = Console.ReadLine();

        var requisicao = new Requisição(nomeMedicamento, quantidade, cpf, dataRequisicao);
        RepositorioRequisição.AdicionarRequisição(requisicao);
        Console.WriteLine("Requisição cadastrada com sucesso!");
    }

    private static void ListarRequisições()
    {
        RepositorioRequisição.ListarRequisições();
    }

    private static void BuscarRequisicaoPorCpf()
    {
        Console.WriteLine("Digite o CPF do paciente: ");
        var cpf = Console.ReadLine();
        var requisicao = RepositorioRequisição.BuscarRequisiçãoPorCpf(cpf);
        if (requisicao == null)
        {
            Console.WriteLine("Requisição não encontrada!");
            return;
        }

        Console.WriteLine(requisicao);
    }

    private static void RemoverRequisicao()
    {
        Console.WriteLine("Digite o CPF do paciente: ");
        var cpf = Console.ReadLine();
        RepositorioRequisição.RemoverRequisição(cpf);
    }

    private static void AtualizarRequisicao()
    {
        Console.WriteLine("Digite o CPF do paciente: ");
        var cpf = Console.ReadLine();
        RepositorioRequisição.AtualizarRequisição(cpf);
    }
}