using System.Text.Json.Serialization;

namespace Concentrador_Scanntech_Entities.Dtos.Promocoes
{
    public class ResultDto
    {
        [JsonPropertyName("id")]
        public int ApiId { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("descripcion")]
        public string Descricao { get; set; }

        [JsonPropertyName("tipo")]
        public string TipoPromocao { get; set; }

        [JsonPropertyName("detalles")]
        public DetallesDto DetalhePromocaoScanntech { get; set; }

        [JsonPropertyName("autor")]
        public AutorDto Autor { get; set; }

        [JsonPropertyName("vigenciaDesde")]
        public string VigenciaDe { get; set; }

        [JsonPropertyName("vigenciaHasta")]
        public string VigenciaAte { get; set; }

        [JsonPropertyName("limitePromocionesPorTicket")]
        public int? LimiteDePromocoesPorTicket { get; set; }
    }
}
