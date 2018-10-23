using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using adminAbp.Roles.Dto;
using adminAbp.Users.Dto;

namespace adminAbp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
