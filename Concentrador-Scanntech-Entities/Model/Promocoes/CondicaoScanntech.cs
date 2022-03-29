using System.ComponentModel.DataAnnotations;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class CondicaoScanntech
    {
        [Key]
        public long CondicaoId { get; set; }
        public virtual ICollection<CondicaoItemScanntech> CondicoesItens { get; set; }
    }
}