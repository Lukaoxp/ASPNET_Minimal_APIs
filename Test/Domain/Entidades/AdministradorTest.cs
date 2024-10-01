using MinimalAPIS.Dominio.Entidades;
using MinimalAPIS.Dominio.Enums;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var adm = new Administrador
        {
            Id = 5,
            Email = "teste@teste",
            Senha = "123456",
            Perfil = Perfil.Adm
        };

        Assert.AreEqual(5, adm.Id);
        Assert.AreEqual("teste@teste", adm.Email);
        Assert.AreEqual("123456", adm.Senha);
        Assert.AreEqual(Perfil.Adm, adm.Perfil);
    }
}
