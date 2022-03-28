using System.ComponentModel.DataAnnotations;

namespace Concentrador_Scanntech_Entities.Model.Definicoes
{
    public class Status
    {
        [Key]
        public long StatusId { get; set; }
        public bool StatusDoBanco { get; set; }
    }
}
