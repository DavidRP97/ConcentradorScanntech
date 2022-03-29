using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class DetallesDto
    {
        [JsonPropertyName("condiciones")]
        public virtual CondicionesDto CondicaoScanntech { get; set; }

        [JsonPropertyName("beneficios")]
        public virtual BeneficiosDto BeneficioScanntech { get; set; }

        [JsonPropertyName("precio")]
        public decimal? PrecoValorFixo { get; set; }

        [JsonPropertyName("descuento")]
        public decimal? Desconto { get; set; }

        [JsonPropertyName("paga")]
        public int? QuantidadeItensLevaEPaga { get; set; }
    }
}