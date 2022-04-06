using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class BeneficiosDto
    {
        [JsonPropertyName("items")]
        public List<BeneficioItemDto> BeneficioItens { get; set; }
    }
}