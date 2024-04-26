﻿using ControleMedicamentos.ConsoleApp.Funcionarios;
using ControleMedicamentos.ConsoleApp.Medicamentos;

public class RepositorioFuncionarios
{
    private static List<Funcionario> funcionarios = new();
    private static Funcionario[] funcionariosArray = new Funcionario[0];

    public static void CadastrarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
        funcionariosArray = funcionarios.ToArray();
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
        var nome = Console.ReadLine();
        Console.WriteLine("Digite a função do funcionário: ");
        var funcao = Console.ReadLine();
        Console.WriteLine("Digite a senha do funcionário: ");
        var senha = Console.ReadLine();
        Console.WriteLine("Digite a data de admissão (DD/MM/AAAA): ");
        var dataAdmissao = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Digite o salário: ");
        var salario = decimal.Parse(Console.ReadLine());

        funcionario.Nome = nome;
        funcionario.Funcao = funcao;
        funcionario.Senha = senha;

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
            return;
        }
    }
}