using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using David_LabEx01.Configuration.Dto;

namespace David_LabEx01.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : David_LabEx01AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
