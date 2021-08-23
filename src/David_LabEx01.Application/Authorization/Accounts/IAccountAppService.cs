using System.Threading.Tasks;
using Abp.Application.Services;
using David_LabEx01.Authorization.Accounts.Dto;

namespace David_LabEx01.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
