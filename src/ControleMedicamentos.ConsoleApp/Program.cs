using ControleMedicamentos.ConsoleApp.Funcionarios;
using ControleMedicamentos.ConsoleApp.Medicamentos;
using ControleMedicamentos.ConsoleApp.Pacientes;
using ControleMedicamentos.ConsoleApp.Requisições;

namespace ControleMedicamentos.ConsoleApp;

public class Program
{
    public static List<Funcionario> funcionario = new();

    public static void Main(string[] args)
    {
        CadastrarAdmin();

        AutenticarFuncionario();
    }

    private static void CadastrarAdmin()
    {
        funcionario.Add(new Funcionario("Admin", "Admin", "Admin", "Admin"));
    }

    private static void AutenticarFuncionario()
    {
        while (true)
        {
            Console.WriteLine("Bem vindo ao sistema de Controle de Medicamentos!\n");
            Console.WriteLine("Faça o login para continuar... \n");
            Console.WriteLine("Digite seu CPF:");
            var cpf = Console.ReadLine();
            Console.WriteLine("Digite a senha de acesso:");
            var senha = Console.ReadLine();

            var funcionarioEncontrado = funcionario.Find(f => f.Cpf == cpf && f.Senha == senha);

            if (funcionarioEncontrado != null)
            {
                Console.Clear();
                Console.WriteLine(
                    "Login feito com sucesso!\nBem-vindo ao Controle de Medicamentos dos Postos de Saúde de Lages\n");
                MostrarMenu();
                break;
            }

            Console.Clear();
            Console.WriteLine("CPF ou senha inválidos. Tente novamente.");
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
                    TelaFuncionarios.TelaFuncionario();
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