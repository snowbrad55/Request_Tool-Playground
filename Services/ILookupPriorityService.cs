using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public interface ILookupPriorityService
    {
        Task<List<LookupPriorityDTO>> GetAllOrderedAsync();
    }
}
