using AutoMapper;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GenericRepository(AppDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public void Atualizar(dynamic entity)
        {
            var tEntity = _mapper.Map<TEntity>(entity);
            var update = _context.Set<TEntity>().Update(tEntity);
            update.State = EntityState.Modified;
            Save();
        }

        public bool Excluir(long id)
        {
            var entity = ObterPorId(id);
            if (entity == null) return false;
            _context.Set<TEntity>().Remove(entity);
            Save();
            return true;
        }

        public void Inserir(dynamic entity)
        {
            TEntity tEntity = _mapper.Map<TEntity>(entity);
            _context.Add(tEntity);
            Save();
        }

        public TEntity ObterPorId(long id)
        {
            var entity = _context.Set<TEntity>().Find(id);

            return _mapper.Map<TEntity>(entity);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            List<TEntity> entities = _context.Set<TEntity>().AsNoTracking().ToList();

            return entities;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
