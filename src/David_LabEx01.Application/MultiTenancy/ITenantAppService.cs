using Abp.Application.Services;
using David_LabEx01.MultiTenancy.Dto;

namespace David_LabEx01.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

