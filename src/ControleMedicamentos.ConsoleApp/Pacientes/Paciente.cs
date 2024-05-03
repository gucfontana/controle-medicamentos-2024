namespace ControleMedicamentos.ConsoleApp.Pacientes;

public class Paciente
{
    public Paciente(string nome, string cpf, string dataNascimento)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string DataNascimento { get; set; }
}