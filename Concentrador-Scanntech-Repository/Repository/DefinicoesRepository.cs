using AutoMapper;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Repository
{
    public class DefinicoesRepository : GenericRepository<DefinicoesScanntech>, IDefinicoesRepository
    {
        private readonly MySqlDbContext _context;
        private readonly IMapper _mapper;
        public DefinicoesRepository(MySqlDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddOrUpdate(DefinicoesScanntech definicoes)
        {
            var definicaoCadastrada = await _context.DefinicoesScanntech.ToListAsync();

            if(definicaoCadastrada.Count() > 0)
            {
                var pegarDefinicao = definicaoCadastrada.FirstOrDefault();
                definicoes.Id = pegarDefinicao.Id;

                var definir = _context.DefinicoesScanntech.Update(definicoes);
                await Save();
                if(definir != null) { return true; }

                return false;
            }
            else
            {
                var salvo = await _context.DefinicoesScanntech.AddAsync(definicoes);
                await Save();
                if (salvo != null) { return true; }
                return false;
                
            }
        }

        public async Task<IEnumerable<DefinicoesScanntech>> ObterTodosInclusoUrl()
        {
            var definicoes = await _context.DefinicoesScanntech.Include(x => x.uRLs).ToListAsync();

            return definicoes;
        }
    }
}
