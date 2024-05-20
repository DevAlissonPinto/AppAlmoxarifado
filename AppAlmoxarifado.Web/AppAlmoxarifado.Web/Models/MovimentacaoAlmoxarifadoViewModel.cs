using AppAlmoxarifado.Domain.Enum;

namespace AppAlmoxarifado.Web.Models;

public class MovimentacaoAlmoxarifadoViewModel
{
    public int Id { get; set; }

    public DateTime DataMovimentacao { get; set; }
    public int TipoMovimentacao { get; set; }
    public int AlmoxarifadoId { get; set; }

    public string AlmoxarifadoNome { get; set; }

}
