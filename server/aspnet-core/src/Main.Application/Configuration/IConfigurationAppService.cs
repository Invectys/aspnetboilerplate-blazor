using System.Threading.Tasks;
using Main.Configuration.Dto;

namespace Main.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
