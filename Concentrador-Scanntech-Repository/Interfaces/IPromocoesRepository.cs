using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;

namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IPromocoesRepository : IGenericRepository<PromocaoScanntech>
    {
        Task<bool> DeleteCascade(long id);
        Task SalvarPromocao(ResultDto result);
        Task<int> ContarPromocoes();
        Task<PromocaoScanntech> ObterPorApiID(long id);
        Task<IEnumerable<PromocaoScanntech>> ObterPromocoesComInclude();
        Task<IEnumerable<BeneficioArtigoScanntech>> ArtigosBeneficios();
        Task<IEnumerable<CondicaoArtigoScanntech>> ArtigosCondicao();
    }
}
