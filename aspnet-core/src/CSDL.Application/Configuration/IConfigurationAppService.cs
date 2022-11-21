using System.Threading.Tasks;
using CSDL.Configuration.Dto;

namespace CSDL.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
