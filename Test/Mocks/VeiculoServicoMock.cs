using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.Dominio.Interfaces;
using MinimalAPIS.DTOs;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = [];

    public void Apagar(Veiculo veiculo)
    {
        veiculos.RemoveAll(v => v == veiculo);
    }

    public void Atualizar(Veiculo veiculo)
    {
        var veiculoDB = veiculos.Find(v => v.Id == veiculo.Id);
        if (veiculoDB != null)
        {
            veiculoDB.Nome = veiculo.Nome;
            veiculoDB.Marca = veiculo.Marca;
            veiculoDB.Ano = veiculo.Ano;
        }
    }

    public Veiculo? BuscarPorId(int id)
    {
        return veiculos.Find(v => v.Id == id);
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }
}
