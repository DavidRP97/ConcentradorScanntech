using AutoMapper;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly MySqlDbContext _context;
        private readonly IMapper _mapper;

        public GenericRepository(MySqlDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task Atualizar(dynamic entity)
        {
            var tEntity = _mapper.Map<TEntity>(entity);
            var update = _context.Set<TEntity>().Update(tEntity);
            update.State = EntityState.Modified;
            await Save();            
        }

        public async Task<bool> Excluir(long id)
        {
            var entity = await ObterPorId(id);
            if (entity == null) return false;
            _context.Set<TEntity>().Remove(entity);
            await Save();
            return true;
        }

        public async Task Inserir(dynamic entity)
        {
            TEntity tEntity = _mapper.Map<TEntity>(entity);
            await _context.AddAsync(tEntity);
            await Save();
        }

        public async Task<TEntity> ObterPorId(long id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            return _mapper.Map<TEntity>(entity);
        }

        public async Task<IEnumerable<TEntity>> ObterTodos()
        {
            List<TEntity> entities = await _context.Set<TEntity>().AsNoTracking().ToListAsync();

            return entities;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
