using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public interface ILookupTeamService
    {
        Task<List<LookupTeamDTO>> GetAllOrderedAsync();
        Task<LookupTeamDTO?> GetByIdAsync(int teamId);
        Task<bool> AddAsync(LookupTeamDTO tDto);
        Task<bool> UpdateAsync(LookupTeamDTO tDto);
        Task<bool> DeleteAsync(int teamId);
    }
}