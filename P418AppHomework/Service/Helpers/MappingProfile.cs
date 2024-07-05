using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Student, StudentDto>().ReverseMap();
        CreateMap<Group, GroupDto>().ReverseMap();
    }
}
