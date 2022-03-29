using System.ComponentModel.DataAnnotations;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class CondicaoItemScanntech
    {
        [Key]
        public long CondicaoItemId { get; set; }
        public int Quantidade { get; set; }
        public virtual ICollection<CondicaoArtigoScanntech> Artigos { get; set; }
    }
}