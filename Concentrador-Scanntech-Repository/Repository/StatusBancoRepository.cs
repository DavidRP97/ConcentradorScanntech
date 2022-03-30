using AutoMapper;
using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Repository.Context;
using Concentrador_Scanntech_Repository.Interfaces;

namespace Concentrador_Scanntech_Repository.Repository
{
    public class StatusBancoRepository : GenericRepository<Status>, IStatusBancoRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public StatusBancoRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context; 
            _mapper = mapper;
        }
    }
}
