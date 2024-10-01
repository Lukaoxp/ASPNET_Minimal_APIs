using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.Dominio.Enums;
using MinimalAPIS.Dominio.Interfaces;
using MinimalAPIS.DTOs;

namespace Test.Mocks;

public class AdministradorServicoMock : IAdministradorServico
{
    private static List<Administrador> administradores = new List<Administrador>{
        new() {
            Id = 1,
            Email = "teste@teste",
            Senha = "123456",
            Perfil = Perfil.Adm
        },
        new() {
            Id = 2,
            Email = "editor@editor",
            Senha = "123456",
            Perfil = Perfil.Editor
        }
    };
    public Administrador? BuscaPorId(int id)
    {
        return administradores.Find(a => a.Id == id);
    }

    public Administrador Incluir(Administrador administrador)
    {
        administrador.Id = administradores.Count + 1;
        administradores.Add(administrador);
        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        return administradores.Find(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
    }

    public List<Administrador> Todos(int? pagina)
    {
        return administradores;
    }
}
