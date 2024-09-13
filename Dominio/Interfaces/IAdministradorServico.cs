using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.DTOs;

namespace MinimalAPIS.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        List<Administrador> Todos(int? pagina);
    }
}