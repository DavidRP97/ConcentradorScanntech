using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class BeneficioItemScanntech
    {
        [Key]
        public long BeneficioItemId { get; set; }
        public int Quantidade { get; set; }
        public virtual ICollection<BeneficioArtigoScanntech> Artigos { get; set; }
    }
}