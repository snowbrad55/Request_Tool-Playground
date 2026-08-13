using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.DTOs;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Services
{
    /// LookupTeamService is a service class that provides methods to interact with the LookupTeam table 
    /// in the database. It implements the ILookupTeamService interface and uses an 
    /// IDbContextFactory<TmscDbContext> to create instances of the database context.
    /// Protecting the database through the use of associated DTOs (Data Transfer Objects) to ensure 
    /// that only the necessary data is exposed to the client.
    public class LookupTeamService(IDbContextFactory<TmscDbContext> dbFactory) : ILookupTeamService
    {
        //Find all teams ordered by TeamId
        public async Task<List<LookupTeamDTO>> GetAllOrderedAsync()
        {
            using var context = dbFactory.CreateDbContext();
            return await context.LookupTeams
                .AsNoTracking()
                .Select(u => new LookupTeamDTO
                {
                    TeamId = u.TeamId,
                    TeamNameLong = u.TeamNameLong,
                    TeamNameShort = u.TeamNameShort,
                })
                .OrderBy(r => r.TeamId)
                .ToListAsync();
        }

        //Find a team by its ID
        public async Task<LookupTeamDTO?> GetByIdAsync(int teamId)
        {
            using var ctx = dbFactory.CreateDbContext();
            return await ctx.LookupTeams
                .AsNoTracking()
                .Where(t => t.TeamId == teamId)
                .Select(t => new LookupTeamDTO
                {
                    TeamId = t.TeamId,
                    TeamNameLong = t.TeamNameLong,
                    TeamNameShort = t.TeamNameShort,
                })
                .FirstOrDefaultAsync();
        }

        //Add a new team
        public async Task<bool> AddAsync(LookupTeamDTO tDto)
        {
            using var ctx = dbFactory.CreateDbContext();
            var entity = new LookupTeam
            {
                TeamId = tDto.TeamId,
                TeamNameLong = tDto.TeamNameLong,
                TeamNameShort = tDto.TeamNameShort,
            };
            ctx.LookupTeams.Add(entity);

            return await ctx.SaveChangesAsync() > 0;
        }

        //Update an existing team
        public async Task<bool> UpdateAsync(LookupTeamDTO tDto)
        {
            using var ctx = dbFactory.CreateDbContext();
            var entity = await ctx.LookupTeams.FindAsync(tDto.TeamId);
            if (entity == null)
            {
                return false;
            }
            entity.TeamNameLong = tDto.TeamNameLong;
            entity.TeamNameShort = tDto.TeamNameShort;
            return await ctx.SaveChangesAsync() > 0;
        }

        //Delete a team by its ID
        public async Task<bool> DeleteAsync(int teamId)
        {
            using var ctx = dbFactory.CreateDbContext();
            var entity = await ctx.LookupTeams.FindAsync(teamId);
            if (entity == null)
            {
                return false;
            }
            ctx.LookupTeams.Remove(entity);
            return await ctx.SaveChangesAsync() > 0;
        }
    }
}
