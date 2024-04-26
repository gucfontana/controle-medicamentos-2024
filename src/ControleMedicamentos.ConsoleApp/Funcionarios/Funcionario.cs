public class Funcionario
{
    public Funcionario(string cpf, string nome, string funcao, string senha)
    {
        Cpf = cpf;
        Nome = nome;
        Funcao = funcao;
        Senha = senha;
    }

    public string Cpf { get; set; }
    public string Nome { get; set; }
    public string Funcao { get; set; }
    public string Senha { get; set; }

    public override string ToString()
    {
        return $"CPF: {Cpf}, Nome: {Nome}, Função: {Funcao}";
    }
}