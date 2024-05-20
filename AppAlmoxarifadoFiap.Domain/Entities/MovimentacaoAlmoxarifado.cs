using AppAlmoxarifado.Domain.Entities.Base;
using AppAlmoxarifado.Domain.Enum;

namespace AppAlmoxarifado.Domain.Entities;

public class MovimentacaoEstoque : EntityBase
{
    public int EstoqueMaterialId { get; set; }
    public EstoqueMaterial EstoqueMaterial { get; set; }

    public int Quantidade { get; set; }
    public decimal? Preco { get; set; }
    public DateTime DataMovimentacao { get; set; }
    public TipoMovimentacao Tipo { get; set; }
}
public class EstoqueMaterial : EntityBase
{
    public int EstoqueId { get; set; }
    public Almoxarifado Estoque { get; set; }
    public int MaterialId { get; set; }
    public Material Material { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoMedio { get; set; } // Média dos preços de entrada
}
