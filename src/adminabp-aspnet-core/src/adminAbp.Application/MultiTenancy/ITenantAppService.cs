using Abp.Application.Services;
using Abp.Application.Services.Dto;
using adminAbp.MultiTenancy.Dto;

namespace adminAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
