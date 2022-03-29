using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;

namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IPromocoesRepository : IGenericRepository<PromocaoScanntech>
    {
        Task SalvarPromocao(ResultDto result);
        Task<PromocaoScanntech> ObterPorApiID(long id);
    }
}
