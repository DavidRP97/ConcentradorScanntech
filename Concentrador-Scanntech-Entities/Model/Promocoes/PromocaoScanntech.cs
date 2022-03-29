using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class PromocaoScanntech
    {
        [Key]
        public long PromocaoId { get; set; }
        public long ApiId { get; set; }
        public int? LimiteDePromocoesPorTicket { get; set; }
        public bool CargaPdv { get; set; }        
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string TipoPromocao { get; set; }        
        public DateTime VigenciaDe { get; set; }
        public DateTime VigenciaAte { get; set; }
        public DateTime DataEnvioPdv { get; set; }
        [ForeignKey("DetalhePromocaoScanntechId")]
        public virtual DetalhesPromocaoScanntech DetalhePromocaoScanntech { get; set; }
        public long DetalhePromocaoScanntechId { get; set; }
    }
}
