using AutoMapper;
using Concentrador_Scanntech_Entities.Dtos.Promocoes;
using Concentrador_Scanntech_Entities.Model.Promocoes;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Repository
{
    public class PromocoesRepository : GenericRepository<PromocaoScanntech>, IPromocoesRepository
    {
        private readonly IMapper _mapper;
        private readonly MySqlDbContext _context; 
        public PromocoesRepository(MySqlDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context; 
            _mapper = mapper;   
        }

        public async Task<PromocaoScanntech> ObterPorApiID(long id)
        {
            var entity = await _context.PromocoesScanntech.Where(x => x.ApiId == id).FirstOrDefaultAsync();

            return entity;
        }

        public async Task SalvarPromocao(ResultDto result)
        {
            DateTime De = Convert.ToDateTime(result.VigenciaDe);
            DateTime Ate = Convert.ToDateTime(result.VigenciaAte);

            var tEntity = _mapper.Map<PromocaoScanntech>(result);

            tEntity.VigenciaDe = De.ToUniversalTime();
            tEntity.VigenciaAte = Ate.ToUniversalTime();    
            tEntity.CargaPdv = true;
            tEntity.DataEnvioPdv = DateTime.UtcNow;
            await _context.PromocoesScanntech.AddAsync(tEntity);
            await Save();
        }
    }
}
