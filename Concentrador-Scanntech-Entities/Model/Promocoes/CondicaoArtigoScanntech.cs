using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class CondicaoArtigoScanntech
    {
        [Key]
        public long ArtigoId { get; set; }
        public long ApiId { get; set; }
        public int QuantidadeParaAtivarPromocao { get; set; }
        public string Nome { get; set; }
        public string CodigoDeBarras { get; set; }
    }
}