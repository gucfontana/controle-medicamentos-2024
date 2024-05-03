namespace ControleMedicamentos.ConsoleApp.Medicamentos;

internal class Medicamento
{
    public Medicamento(string nome, string descricao, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        Quantidade = quantidade;
    }

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
}