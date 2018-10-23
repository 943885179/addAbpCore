using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using adminAbp.Configuration.Dto;

namespace adminAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : adminAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
