using System.Threading.Tasks;
using Abp.Application.Services;
using ClinicNB.Authorization.Accounts.Dto;

namespace ClinicNB.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
