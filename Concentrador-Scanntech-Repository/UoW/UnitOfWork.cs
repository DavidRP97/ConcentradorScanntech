using AutoMapper;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.Repository;

namespace Concentrador_Scanntech_Repository.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private IDefinicoesRepository definicoesRepository;
        private IPromocoesRepository promocoesRepository;

        public UnitOfWork(AppDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public IDefinicoesRepository DefinicoesRepository
        {
            get
            {
                if (definicoesRepository == null)
                {
                    definicoesRepository = new DefinicoesRepository(_context, _mapper);                    
                }
                return definicoesRepository;
            }
        }
        public IPromocoesRepository PromocoesRepository
        {
            get
            {
                if(promocoesRepository == null)
                {
                    promocoesRepository = new PromocoesRepository(_context, _mapper);
                }
                return promocoesRepository;
            }
        }
    }
}
