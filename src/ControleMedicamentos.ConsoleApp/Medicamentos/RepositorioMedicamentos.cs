namespace ControleMedicamentos.ConsoleApp.Medicamentos;

internal class RepositorioMedicamentos
{
    private static readonly List<Medicamento> medicamentos = new();
    private static Medicamento[] medicamentosArray = new Medicamento[100];

    public static void CadastrarMedicamento(Medicamento medicamento)
    {
        medicamentos.Add(medicamento);
        medicamentosArray = medicamentos.ToArray();
    }

    public static void AtualizarMedicamento(Medicamento medicamento)
    {
        var medicamentoAtual = medicamentos.Find(m => m.Nome == medicamento.Nome);
        if (medicamentoAtual != null)
        {
            medicamentoAtual.Quantidade = medicamento.Quantidade;
            medicamentoAtual.Descricao = medicamento.Descricao;
        }
    }

    public static void ExcluirMedicamento(string nome)
    {
        medicamentos.RemoveAll(m => m.Nome == nome);
    }

    public static List<Medicamento> ListarMedicamentos()
    {
        return medicamentos;
    }

    public static void VerificarEstoque()
    {
        if (medicamentos.Count == 0)
        {
            Console.WriteLine("Nenhum medicamento cadastrado!");
            return;
        }

        medicamentos.ForEach(m =>
        {
            if (m.Quantidade < 10) Console.WriteLine(m);
        });
    }
}