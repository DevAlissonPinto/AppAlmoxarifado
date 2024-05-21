using AppAlmoxarifado.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlmoxarifado.Tests.Domain.Entities;

public class MaterialTest
{
    [Fact]
    public void Nome_Deve_Ter_Entre_3_e_50_Caracteres()
    {
        var estoque = new Material("Captopril 5mg", "234212");

        Assert.True(estoque.Nome.Length >= 5 && estoque.Nome.Length <= 50);
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Nome_Ter_Mais_De_50_Caracteres()
    {
        string msg = "O Nome deve ter entre 5 e 50 caracteres";
        try
        {
            var estoque = new Material("Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg Captopril 5mg", "234212");
        }
        catch (Exception ex)
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
            var estoque = new Material("Capt", "234212");
        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    [Fact]
    public void Codigo_Deve_Ter_Entre_2_e_10_Caracteres()
    {
        var estoque = new Material("Captopril 5mg", "234212");

        Assert.True(estoque.Codigo.Length >= 5 && estoque.Codigo.Length <= 50);
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Codigo_Ter_Mais_De_10_Caracteres()
    {
        string msg = "O Código deve ter entre 2 e 10 caracteres";
        try
        {
            var estoque = new Material("Captopril 5mg", "234212793567");
        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Codigo_Ter_Menos_De_2_Caracteres()
    {
        string msg = "O Código deve ter entre 2 e 10 caracteres";
        try
        {
            var estoque = new Material("Captopril 5mg", "2");
        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }
}
