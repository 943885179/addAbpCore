using System.Threading.Tasks;
using Abp.Application.Services;
using adminAbp.Sessions.Dto;

namespace adminAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
