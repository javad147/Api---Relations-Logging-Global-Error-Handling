using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IGroupRepository : IBaseRepository<Group>
{
    Task<IEnumerable<Group>> Search(string name);
}
