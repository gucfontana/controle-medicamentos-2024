using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Funcionarios
{
    public class TelaFuncionario
    {
        public static void ExibirTelaFuncionario()
        {
            while (true)
            {
                Console.WriteLine("Tela de Funcionários\n");
                Console.WriteLine("0 - Verificar Cargos");
                Console.WriteLine("1 - Cadastrar Funcionário");
                Console.WriteLine("2 - Listar Funcionários");
                Console.WriteLine("3 - Buscar Funcionário");
                Console.WriteLine("4 - Remover Funcionário");
                Console.WriteLine("5 - Atualizar Funcionário");
                Console.WriteLine("6 - Sair\n");
                Console.WriteLine("Digite a opção desejada: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0":
                        Console.Clear();
                        RepositorioFuncionarios.VerificarCargoFuncionario();
                        break;
                    case "1":
                        Console.Clear();
                        TelaCadastroFuncionario();
                        break;
                    case "2":
                        Console.Clear();
                        RepositorioFuncionarios.ListarFuncionarios();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Digite o CPF do funcionário: ");
                        var cpf = Console.ReadLine();
                        var funcionario = RepositorioFuncionarios.BuscarFuncionarioPorCpf(cpf);
                        if (funcionario == null)
                        {
                            Console.WriteLine("Funcionário não encontrado!");
                            break;
                        }

                        Console.WriteLine(funcionario);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Digite o CPF do funcionário: ");
                        cpf = Console.ReadLine();
                        RepositorioFuncionarios.RemoverFuncionario(cpf);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Digite o CPF do funcionário: ");
                        cpf = Console.ReadLine();
                        RepositorioFuncionarios.AtualizarFuncionario(cpf);
                        break;
                    case "6":
                        Console.WriteLine("Saindo da tela de funcionários...");
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

        private static void TelaCadastroFuncionario()
        {
            Console.WriteLine("Cadastro de Funcionário\n");
            Console.WriteLine("Digite o nome do funcionário: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do funcionário: ");
            var cpf = Console.ReadLine();
            Console.WriteLine("Digite a função do funcionário: ");
            var funcao = Console.ReadLine();
            Console.WriteLine("Digite a senha do funcionário: ");
            var senha = Console.ReadLine();

            var funcionario = RepositorioFuncionarios.BuscarFuncionarioPorCpf(cpf);
            if (funcionario != null)
            {
                Console.WriteLine("Funcionário já cadastrado!");
                return;
            }
        }
    }
}
