using System.Threading.Tasks;
using Abp.Application.Services;
using Main.Authorization.Accounts.Dto;

namespace Main.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
