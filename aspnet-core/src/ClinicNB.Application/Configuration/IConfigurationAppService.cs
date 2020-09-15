using System.Threading.Tasks;
using ClinicNB.Configuration.Dto;

namespace ClinicNB.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
