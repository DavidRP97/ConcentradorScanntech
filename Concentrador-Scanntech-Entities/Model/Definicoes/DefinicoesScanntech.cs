using System.ComponentModel.DataAnnotations;
using static Concentrador_Scanntech_Entities.Utils.Enums;

namespace Concentrador_Scanntech_Entities.Model.Definicoes
{
    public class DefinicoesScanntech
    {
        [Key]
        public long Id { get; set; }
        public DateTime DataDeIntegração { get; set; }
        public string HorarioDeEnvioFechamento { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int SincronizacaoPromocoes { get; set; }
        public int SincronizacaoVendas { get; set; }
        public int SincronizacaoManual { get; set; }
        public int IdCompanhia { get; set; }
        public int IdLocal { get; set; }
        public int QuantidadeDeEnviosParaScanntech { get; set; }
        public StateEnums EstadoDaPromocao { get; set; }
        public virtual ICollection<URL> uRLs { get; set; }
    }
}
