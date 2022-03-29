using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class CondicaoArticuloDto
    {
        [JsonPropertyName("codigoBarras")]
        public string CodigoDeBarras { get; set; }
        [JsonPropertyName("nombre")]
        public string Nome { get; set; }
    }
}