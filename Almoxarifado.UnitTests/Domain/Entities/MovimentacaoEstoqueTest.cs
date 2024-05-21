using AppAlmoxarifado.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlmoxarifado.Tests.Domain.Entities;

public class MovimentacaoEstoqueTest
{
    [Fact]
    public void Deve_Retornar_Erro_Quando_Quantidade_Menor_Igual_Zero ()
    {
        string msg = "A quantidade não pode ser zero ou negativo!";
        try
        {
            var estoque = new MovimentacaoEstoque(0, 10, DateTime.Now, AppAlmoxarifado.Domain.Enum.TipoMovimentacaoEnum.ENTRADA, 1, 1);
        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }

    [Fact]
    public void Deve_Retornar_Erro_Quando_Preco_Menor_Igual_Zero()
    {
        string msg = "O preço não pode ser zero ou negativo!";
        try
        {
            var estoque = new MovimentacaoEstoque(10, 0, DateTime.Now, AppAlmoxarifado.Domain.Enum.TipoMovimentacaoEnum.ENTRADA, 1, 1);
        }
        catch (Exception ex)
        {
            Assert.Equal(msg, ex.Message);
        }
    }
}
