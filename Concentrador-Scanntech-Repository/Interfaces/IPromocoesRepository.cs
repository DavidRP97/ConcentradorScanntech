using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;

namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IPromocoesRepository : IGenericRepository<PromocaoScanntech>
    {
        bool DeleteCascade(long id);
        void SalvarPromocao(ResultDto result);
        int ContarPromocoes();
        PromocaoScanntech ObterPorApiID(long id);
        IEnumerable<PromocaoScanntech> ObterPromocoesComInclude();
        IEnumerable<BeneficioArtigoScanntech> ArtigosBeneficios();
        IEnumerable<CondicaoArtigoScanntech> ArtigosCondicao();
    }
}
