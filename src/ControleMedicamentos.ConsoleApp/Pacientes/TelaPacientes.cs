using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Pacientes;

public class TelaPacientes
{
    public static void TelaPaciente()
    {
        while (true)
        {
            Console.WriteLine("Tela de Pacientes\n");
            Console.WriteLine("1 - Cadastrar Paciente");
            Console.WriteLine("2 - Listar Pacientes");
            Console.WriteLine("3 - Buscar Paciente por CPF");
            Console.WriteLine("4 - Remover Paciente");
            Console.WriteLine("5 - Atualizar Paciente");
            Console.WriteLine("6 - Voltar\n");
            Console.WriteLine("Digite a opção desejada: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    RepositorioPaciente.CadastrarPaciente();
                    break;
                case "2":
                    Console.Clear();
                    RepositorioPaciente.ListarPacientes();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Digite o CPF do paciente: ");
                    var cpf = Console.ReadLine();
                    var paciente = RepositorioPaciente.BuscarPacientePorCpf(cpf);
                    if (paciente == null)
                        Console.WriteLine("Paciente não encontrado!");
                    else
                        Console.WriteLine(paciente);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Digite o CPF do paciente: ");
                    cpf = Console.ReadLine();
                    RepositorioPaciente.RemoverPaciente(cpf);
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Digite o CPF do paciente: ");
                    cpf = Console.ReadLine();
                    RepositorioPaciente.AtualizarPaciente(cpf);
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
}