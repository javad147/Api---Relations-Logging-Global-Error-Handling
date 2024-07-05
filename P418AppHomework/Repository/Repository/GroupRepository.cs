using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GroupRepository : BaseRepository<Group>, IGroupRepository
{
    public GroupRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Group>> Search(string name)
    {
        return await _context.Groups
            .Where(g => g.Name.Contains(name))
            .ToListAsync();
    }
}
