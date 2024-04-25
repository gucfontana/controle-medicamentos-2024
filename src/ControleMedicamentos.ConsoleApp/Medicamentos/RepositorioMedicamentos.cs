﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamentos.ConsoleApp.Medicamentos;

internal class RepositorioMedicamentos
{
    private static List<Medicamento> medicamentos = new();

    public static void CadastrarMedicamento(Medicamento medicamento)
    {
        medicamentos.Add(medicamento);
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

    public static Medicamento BuscarMedicamento(string nome)
    {
        return medicamentos.Find(m => m.Nome == nome);
    }
}