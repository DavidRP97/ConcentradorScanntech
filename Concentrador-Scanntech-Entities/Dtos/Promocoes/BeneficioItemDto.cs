using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class BeneficioItemDto
    {
        [JsonPropertyName("cantidad")]
        public int Quantidade { get; set; }
        [JsonPropertyName("articulos")]
        public List<BeneficioArticuloDto> Artigos  { get; set; }
    }
}