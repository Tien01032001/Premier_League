using Abp.Application.Services;
using CSDL.MultiTenancy.Dto;

namespace CSDL.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

