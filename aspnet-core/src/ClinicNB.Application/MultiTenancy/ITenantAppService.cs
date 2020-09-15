using Abp.Application.Services;
using ClinicNB.MultiTenancy.Dto;

namespace ClinicNB.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

