using System.Threading.Tasks;
using Abp.Application.Services;
using CSDL.Sessions.Dto;

namespace CSDL.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
