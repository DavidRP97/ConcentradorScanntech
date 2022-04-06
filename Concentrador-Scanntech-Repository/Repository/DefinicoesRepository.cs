using AutoMapper;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Concentrador_Scanntech_Repository.Repository
{
    public class DefinicoesRepository : GenericRepository<DefinicoesScanntech>, IDefinicoesRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public DefinicoesRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool AddOrUpdate(DefinicoesScanntech definicoes)
        {
            var definicaoCadastrada = _context.DefinicoesScanntech.ToList();

            if (definicaoCadastrada.Count() > 0)
            {
                var pegarDefinicao = definicaoCadastrada.FirstOrDefault();

                DeleteCascade(pegarDefinicao.Id);

                var definir = _context.DefinicoesScanntech.Add(definicoes);
                Save();
                if (definir != null) { return true; }

                return false;
            }
            else
            {
                var salvo = _context.DefinicoesScanntech.Add(definicoes);
                Save();
                if (salvo != null) { return true; }
                return false;

            }
        }

        public void DeleteCascade(long id)
        {
            var entyty = _context.DefinicoesScanntech.Include(x => x.uRLs).Where(x => x.Id == id).FirstOrDefault();

            _context.URLs.RemoveRange(entyty.uRLs);
            _context.DefinicoesScanntech.Remove(entyty);
        }

        public DefinicoesScanntech ObterDefinicao()
        {
            var definicoes = _context.DefinicoesScanntech.Include(x => x.uRLs).FirstOrDefault();

            return definicoes;
        }

        public IEnumerable<DefinicoesScanntech> ObterTodosInclusoUrl()
        {
            var definicoes = _context.DefinicoesScanntech.Include(x => x.uRLs).ToList();

            return definicoes;
        }
    }
}
