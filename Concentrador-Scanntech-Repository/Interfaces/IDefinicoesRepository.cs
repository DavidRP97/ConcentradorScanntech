using Concentrador_Scanntech_Entities.Model.Definicoes;

namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IDefinicoesRepository : IGenericRepository<DefinicoesScanntech>
    {
        Task<bool> AddOrUpdate(DefinicoesScanntech definicoes);
        Task<IEnumerable<DefinicoesScanntech>> ObterTodosInclusoUrl();
    }
}
