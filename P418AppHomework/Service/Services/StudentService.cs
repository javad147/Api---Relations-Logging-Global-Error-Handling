using AutoMapper;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public StudentService(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<StudentDto>> GetAll()
    {
        var students = await _studentRepository.GetAll();
        return _mapper.Map<IEnumerable<StudentDto>>(students);
    }

    public async Task<StudentDto> GetById(int id)
    {
        var student = await _studentRepository.GetById(id);
        return _mapper.Map<StudentDto>(student);
    }

    public async Task Add(StudentDto studentDto)
    {
        var student = _mapper.Map<Student>(studentDto);
        await _studentRepository.Add(student);
    }

    public async Task Update(StudentDto studentDto)
    {
        var student = _mapper.Map<Student>(studentDto);
        await _studentRepository.Update(student);
    }

    public async Task Delete(int id)
    {
        var student = await _studentRepository.GetById(id);
        await _studentRepository.Delete(student);
    }

    public async Task<IEnumerable<StudentDto>> Search(string name)
    {
        var students = await _studentRepository.Search(name);
        return _mapper.Map<IEnumerable<StudentDto>>(students);
    }
}
