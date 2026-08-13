using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public interface ILookupTrafficLightService
    {
        Task<List<LookupTrafficLightDTO>> GetAllOrderedAsync();
    }
}
