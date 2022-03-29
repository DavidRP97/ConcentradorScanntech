using Concentrador_Scanntech_Entities.Model.Definicoes;

namespace Concentrador_Scanntech_Services.Utils
{
    public static class MontarUrl
    {
        public static string Promocoes(DefinicoesScanntech definicoes, string url)
        {
            return ($"{url}/pmkt-rest-api/minoristas/{definicoes.IdCompanhia}/locales/{definicoes.IdLocal}/promocionesConLimitePorTicket?estado={definicoes.EstadoDaPromocao}");
        }
    }
}
