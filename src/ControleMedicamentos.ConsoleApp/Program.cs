using System;
using System.Security.Cryptography.X509Certificates;
using ControleMedicamentos.ConsoleApp.Funcionarios;
using ControleMedicamentos.ConsoleApp.Medicamentos;
using ControleMedicamentos.ConsoleApp.Pacientes;
using ControleMedicamentos.ConsoleApp.Requisições;

namespace ControleMedicamentos.ConsoleApp;

internal class Program
{
    public const string UsuarioCorreto = "admin";
    public const string SenhaCorreta = "123";

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite seu nome de usuario:");
            var usuarioCorreto = Console.ReadLine();
            Console.WriteLine("Digite a senha de acesso:");
            var senhaCorreta = Console.ReadLine();

            if (senhaCorreta == SenhaCorreta & usuarioCorreto == UsuarioCorreto)
            {
                Console.Clear();
                Console.WriteLine("Login feito com sucesso!\nBem-vindo ao Controle de Medicamentos dos Postos de Saúde de Lages\n");
                MostrarMenu();
                break;
            }
            else
            {
                Console.WriteLine("Senha incorreta. Tente novamente.");
            }
        }
    }

    private static void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("0 - Tela de Funcionários");
            Console.WriteLine("1 - Tela de Medicamentos");
            Console.WriteLine("2 - Tela de Pacientes");
            Console.WriteLine("3 - Tela de Requisições");
            Console.WriteLine("4 - Sair\n");
            Console.WriteLine("Digite a opção desejada: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    Console.Clear();
                    TelaFuncionario.ExibirTelaFuncionario();
                    break;
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
}