using ControleMedicamentos.ConsoleApp.Medicamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Pacientes;

public class RepositorioPaciente
{
    private static List<Paciente> pacientes = new();
    private static Paciente[] pacientesArray = new Paciente[100];

    public static void CadastrarPaciente(Paciente paciente)
    {
        pacientes.Add(paciente);
        pacientesArray = pacientes.ToArray();
    }

    public static void CadastrarPaciente()
    {
        Console.WriteLine("Digite o nome do paciente: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF do paciente: ");
        var cpf = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento do paciente: ");
        var dataNascimento = Console.ReadLine();

        var paciente = new Paciente(nome, cpf, dataNascimento);
        pacientes.Add(paciente);
        Console.WriteLine("Paciente cadastrado com sucesso!");
    }

    public static void ListarPacientes()
    {
        if (pacientes.Count == 0)
        {
            Console.WriteLine("Nenhum paciente cadastrado!");
            return;
        }

        foreach (var paciente in pacientes) Console.WriteLine(paciente);
    }

    public static Paciente BuscarPacientePorCpf(string cpf)
    {
        return pacientes.FirstOrDefault(p => p.Cpf == cpf);
    }

    public static void RemoverPaciente(string cpf)
    {
        var paciente = BuscarPacientePorCpf(cpf);
        if (paciente == null)
        {
            Console.WriteLine("Paciente não encontrado!");
            return;
        }

        pacientes.Remove(paciente);
        Console.WriteLine("Paciente removido com sucesso!");
    }

    public static void AtualizarPaciente(string cpf)
    {
        var paciente = BuscarPacientePorCpf(cpf);
        if (paciente == null)
        {
            Console.WriteLine("Paciente não encontrado!");
            return;
        }

        Console.WriteLine("Digite o novo nome do paciente: ");
        paciente.Nome = Console.ReadLine();
        Console.WriteLine("Digite o novo CPF do paciente: ");
        paciente.Cpf = Console.ReadLine();
        Console.WriteLine("Digite a nova data de nascimento do paciente: ");
        paciente.DataNascimento = Console.ReadLine();
        Console.WriteLine("Paciente atualizado com sucesso!");
    }
}