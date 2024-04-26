namespace ControleMedicamentos.ConsoleApp.Requisições;

public class RepositorioRequisição
{
    private static readonly List<Requisição> requisicoes = new();
    private static Requisição[] requisicaoArray = new Requisição[100];

    public static void CadastrarRequisição(Requisição requisicao)
    {
        requisicoes.Add(requisicao);
        requisicaoArray = requisicoes.ToArray();
    }

    public static void ListarRequisições()
    {
        if (requisicoes.Count == 0)
        {
            Console.WriteLine("Nenhuma requisição cadastrada!");
            return;
        }

        foreach (var requisicao in requisicoes) Console.WriteLine(requisicao);
    }

    public static Requisição BuscarRequisiçãoPorCpf(string cpf)
    {
        return requisicoes.FirstOrDefault(r => r.Cpf == cpf);
    }

    public static void RemoverRequisição(string cpf)
    {
        var requisicao = BuscarRequisiçãoPorCpf(cpf);
        if (requisicao == null)
        {
            Console.WriteLine("Requisição não encontrada!");
            return;
        }

        requisicoes.Remove(requisicao);
        Console.WriteLine("Requisição removida com sucesso!");
    }

    public static void AtualizarRequisição(string cpf)
    {
        var requisicao = BuscarRequisiçãoPorCpf(cpf);
        if (requisicao == null)
        {
            Console.WriteLine("Requisição não encontrada!");
            return;
        }

        Console.WriteLine("Digite o nome do medicamento: ");
        var nomeMedicamento = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do medicamento: ");
        var quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a data da requisição: ");
        var dataRequisicao = Console.ReadLine();

        requisicao.NomeMedicamento = nomeMedicamento;
        requisicao.Quantidade = quantidade;
        requisicao.DataRequisicao = dataRequisicao;

        Console.WriteLine("Requisição atualizada com sucesso!");
    }
}