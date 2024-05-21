using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Enum;

public class MovimentacaoEstoqueViewModel
{
    public int EstoqueId { get; set; }
    public Estoque? Estoque { get; set; }
    public int MaterialId { get; set; }
    public Material? Material { get; set; }
    public DateTime DataMovimentacao { get; set; }
    public int Quantidade { get; set; }
    public decimal Preco { get; set; }
    public TipoMovimentacaoEnum TipoMovimentacao { get; set; }

    // Método para converter ViewModel em Model
    public MovimentacaoEstoque ToModel()
    {
        return new MovimentacaoEstoque
        {
            EstoqueId = this.EstoqueId,
            MaterialId = this.MaterialId,
            DataMovimentacao = this.DataMovimentacao,
            Quantidade = this.Quantidade,
            Preco = this.Preco,
            TipoMovimentacao = this.TipoMovimentacao
        };
    }
}

