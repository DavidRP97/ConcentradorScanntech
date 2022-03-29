using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class CondicionesDto
    {
        [JsonPropertyName("items")]
        public List<CondicaoItemDto> CondicoesItens { get; set; }
    }
}