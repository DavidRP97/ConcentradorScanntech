using System.ComponentModel.DataAnnotations;

namespace Concentrador_Scanntech_Entities.Model.Promocoes
{
    public class CondicaoArtigoScanntech
    {
        [Key]
        public long ArtigoId { get; set; }        
        public string Nome { get; set; }
        public string CodigoDeBarras { get; set; }
    }
}