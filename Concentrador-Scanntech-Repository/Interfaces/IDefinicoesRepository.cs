using Concentrador_Scanntech_Entities.Model.Definicoes;

namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IDefinicoesRepository : IGenericRepository<DefinicoesScanntech>
    {
        bool AddOrUpdate(DefinicoesScanntech definicoes);
        void DeleteCascade(long id);
        IEnumerable<DefinicoesScanntech> ObterTodosInclusoUrl();
        DefinicoesScanntech ObterDefinicao();
    }
}
