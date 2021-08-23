using System.Threading.Tasks;
using Abp.Application.Services;
using David_LabEx01.Sessions.Dto;

namespace David_LabEx01.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
