using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class BeneficioArtigoScanntech
    {
        [Key]
        public long ArtigoId { get; set; }
        [NotMapped]
        public long ApiId { get; set; }
        [NotMapped]
        public int QuantidadeParaAtivarPromocao { get; set; }
        public string Nome { get; set; }
        public string CodigoDeBarras { get; set; }
    }
}