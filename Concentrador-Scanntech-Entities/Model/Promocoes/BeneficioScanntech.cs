using System.ComponentModel.DataAnnotations;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class BeneficioScanntech
    {
        [Key]
        public long BeneficioId { get; set; }
        public virtual ICollection<BeneficioItemScanntech> BeneficioItens { get; set; }
    }
}