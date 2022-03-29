using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class DetalhesPromocaoScanntech
    {
        [Key]
        public long DetalhePromocaoScanntechId { get; set; }
        [ForeignKey("CondicaoScanntechId")]
        public virtual CondicaoScanntech? CondicaoScanntech { get; set; }
        [ForeignKey("BeneficioScanntechId")]
        public virtual BeneficioScanntech? BeneficioScanntech { get; set; }
        public long? BeneficioScanntechId { get; set; }
        public long? CondicaoScanntechId { get; set; }
        public decimal? PrecoValorFixo { get; set; }
        public decimal? Desconto { get; set; }
        public int? QuantidadeItensLevaEPaga { get; set; }
    }
}