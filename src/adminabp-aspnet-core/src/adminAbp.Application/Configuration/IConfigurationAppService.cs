using System.Threading.Tasks;
using adminAbp.Configuration.Dto;

namespace adminAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
