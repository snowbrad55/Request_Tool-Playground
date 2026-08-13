using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public class LookupPriorityService(IDbContextFactory<TmscDbContext> ctx) : ILookupPriorityService
    {
        public async Task<List<LookupPriorityDTO>> GetAllOrderedAsync()
        {
            using var context = ctx.CreateDbContext();
            return await context.LookupPriorities.AsNoTracking()
                .Select(p => new LookupPriorityDTO
                {
                    PriorityId = p.PriorityId,
                    PriorityLevel = p.PriorityLevel,
                    PriorityName = p.PriorityName,
                    PriorityDescription = p.PriorityDescription,
                    PriorityLevelDescription = p.PriorityLevelDescription,
                })
                .OrderBy(p => p.PriorityLevel)
                .ToListAsync();

        }
    }
}
