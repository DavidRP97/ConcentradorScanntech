using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using System.Net;

namespace Concentrador_Scanntech_Services.Interfaces
{
    public interface IObterPromocoesService
    {
        Tuple<RootDto, bool> ObterPromocoesScanntech(DefinicoesScanntech definicoes, string url);
    }
}
