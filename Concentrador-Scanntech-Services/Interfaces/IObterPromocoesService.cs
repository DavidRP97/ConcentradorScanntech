using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Definicoes;

namespace Concentrador_Scanntech_Services.Interfaces
{
    public interface IObterPromocoesService
    {
        Task<RootDto> ObterPromocoesScanntech(DefinicoesScanntech definicoes, string url);
    }
}
