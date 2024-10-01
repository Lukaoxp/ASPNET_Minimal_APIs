using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.Dominio.Enums;
using MinimalAPIS.Dominio.Servicos;
using MinimalAPIS.Infraestrutura.Db;

namespace Test.Domain.Servicos;

[TestClass]
public class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTeste()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

        var configuration = builder.Build();

        return new DbContexto(configuration);
    }

    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        var context = CriarContextoDeTeste();
        context.Administradores.FromSqlRaw("TRUNCATE TABLE Administradores");

        var adm = new Administrador
        {
            Email = "teste@teste",
            Senha = "123456",
            Perfil = Perfil.Adm
        };
        var administradorServico = new AdministradorServico(context);


        administradorServico.Incluir(adm);
        
        Assert.AreEqual(administradorServico.Todos(null).Count(), adm.Id);
        Assert.AreEqual("teste@teste", adm.Email);
        Assert.AreEqual("123456", adm.Senha);
        Assert.AreEqual(Perfil.Adm, adm.Perfil);
    }

    [TestMethod]
    public void TestandoBuscaPorId()
    {
        var context = CriarContextoDeTeste();
        context.Administradores.FromSqlRaw("TRUNCATE TABLE Administradores");

        var adm = new Administrador
        {
            Email = "teste@teste",
            Senha = "123456",
            Perfil = Perfil.Adm
        };
        var administradorServico = new AdministradorServico(context);
        administradorServico.Incluir(adm);

        var admBuscado = administradorServico.BuscaPorId(adm.Id);
        Assert.IsNotNull(admBuscado);
        Assert.AreEqual(adm.Email, admBuscado.Email);
    }
}
