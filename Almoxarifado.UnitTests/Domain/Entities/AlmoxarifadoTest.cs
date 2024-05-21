using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Tests.Domain.Entities;

public class AlmoxarifadoTest
{
    [Fact]
    public void Nome_Deve_Ter_Entre_3_e_50_Caracteres()
    {
        var almoxarifado = new Estoque("Almoxarifado Central");

        Assert.True(almoxarifado.Nome.Length >= 3 && almoxarifado.Nome.Length <= 50);
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Nome_Ter_Mais_De_50_Caracteres()
    {
        string msg = "O Nome deve ter entre 5 e 50 caracteres";
        try
        {
            var almoxarifado = new Estoque("Alm");
        }
        catch(Exception ex) 
        {
            Assert.Equal(msg, ex.Message);
        }
    }
}
