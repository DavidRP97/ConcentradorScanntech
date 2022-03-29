using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class CondicaoItemDto
    {
        [JsonPropertyName("cantidad")]
        public int Quantidade { get; set; }
        [JsonPropertyName("articulos")]
        public List<CondicaoArticuloDto> Artigos  { get; set; }
    }
}