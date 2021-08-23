using System.Threading.Tasks;
using David_LabEx01.Configuration.Dto;

namespace David_LabEx01.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
