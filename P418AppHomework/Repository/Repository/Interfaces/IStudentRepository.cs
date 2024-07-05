using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface IStudentRepository : IBaseRepository<Student>
{
    Task<IEnumerable<Student>> Search(string name);
}
