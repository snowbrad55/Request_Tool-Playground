using System.Security.Claims;
using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public interface IRequestService
    {
        Task<List<RequestsDTO>> GetRequestsForUserAsync(ClaimsPrincipal user);
    }
}
