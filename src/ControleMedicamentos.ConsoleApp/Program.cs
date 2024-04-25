using System;
using ControleMedicamentos.ConsoleApp.Medicamentos;
using ControleMedicamentos.ConsoleApp.Pacientes;
using ControleMedicamentos.ConsoleApp.Requisições;

namespace ControleMedicamentos.ConsoleApp;

internal class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao Controle de Medicamentos dos Postos de Saúde de Lages\n");
            Console.WriteLine("1 - Tela de Medicamentos");
            Console.WriteLine("2 - Tela de Pacientes");
            Console.WriteLine("3 - Tela de Requisições");
            Console.WriteLine("4 - Sair\n");
            Console.WriteLine("Digite a opção desejada: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    TelaMedicamentos.TelaCadastroMedicamentos();
                    break;
                case "2":
                    Console.Clear();
                    TelaPacientes.TelaPaciente();
                    break;
                case "3":
                    Console.Clear();
                    TelaRequisições.TelaRequisicoes();
                    break;
                case "4":
                    Console.WriteLine("Saindo do sistema...");
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

    private static void ConsoleClear()
    {
        ConsoleClear();
    }
}