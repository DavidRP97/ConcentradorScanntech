namespace Concentrador_Scanntech_Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class 
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(long id);
        void Inserir(dynamic entity);
        void Atualizar(dynamic entity);
        void Save();
        bool Excluir(long id);
    }
}
