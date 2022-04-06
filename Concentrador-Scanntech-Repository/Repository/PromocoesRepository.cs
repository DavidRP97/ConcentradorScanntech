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

        public IEnumerable<BeneficioArtigoScanntech> ArtigosBeneficios()
        {
            return _context.BeneficioArtigoScanntech.AsNoTracking().ToList();
        }

        public IEnumerable<CondicaoArtigoScanntech> ArtigosCondicao()
        {
            return _context.CondicaoArtigoScanntech.AsNoTracking().ToList();
        }

        public int ContarPromocoes()
        {
            var promocoes = _context.PromocoesScanntech.AsNoTracking().ToList();

            return promocoes.Count();
        }

        public bool DeleteCascade(long id)
        {
            var promocao = _context.PromocoesScanntech.Where(x => x.PromocaoId == id).Include(x => x.DetalhePromocaoScanntech).FirstOrDefault();

            var detalhe = _context.DetalhesPromocaoScanntech.Where(x => x.DetalhePromocaoScanntechId == promocao.DetalhePromocaoScanntechId)
                .Include(x => x.BeneficioScanntech).Include(x => x.CondicaoScanntech).FirstOrDefault();

            var condicoes = _context.CondicaoScanntech.Where(x => x.CondicaoId == detalhe.CondicaoScanntechId)
                .Include(x => x.CondicoesItens).FirstOrDefault();

            var beneficios = _context.BeneficioScanntech.Where(x => x.BeneficioId == detalhe.BeneficioScanntechId)
                                .Include(x => x.BeneficioItens).FirstOrDefault();

            if (condicoes != null) _context.CondicaoItemScanntech.Include(x => x.Artigos).ToList();
            if (beneficios != null) _context.BeneficioItemScanntech.Include(x => x.Artigos).ToList();

            if (promocao == null) return false;

            _context.PromocoesScanntech.Remove(promocao);
            _context.DetalhesPromocaoScanntech.Remove(detalhe);

            if (condicoes != null)
            {
                _context.CondicaoArtigoScanntech.RemoveRange(condicoes.CondicoesItens.SelectMany(x => x.Artigos));
                _context.CondicaoItemScanntech.RemoveRange(condicoes.CondicoesItens);
                _context.CondicaoScanntech.Remove(condicoes);
            }

            if (beneficios != null)
            {
                _context.BeneficioArtigoScanntech.RemoveRange(beneficios.BeneficioItens.SelectMany(x => x.Artigos));
                _context.BeneficioItemScanntech.RemoveRange(beneficios.BeneficioItens);
                _context.BeneficioScanntech.Remove(beneficios);
            }

            Save();

            return true;

        }

        public PromocaoScanntech ObterPorApiID(long id)
        {
            var entity = _context.PromocoesScanntech.Where(x => x.ApiId == id).FirstOrDefault();

            return entity;
        }

        public IEnumerable<PromocaoScanntech> ObterPromocoesComInclude()
        {
            var promocoes = _context.PromocoesScanntech.Include(x => x.DetalhePromocaoScanntech).ToList();
            return promocoes;
        }

        public void SalvarPromocao(ResultDto result)
        {
            var condicoesItens = new List<CondicaoItemScanntech>();

            DateTime De = Convert.ToDateTime(result.VigenciaDe);
            DateTime Ate = Convert.ToDateTime(result.VigenciaAte);


            var tEntity = _mapper.Map<PromocaoScanntech>(result);

            if (tEntity.DetalhePromocaoScanntech.CondicaoScanntech != null)
            {
                var tEntityCondicoes = tEntity.DetalhePromocaoScanntech.CondicaoScanntech.CondicoesItens;

                foreach (var item in tEntityCondicoes.SelectMany(x => x.Artigos).ToList())
                {
                    item.ApiId = result.ApiId;
                    item.QuantidadeParaAtivarPromocao = tEntityCondicoes.Select(x => x.Quantidade).FirstOrDefault();
                }
            }
            
            if (tEntity.DetalhePromocaoScanntech.BeneficioScanntech != null)
            {
                var tEntityBeneficios = tEntity.DetalhePromocaoScanntech.BeneficioScanntech.BeneficioItens;
                foreach (var item in tEntityBeneficios.SelectMany(x => x.Artigos).ToList())
                {
                    item.ApiId = result.ApiId;
                    item.QuantidadeParaAtivarPromocao = tEntityBeneficios.Select(x => x.Quantidade).FirstOrDefault();
                }
            }

            tEntity.VigenciaDe = De.AddHours(-3).ToUniversalTime();
            tEntity.VigenciaAte = Ate.AddHours(-3).ToUniversalTime();
            tEntity.CargaPdv = true;
            tEntity.DataEnvioPdv = DateTime.Now.ToUniversalTime().AddHours(-3);

            _context.PromocoesScanntech.Add(tEntity);
            Save();
        }
    }
}
