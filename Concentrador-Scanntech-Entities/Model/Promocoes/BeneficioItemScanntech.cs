using System.ComponentModel.DataAnnotations;

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