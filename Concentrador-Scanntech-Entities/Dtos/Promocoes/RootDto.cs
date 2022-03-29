using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class RootDto
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("results")]
        public List<ResultDto> Resultados { get; set; }
    }
}
