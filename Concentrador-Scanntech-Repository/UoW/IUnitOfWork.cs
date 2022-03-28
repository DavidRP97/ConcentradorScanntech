using Concentrador_Scanntech_Entities.Model.Definicoes;
using Concentrador_Scanntech_Repository.Interfaces;
using Concentrador_Scanntech_Repository.Repository;

namespace Concentrador_Scanntech_Repository.UoW
{
    public interface IUnitOfWork
    {
        IDefinicoesRepository DefinicoesRepository { get; }
        IStatusBancoRepository StatusBancoRepository { get; }
    }
}
