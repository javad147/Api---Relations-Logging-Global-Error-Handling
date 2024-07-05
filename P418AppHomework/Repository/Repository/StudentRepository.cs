using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Student>> Search(string name)
    {
        return await _context.Students
            .Where(s => s.Name.Contains(name))
            .ToListAsync();
    }
}
