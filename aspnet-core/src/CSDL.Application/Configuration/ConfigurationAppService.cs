using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CSDL.Configuration.Dto;

namespace CSDL.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CSDLAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
