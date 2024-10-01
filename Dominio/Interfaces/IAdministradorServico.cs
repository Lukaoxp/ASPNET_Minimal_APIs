using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.DTOs;

namespace MinimalAPIS.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        List<Administrador> Todos(int? pagina);
        Administrador Incluir(Administrador administrador);
        Administrador? BuscaPorId(int id);
    }
}