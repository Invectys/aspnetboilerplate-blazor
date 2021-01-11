using System.Threading.Tasks;
using Abp.Application.Services;
using Main.Sessions.Dto;

namespace Main.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
