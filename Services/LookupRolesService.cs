using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TyphoonTaskingTool.Data;
using TyphoonTaskingTool.DTOs;

namespace TyphoonTaskingTool.Services
{
    public class LookupRolesService : ILookupRolesService
    {
        private readonly ApplicationDbContext _db;

        public LookupRolesService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<LookupRoleDTO>> GetAllOrderedAsync()
        {
            return await _db.Roles
                .AsNoTracking()
                .Select(u => new LookupRoleDTO
                {
                    RoleId = u.Id,
                    RoleName = u.Name,
                })
                .OrderBy(r => r.RoleId)
                .ToListAsync();
        }
    }
}
