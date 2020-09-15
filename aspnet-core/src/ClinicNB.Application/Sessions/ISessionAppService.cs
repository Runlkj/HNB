using System.Threading.Tasks;
using Abp.Application.Services;
using ClinicNB.Sessions.Dto;

namespace ClinicNB.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
