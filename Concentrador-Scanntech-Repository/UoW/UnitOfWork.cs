using AutoMapper;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.Repository;

namespace Concentrador_Scanntech_Repository.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MySqlDbContext _context;
        private readonly IMapper _mapper;
        private IDefinicoesRepository definicoesRepository;
        private IStatusBancoRepository statusBancoRepository;   

        public UnitOfWork(MySqlDbContext context, IMapper mapper)
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

        public IStatusBancoRepository StatusBancoRepository
        {
            get
            {
                if (statusBancoRepository == null)
                {
                    statusBancoRepository = new StatusBancoRepository(_context, _mapper);
                }
                return statusBancoRepository;
            }
        }
    }
}
