using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public class LookupTrafficLightService(IDbContextFactory<TmscDbContext> dbFactory) : ILookupTrafficLightService
    {
        public async Task<List<LookupTrafficLightDTO>> GetAllOrderedAsync()
        {
            using var context = dbFactory.CreateDbContext();
            return await context.LookupTrafficLights
                .AsNoTracking()
                .Select(u => new LookupTrafficLightDTO
                {
                    trafficLightId = u.trafficLightId,
                    trafficLightName = u.trafficLightName,
                    trafficLightDescription = u.trafficLightDescription,
                })
                .OrderBy(r => r.trafficLightId)
                .ToListAsync();
        }
    }
}
