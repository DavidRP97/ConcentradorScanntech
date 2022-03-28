using System.ComponentModel.DataAnnotations;

namespace Concentrador_Scanntech_Entities.Model.Definicoes
{
    public class URL
    {
        [Key]
        public long Id { get; set; }
        public string UrlConnection { get; set; }
    }
}
