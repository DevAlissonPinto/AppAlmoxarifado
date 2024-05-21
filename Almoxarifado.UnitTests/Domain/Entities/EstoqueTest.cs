using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Tests.Domain.Entities;

public class EstoqueTest
{
    [Fact]
    public void Nome_Deve_Ter_Entre_3_e_50_Caracteres()
    {
        var estoque = new Estoque("Estoque Central");

        Assert.True(estoque.Nome.Length >= 3 && estoque.Nome.Length <= 50);
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Nome_Ter_Mais_De_50_Caracteres()
    {
        string msg = "O Nome deve ter entre 5 e 50 caracteres";
        try
        {
            var estoque = new Estoque("Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central Estoque Central");
        }
        catch(Exception ex) 
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Nome_Ter_Menos_De_5_Caracteres()
    {
        string msg = "O Nome deve ter entre 5 e 50 caracteres";
        try
        {
            var estoque = new Estoque("Esto");
        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }
}
