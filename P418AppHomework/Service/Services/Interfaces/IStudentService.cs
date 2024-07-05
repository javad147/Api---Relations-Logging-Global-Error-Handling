public interface IStudentService
{
    Task<IEnumerable<StudentDto>> GetAll();
    Task<StudentDto> GetById(int id);
    Task Add(StudentDto studentDto);
    Task Update(StudentDto studentDto);
    Task Delete(int id);
    Task<IEnumerable<StudentDto>> Search(string name);
}
