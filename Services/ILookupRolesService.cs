using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public interface ILookupRolesService
    {
        Task<List<LookupRoleDTO>> GetAllOrderedAsync();
    }
}
