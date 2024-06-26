﻿public static class RepositorioFuncionarios
{
    private static readonly List<Funcionario> funcionarios = new();
    private static Funcionario[] funcionariosArray = new Funcionario[100];

    public static void CadastrarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
        funcionariosArray = funcionarios.ToArray();
        Console.WriteLine("Funcionário cadastrado com sucesso!");
    }

    public static void ListarFuncionarios()
    {
        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário cadastrado!");
            return;
        }

        foreach (var funcionario in funcionarios) Console.WriteLine(funcionario);
    }

    public static Funcionario BuscarFuncionarioPorCpf(string cpf)
    {
        return funcionarios.FirstOrDefault(f => f.Cpf == cpf);
    }

    public static void RemoverFuncionario(string cpf)
    {
        var funcionario = BuscarFuncionarioPorCpf(cpf);
        if (funcionario == null)
        {
            Console.WriteLine("Funcionário não encontrado!");
            return;
        }

        funcionarios.Remove(funcionario);
        Console.WriteLine("Funcionário removido com sucesso!");
    }

    public static void AtualizarFuncionario(string cpf)
    {
        var funcionario = BuscarFuncionarioPorCpf(cpf);
        if (funcionario == null)
        {
            Console.WriteLine("Funcionário não encontrado!");
            return;
        }

        Console.WriteLine("Digite o nome do funcionário: ");
        funcionario.Nome = Console.ReadLine();
        Console.WriteLine("Digite a função do funcionário: ");
        funcionario.Funcao = Console.ReadLine();
        Console.WriteLine("Digite a senha do funcionário: ");
        funcionario.Senha = Console.ReadLine();

        Console.WriteLine("Funcionário atualizado com sucesso!");
    }

    public static void VerificarCargoFuncionario()
    {
        Console.WriteLine("Digite o CPF do funcionário: ");
        var cpf = Console.ReadLine();
        var funcionario = BuscarFuncionarioPorCpf(cpf);
        if (funcionario == null)
        {
            Console.WriteLine("Funcionário não encontrado!");
        }
    }
}