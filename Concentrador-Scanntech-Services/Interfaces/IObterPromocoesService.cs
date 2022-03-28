using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Services.Factory.UrlFactory;
using static Concentrador_Scanntech_Entities.Utils.Enums;

namespace Concentrador_Scanntech_Services.Interfaces
{
    public interface IObterPromocoesService
    {
        Task<ResultDto> ObterPromocoesScanntech(DefinicoesScanntech definicoes, IUrlFactory url);       
    }
}
