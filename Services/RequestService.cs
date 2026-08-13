using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.DTOs;
using TyphoonTaskingTool.Models;

namespace TyphoonTaskingTool.Services
{
    public class RequestService : IRequestService
    {
        private readonly IDbContextFactory<TmscDbContext> _dbFactory;
        private readonly IDbContextFactory<ApplicationDbContext> _identityFactory;

        public RequestService(
            IDbContextFactory<TmscDbContext> dbFactory,
            IDbContextFactory<ApplicationDbContext> identityFactory)
        {
            _dbFactory = dbFactory;
            _identityFactory = identityFactory;
        }

        public async Task<List<RequestsDTO>> GetRequestsForUserAsync(ClaimsPrincipal user)
        {
            using var context = _dbFactory.CreateDbContext();

            bool isAdmin = user.IsInRole("Administrator");
            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            // Materialize required tables separately to avoid EF Core translation issues,
            // then perform joins and projection in-memory.
            var requests = await context.Requests.ToListAsync();
            var ranks = await context.LookupRanks.ToListAsync();
            var statuses = await context.LookupStatuses.ToListAsync();
            var teams = await context.LookupTeams.ToListAsync();
            var updates = await context.RequestUpdates.ToListAsync();

            // Compute latest update per request in-memory
            var latestUpdates = updates
                .GroupBy(u => u.RequestTaskId)
                .ToDictionary(g => g.Key, g => g.OrderByDescending(x => x.UpdateTimeStamp).FirstOrDefault());

            // Batch identity lookup for assigned users to avoid N+1 queries
            var assignedIds = latestUpdates.Values
                .Select(u => u?.AssignmentUserId)
                .Where(id => !string.IsNullOrWhiteSpace(id))
                .Distinct()
                .ToList();

            Dictionary<string, string?> assignedUserNames = new();

            if (assignedIds.Count > 0)
            {
                using var identityCtx = _identityFactory.CreateDbContext();
                assignedUserNames = await identityCtx.Users
                    .Where(u => assignedIds.Contains(u.Id))
                    .Select(u => new { u.Id, u.UserName })
                    .ToDictionaryAsync(x => x.Id, x => x.UserName as string);
            }

            // Build lookup dictionaries for quick access
            var rankById = ranks.Where(x => x.RankId != null).ToDictionary(x => x.RankId);
            var statusById = statuses.Where(x => x.StatusId != null).ToDictionary(x => x.StatusId);
            var teamById = teams.Where(x => x.TeamId != null).ToDictionary(x => x.TeamId);

            // Project into DTOs
            var dtoList = requests.Select(r =>
            {
                latestUpdates.TryGetValue(r.RequestTaskId, out var lu);

                // safe lookups — only attempt when the request id has a value
                LookupRank? rk = null;
                LookupStatus? st = null;
                LookupTeam? tm = null;

                if (r.RankId.HasValue) rankById.TryGetValue(r.RankId.Value, out rk);
                if (r.StatusId.HasValue) statusById.TryGetValue(r.StatusId.Value, out st);
                if (r.TeamId.HasValue) teamById.TryGetValue(r.TeamId.Value, out tm);

                return new RequestsDTO
                {
                    RequestTaskId = r.RequestTaskId,
                    RequestShortId = r.RequestShortId,
                    RequestCreated = r.RequestCreated,
                    RankId = rk?.RankId,
                    RankShortName = rk?.RankNameShort,
                    RequestFirstName = r.RequestFirstName,
                    RequestLastName = r.RequestLastName,
                    RequestEmailAdd = r.RequestEmailAdd,
                    RequestContactPhone = r.RequestContactPhone,
                    UnitId = r.UnitId,
                    TeamId = r.TeamId,
                    TeamNameShort = tm?.TeamNameShort,
                    RequestTitle = r.RequestTitle,
                    RequestTaskDescription = r.RequestTaskDescription,
                    StatusId = st?.StatusId,
                    StatusName = st?.StatusName,
                    RequestArchive = r.RequestArchive,
                    AssignedUserId = lu?.AssignmentUserId,
                    AssignedUserName = lu?.AssignmentUserId != null && assignedUserNames.TryGetValue(lu.AssignmentUserId, out var name) ? name : null
                };
            }).ToList();

            if (isAdmin)
                return dtoList;

            return dtoList
                .Where(r => r.AssignedUserId == userId && (r.RequestArchive == false || r.RequestArchive == null))
                .ToList();
        }
    }
}