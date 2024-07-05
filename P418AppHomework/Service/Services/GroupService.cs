using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GroupService(IGroupRepository groupRepository, IMapper mapper)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GroupDto>> GetAll()
    {
        var groups = await _groupRepository.GetAll();
        return _mapper.Map<IEnumerable<GroupDto>>(groups);
    }

    public async Task<GroupDto> GetById(int id)
    {
        var group = await _groupRepository.GetById(id);
        return _mapper.Map<GroupDto>(group);
    }

    public async Task Add(GroupDto groupDto)
    {
        var group = _mapper.Map<Group>(groupDto);
        await _groupRepository.Add(group);
    }

    public async Task Update(GroupDto groupDto)
    {
        var group = _mapper.Map<Group>(groupDto);
        await _groupRepository.Update(group);
    }

    public async Task Delete(int id)
    {
        var group = await _groupRepository.GetById(id);
        await _groupRepository.Delete(group);
    }

    public async Task<IEnumerable<GroupDto>> Search(string name)
    {
        var groups = await _groupRepository.Search(name);
        return _mapper.Map<IEnumerable<GroupDto>>(groups);
    }
}
