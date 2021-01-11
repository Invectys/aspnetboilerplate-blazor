using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Main.Configuration.Dto;

namespace Main.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MainAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
