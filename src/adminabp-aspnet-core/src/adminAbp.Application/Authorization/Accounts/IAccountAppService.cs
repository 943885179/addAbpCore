using System.Threading.Tasks;
using Abp.Application.Services;
using adminAbp.Authorization.Accounts.Dto;

namespace adminAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
