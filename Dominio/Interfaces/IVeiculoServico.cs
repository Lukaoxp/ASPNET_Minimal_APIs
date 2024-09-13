using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.DTOs;

namespace MinimalAPIS.Dominio.Interfaces
{
    public interface IVeiculoServico
    {
        List<Veiculo> Todos(int pagina, string? nome, string? marca);
        Veiculo? BuscarPorId(int id);
        void Incluir(Veiculo veiculo);
        void Atualizar(Veiculo veiculo);
        void Apagar (Veiculo veiculo);
    }
}