namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class 
    {
        Task<IEnumerable<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(long id);
        Task Inserir(dynamic entity);
        Task Atualizar(dynamic entity);
        Task Save();
        Task<bool> Excluir(long id);
    }
}
