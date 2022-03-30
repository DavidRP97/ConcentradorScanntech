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
        private readonly AppDbContext _context;
        public PromocoesRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BeneficioArtigoScanntech>> ArtigosBeneficios()
        {
            return await _context.BeneficioArtigoScanntech.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<CondicaoArtigoScanntech>> ArtigosCondicao()
        {            
            return await _context.CondicaoArtigoScanntech.AsNoTracking().ToListAsync();
        }

        public async Task<int> ContarPromocoes()
        {
            var promocoes = await _context.PromocoesScanntech.AsNoTracking().ToListAsync();

            return promocoes.Count();
        }

        public async Task<bool> DeleteCascade(long id)
        {
            var promocao = await _context.PromocoesScanntech.Where(x => x.PromocaoId == id).Include(x => x.DetalhePromocaoScanntech).FirstOrDefaultAsync();

            var detalhe = await _context.DetalhesPromocaoScanntech.Where(x => x.DetalhePromocaoScanntechId == promocao.DetalhePromocaoScanntechId)
                .Include(x => x.BeneficioScanntech).Include(x => x.CondicaoScanntech).FirstOrDefaultAsync();

            var beneficios = await _context.BeneficioScanntech.Where(x => x.BeneficioId == detalhe.BeneficioScanntechId)
                                .Include(x => x.BeneficioItens).FirstOrDefaultAsync();

            var condicoes = await _context.CondicaoScanntech.Where(x => x.CondicaoId == detalhe.CondicaoScanntechId)
                .Include(x => x.CondicoesItens).FirstOrDefaultAsync();

            var condicoesItens = await _context.CondicaoItemScanntech.Include(x => x.Artigos).ToListAsync();
            var beneficiosItens = await _context.BeneficioItemScanntech.Include(x => x.Artigos).ToListAsync();

            if (promocao == null) return false;

            _context.PromocoesScanntech.Remove(promocao);

            if (detalhe != null)_context.DetalhesPromocaoScanntech.Remove(detalhe);
            if(beneficios != null)_context.BeneficioScanntech.Remove(beneficios);
            if(condicoes != null)_context.CondicaoScanntech.Remove(condicoes);            

            await Save();
            return true;

        }

        public async Task<PromocaoScanntech> ObterPorApiID(long id)
        {
            var entity = await _context.PromocoesScanntech.Where(x => x.ApiId == id).FirstOrDefaultAsync();

            return entity;
        }

        public async Task<IEnumerable<PromocaoScanntech>> ObterPromocoesComInclude()
        {
            var promocoes = await _context.PromocoesScanntech.Include(x => x.DetalhePromocaoScanntech).ToListAsync();
            return promocoes;
        }

        public async Task SalvarPromocao(ResultDto result)
        {
            DateTime De = Convert.ToDateTime(result.VigenciaDe);
            DateTime Ate = Convert.ToDateTime(result.VigenciaAte);
            
            var tEntity = _mapper.Map<PromocaoScanntech>(result);

            tEntity.VigenciaDe = De.ToUniversalTime();
            tEntity.VigenciaAte = Ate.ToUniversalTime();
            tEntity.CargaPdv = true;
            tEntity.DataEnvioPdv = DateTime.Now.ToUniversalTime();
            
            await _context.PromocoesScanntech.AddAsync(tEntity);
            await Save();
        }
    }
}
