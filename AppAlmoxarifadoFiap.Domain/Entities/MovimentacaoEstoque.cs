using AppAlmoxarifado.Domain.Entities.Base;
using AppAlmoxarifado.Domain.Enum;

namespace AppAlmoxarifado.Domain.Entities
{
    public class MovimentacaoEstoque : EntityBase
    {
        public int Quantidade { get; set; }
        public decimal? Preco { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public TipoMovimentacaoEnum TipoMovimentacao { get; set; }

        public int EstoqueId { get; set; }
        public Estoque Estoque { get; set; }

        public int MaterialId { get; set; }
        public Material Material { get; set; }


    }
}
